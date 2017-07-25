using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class AlienTravelModel
    {
        public double Age { get; set; }
        public double Distance { get; set; }
        public string PlanetName { get; set; }
        public string PlanetHolder { get; set; }
        public string TransportHolder { get; set; }
        public string ModeOfTransport { get; set; }
        public double Speed { get; set; }

        public static List<SelectListItem> Planets { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Mercury", Value = "Mercury:56974146" },
            new SelectListItem() { Text = "Venus", Value = "Venus:25724767" },
            new SelectListItem() { Text = "Mars", Value = "Mars:48678219" },
            new SelectListItem() { Text = "Jupiter", Value = "Jupiter:390674710" },
            new SelectListItem() { Text = "Saturn", Value = "Saturn:792248270" },
            new SelectListItem() { Text = "Neptune", Value = "Neptune:2703959960" },
            new SelectListItem() { Text = "Uranus", Value = "Uranus:1692662530"},
        };

        public static List<SelectListItem> Transport { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Walking", Value = "Walking:3" },
            new SelectListItem() { Text = "Car", Value = "Car:100" },
            new SelectListItem() { Text = "Bullet Train", Value = "Bullet Train:200" },
            new SelectListItem() { Text = "Boeing 747", Value = "Boeing 747:570" },
            new SelectListItem() { Text = "Concorde", Value = "Concorde:1350" },
        };

        public double CalculateYearsTraveled()
        {
            string[] temp = PlanetHolder.Split(':');
            PlanetName = temp[0];
            Distance = Convert.ToDouble(temp[1]);

            string[] temp2 = TransportHolder.Split(':');
            ModeOfTransport = temp2[0];
            Speed = Convert.ToDouble(temp2[1]);

            return (Distance / Speed) / 8760;
        }
    }
}