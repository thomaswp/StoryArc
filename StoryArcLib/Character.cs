using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryArc
{
    public class Character
    {
        public string Name
        {
            get { return string.Join(" ", FirstName, MiddleName, LastName); }
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Character()
        {
            FirstName = "First";
            MiddleName = "Middle";
            LastName = "Last";
        }
    }
}
