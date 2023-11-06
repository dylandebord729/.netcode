using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot
{
    public class Robot {
        public Robot() { }
        public string Direction { get; set; } = "N";
        public Point Location { get; set; } = new Point(0,0);

        public Point Move(int spaces)  
        {
            Point Location2 = new Point();
            Location2 = Location;
            switch (Direction)
            {
                case "N":
                    if (Location.Y - spaces < -100)
                    {
                        MessageBox.Show("-100 is the limit.");
                    }
                    else
                    {
                        Location2.Y = Location.Y - spaces;
                    }
                    break;
                case "S":
                    if (Location.Y + spaces > 100)
                    {
                        MessageBox.Show("100 is the limit.");
                    }
                    else
                    {
                        Location2.Y = Location.Y + spaces;
                    }
                    break;
                case "E":
                    if (Location.X + spaces > 100)
                    {
                        MessageBox.Show("100 is the limit.");
                    }
                    else
                    {
                        Location2.X = Location.X + spaces;
                    }
                    break;
                case "W":
                    if (Location.X - spaces < -100)
                    {
                        MessageBox.Show("-100 is the limit.");
                    }
                    else
                    {
                        Location2.X = Location.X - spaces;
                    }
                    break;

            }
            
            return Location2;
            
        }
    }


    }
/*Method called move
 * Data strutructure called struct
 * Intialization
 */