using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int Order { get; set; }
        public string Red { get; set; }
        public string Blue { get; set; }
        public string Green { get; set; }

        public string DisplayOrderedName()
        {
            string orderedName = "";
            switch (Order)
            {
                case 1:
                    orderedName=$"{FirstName} {MiddleInitial} {LastName}";
                    break;
                case 2:
                    orderedName= $"{FirstName} {LastName}";
                    break;
                case 3:
                    orderedName = $"{LastName}, {FirstName} {MiddleInitial}";
                    break;
                case 4:
                    orderedName = $"{LastName}, {FirstName}";
                    break;
            }
            return orderedName;
        }
    }
}