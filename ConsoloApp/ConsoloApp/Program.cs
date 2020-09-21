using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default constructor
            //Default constructor
            //create an instance of the Window class using the default constructor
            //the system calls your class constructor via the "new" command
            //the "new" will use the indicated constructor
            //the "new" actually makes the call to the constructor and returns the instance of the class
            //your code NEVER calls the constructor directly
            Window myDefaultInstance = new Window();

            //results of the Default constructor

            myDefaultInstance.Height = 2.75m;
            myDefaultInstance.Width = 1.9m;
            myDefaultInstance.NumberofPanes = 3;
            myDefaultInstance.Manufacturer = "See Thru Holes";

            Console.WriteLine($"Width {myDefaultInstance.Width}; " +
                $"Height {myDefaultInstance.Height}; Panes {myDefaultInstance.NumberofPanes}; Manufacturer {myDefaultInstance.Manufacturer}");
            #endregion


            #region Greedy constructor

            //Greedy constructor
            Window myGreedyInstance = new Window(3.75m, 2.9m, 5, "See Thru Holes Again");

            Console.WriteLine($"Width {myGreedyInstance.Width}; " +
                $"Height {myGreedyInstance.Height}; Panes {myGreedyInstance.NumberofPanes}; Manufacturer {myGreedyInstance.Manufacturer}");

            #endregion


            UsingClasses();

            //Console.ReadLine();
            Console.ReadKey();
        }

        static void UsingClasses()
        {
            //the purpose of this method is to calculate the cost of painting a room
            //the room will have several windows and walls with a single door
            //all data for windows, walls and doors will be collected and stored in an instance of Room

            //what does Room need
            //declare a set of List<T> for the components of the Room
            List<Wall> walls = new List<Wall>();
            List<Window> windows = new List<Window>();
            List<Door> doors = new List<Door>();
            Room room = new Room(); //Default constructor

            //read and collect the data for the room
            //create a reusable pointer variable to each of the components of a room(wall, window, door)
            //these pointers are created outside of my input loops
            Wall wall = null;
            Window window = null;
            Door door = null;


            //collect the data for all of the walls in the room
            //loop of prompt/input/validation for eac hwall

            //after validation of data, create an instance of the need class
            wall = new Wall();
            //load data into the instance
            wall.Width = 6.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T>) to save the data
            walls.Add(wall);
            //end of wall loop

            //Door loop
            //collect the data for all of the doors in the room
            //loop of prompt /input/validation for each door
            //assume in this example that the literials were actually in variable

            door = new Door(0.85m, 2.0m, "R", "Composite Pressed Wood");
            doors.Add(door);
            //end of door loop

            //Window loop
            //prompt/input/validate
            //store
            window = new Window(1.3m, 1.3m, 2, "Fancy Window");
            windows.Add(window);


            #region store all room components in an instance of room

            //store all room components in an instance of room
            room.Name = "Master Bedroom";
            room.Walls = walls;
            room.Windows = windows;
            room.Doors = doors;

            #endregion


            //calculate the number of cans of paint needed for the room
            //assume a can of paint covers 27.87 sq m
            //determine the area of wall surface to paint
            //total area of walls 
            //total area of windows
            //total area of doors
            //paintable surface = wallarea (windowarea + doorarea)
            //cans = paintable surface / 27.87m

            decimal wallarea = 0.0m;
            foreach (Wall item in room.Walls)
            {
                wallarea += item.WallArea();
            }

            decimal doorarea = 0.0m;
            foreach (Door item in doors)
            {
                doorarea += item.DoorArea();
            }

            decimal windowarea = 0.0m;
            //var is a datatype
            //var is resolved at execution time, while others(int, string,...) resolved at the COMPLIED TIME
            //the resolved datatype remains as the resolved datatype until the variable is terminated
            foreach (var item in windows)
            {
                windowarea += item.WindowArea();
            }

            decimal cans = (wallarea - windowarea - doorarea) / 27.87m;

            //output
            Console.WriteLine($"Wallarea is:\t\t{wallarea:0.00}");
            Console.WriteLine($"Door area is:\t\t{doorarea:0.00}");
            Console.WriteLine($"Window area is:\t\t{windowarea:0.00}");
            Console.WriteLine($"Required number of paint cans is:\t{cans:0.00}");

        }
    }
}
