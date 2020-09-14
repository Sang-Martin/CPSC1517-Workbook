using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoloApp
{
    // a class represents the defined characteristics of an item
    // an item can be a physical thing (cellphone), concept (student)
    // represent a collection of data or/and methods
    // Visual Studio creates your classes without a specific access type
    // type default type for a class is private
    // code outside of a private class cannot use the contents of the private class
    // for the class to be used by an outside user (program) is must be public
    public class Window
    {
        //  ---Class---
        //the class can have data that is open to the user by defining it as a public datatype
        //the class can have data(local variable) that is restricted from the user by defining it as a private datatype
        //the class can create a Proterty that can by used to interface between the user and the private data member
        //this interface is a public Property

        //  ---Properties---

        //private data menber
        private string _Manufacturer;
        private decimal _Height;

        //  optional
        //  Properties can be implemented in two ways
        //      a) Fully Implemented Property
        //          used because there is additional code/logic use in processing the data
        public string Manufacturer
        {
            //assume the Manufacturer is a nullable string
            //3 possibilities
            //  a)there are characters in the string
            //  b)string has not data (null)
            //  c)there is a physical string BUT NO characters other than the end of string character
            //there will be additional code/logic to ensure ONLY case a and b exits for the data
            //this requires a private data member to hold the data and a property to manage the data content


            //imagine an assigment statement
            //receiving variable(left side) = sending data (right side)

            get
            {
                //RETURN DATA via the property to the outside user of that property
                //right side of an assignment statement
                //the data that is being return will normally come from a private
                return _Manufacturer;
            }
            set
            {
                //STORE DATA via property from the outside user of that property
                //left side of an assignment statement
                //stores the date into your private data member
                //internal to the property is a common variable that will hold the incoming data, this variable is called value
                //a property is associated with a SINGLE data member
                //a property has NO parameter list
                if(string.IsNullOrEmpty(value))    
                    //case b and c
                    _Manufacturer = null;
                else
                    _Manufacturer = value;
                //alternative way of coding set (Ternary operator)
                _Manufacturer = string.IsNullOrEmpty(value) ? null : value;
                
            }
        }


        //      b) Auto Implemented Property
        //          used when there is no need for additional code/logic, when the date is simply saved(stored)
        //          No internal private DATA MEMBER IS REQUIRED for this property
        //          the system will internally generate a data area for the data accessing this stored data (getting 

        public decimal Width { get; set; }


        //what if, thedata coming in is invalid?
        //will there be additional logic/code need? YES
        //what property implementation is needed? Fully implemented

        public decimal Height
        {
            get { return _Height; }
            set
            {
                //the m on the literal indicates the value is a decimal
                if(value <= 0.0m)
                {
                    throw new Exception("Height can not be 0 or less than 0");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        //  ---Constructors---

        //Behaviors (methods)
    }
}
