using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        //Nullable numerics
        //why do we NOT need to fully implement a nullable numeric?
        //numerics have a default of zero
        //numerics can only store a numeric value (unless nullable)
        //numerics can be null if declared as nullable
        //the only 2 possibilities for a nullable numeric is a number or null
        //if the numeric has additional criteria then you can code the property as a Fully Implemented property

        // int? means it doesnt have to require a value, it could be null (nullable)
        //Opposite, just int means we need to assign it a value
        public int? NumberofPanes { get; set; }

        //  ---Constructors---
        //a constructor is "a method" that guarantees the newly created instance of this class will ALWAYS be created in "a known state"

        //+ syntax
        //public constructorname([ListBindable of parameters])
        //{
        //    your code
        //}

        //the constructorname has the SAME class name
        //NOTE: there is NO RETURN DATATYPE

        //constructor(s) are called on your behave WHEN an instance of the class is requested by the program
        //you cannot call a constructor directly like a method.

        //constructor(s) are OPTIONAL
        //IF a class DOES NOT have a constructor THEN the system will generate the class instance using the datatyep defaults for your private data members and auto implemented properties
        //this situation of no constructor(s) is often referred to as using a "system"constructor

        //IF you code a constructor, then you MUST code ANY and ALL constructor(s) needed by your class as used in your programming

        // + There are TWO COMMON type of constructor
        //   ++ Default constructor: takes NO parameters
        //   ++ Greedy constructor: simulates the "system" constructor
        //you can if you wish assign value to your class data members/properties that are NOT the system defaults for the datatype

        //Default constructor
        public Window()
        {
            //technically numerics are set to zero when they are declared
            //logically in this class the numeric fields should NOT be zero
            //therefor, we will set the numeric fields to a literal not equal to zero

            //one could assign a value directly to a private data member within the class
            //a preferred method is to use the properties instead
            //why?  because that property MAY have calidation to ensure an acceptable value exists for the data
            //      also, auto implemented properties have no direct private data members

            Height = 0.9m;  //assume the widow height is .9 meters
            Width = 1.2m;
            NumberofPanes = 1;
            Manufacturer = null;    //this is optional as a string is default to null anyways
        }

        //Greedy
        //takes in a value for each data member/property in the class
        //each data member/property is assigned the appropriate incoming parameter value
        public Window(decimal width, decimal height, int? numberofpanes, string manufacturer)
        {
            Width = width;
            Height = height;
            NumberofPanes = numberofpanes;
            Manufacturer = manufacturer;
        }



        //Behaviors (methods)
    }
}
