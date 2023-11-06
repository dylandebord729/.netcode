using System.Security.Cryptography.X509Certificates;

namespace SimpleRobot
{
    public partial class Form1 : Form
    {
        Robot robot = new Robot();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayLocation();
        }

        private void btnGoOne_Click(object sender, EventArgs e)
        {
            robot.Location = robot.Move(1);
            DisplayLocation();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            robot.Direction = "N";
            DisplayLocation();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            robot.Direction = "E";
            DisplayLocation();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            robot.Direction = "S";
            DisplayLocation();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            robot.Direction = "W";
            DisplayLocation();
        }

        private void btnGTen_Click(object sender, EventArgs e)
        {
            robot.Location = robot.Move(10);
            DisplayLocation();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayLocation()
        {
            char arrow = '1';
            switch (robot.Direction)
            {
                case "N":
                    arrow = Convert.ToChar(233);
                    break;
                case "S":
                    arrow = Convert.ToChar(234);
                    break;
                case "E":
                    arrow = Convert.ToChar(232);
                    break;
                case "W":
                    arrow = Convert.ToChar(231);
                    break;
            }
            lbDirection.Text = arrow + "";
            Point newLocation = new Point();
            newLocation = robot.Location;
            newLocation.Offset(100, 100);
            lbDirection.Location = newLocation;
            lbOrderedPair.Text = robot.Location.ToString();
        }
    }
}