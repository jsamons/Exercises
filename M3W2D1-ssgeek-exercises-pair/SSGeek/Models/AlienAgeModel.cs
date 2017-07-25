using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class AlienAgeModel
    {
        private string planetName = "";
        private double conversionFactor = 0;

        public double Age { get; set; }
        public double ConversionFactor { get; set; }
        public string PlanetName { get; set; }
        public string PlanetFactor { get; set; }
        public double AlienAge { get; set; }


        public static List<SelectListItem> Planets { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Mercury", Value = "Mercury:4.15" },
            new SelectListItem() { Text = "Venus", Value = "Venus:1.62" },
            new SelectListItem() { Text = "Mars", Value = "Mars:.53" },
            new SelectListItem() { Text = "Jupiter", Value = "Jupiter:.084" },
            new SelectListItem() { Text = "Saturn", Value = "Saturn:.034" },
            new SelectListItem() { Text = "Neptune", Value = "Neptune:.006" },
            new SelectListItem() { Text = "Uranus", Value = "Uranus:.004"},
        };
        public double CalculateAlienAge()
        {
            string[] planetInfo = PlanetFactor.Split(':');
            PlanetName = planetInfo[0];
            ConversionFactor = Convert.ToDouble(planetInfo[1]);
            return (Age * ConversionFactor);
        }
    }
}