using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class AlienWeightModel
    {
        public double EarthWeight { get; set; }
        public double ConversionFactor { get; set; }
        public string PlanetName { get; set; }
        public string GravityFactor { get; set; }
        public double AlienWeight { get; set; }

        public static List<SelectListItem> Planets { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Mercury", Value = "Mercury:0.37" },
            new SelectListItem() { Text = "Venus", Value = "Venus:0.90" },
            new SelectListItem() { Text = "Mars", Value = "Mars:0.38" },
            new SelectListItem() { Text = "Jupiter", Value = "Jupiter:2.65" },
            new SelectListItem() { Text = "Saturn", Value = "Saturn:1.13" },
            new SelectListItem() { Text = "Neptune", Value = "Neptune:1.43" },
            new SelectListItem() { Text = "Uranus", Value = "Uranus:1.09"},
        };

        public double CalculateAlienWeight()
        {
            string[] planetInfo = GravityFactor.Split(':');
            PlanetName = planetInfo[0];
            ConversionFactor = Convert.ToDouble(planetInfo[1]);
            return (EarthWeight * ConversionFactor);
        }
    }
}