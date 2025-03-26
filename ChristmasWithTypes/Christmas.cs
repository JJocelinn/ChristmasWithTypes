using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public string TreeHeight = null;//TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
        public enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    }
}
