using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoloApp
{
    public class Door
    {
        //height, width, material (nullable), right or left swing door

        //height and width > 0.0m

        //height has a default of 1.75, width is 1.2

        //right or left are indicated with an R or L

        //Area and perimeter of the door

        //throw exceptions for invalid data

        private decimal _Height;
        private decimal _Width;
        private string _Material;
        private string _RightOrLeft;

        public decimal Height
        {
            get { return _Height; }
            set
            {
                if (value <= 0.0m)
                    throw new Exception("Height can not be 0 or less than 0");
                else
                    _Height = value;
            }
        }

        public decimal Width
        {
            get { return _Width; }
            set
            {
                if (value <= 0.0m)
                    throw new Exception("Width can not be 0 or less than 0");
                else
                    _Width = value;
            }
        }
        public string Material
        {
            get { return _Material; }
            set
            {
                _Material = string.IsNullOrEmpty(value) ? null : value;
            }
        }

        public string RightOrLeft
        {
            get { return _RightOrLeft; }
            set
            {
                if (value.ToUpper().Equals("R") || value.ToUpper().Equals("L"))
                    _RightOrLeft = value;
                else
                    throw new Exception("Invalid value");
            }
        }


        public Door()
        {
            Height = 1.75m;
            Width = 1.2m;
            RightOrLeft = "R";

        }

        public Door(decimal height, decimal width, string rightorleft, string material)
        {
            Height = height;
            Width = width;
            RightOrLeft = rightorleft;
            Material = material;
        }

        //Area of a Door
        public decimal DoorArea()
        {
            return Height * Width;
        }

        //Perimeter of a Window
        public decimal DoorPerimeter()
        {
            return 2 * (Height + Width);
        }

    }
}
