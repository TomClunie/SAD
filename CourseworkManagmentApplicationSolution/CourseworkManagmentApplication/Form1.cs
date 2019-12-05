using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkManagmentApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string cUser = ""; // Declaring a current user variable.

        // Creating arrays with some preset values.
        string[] username = { "Callum", "Tom" };
        string[] password = { "admin", "loser" };

        // Pre-defining the user types to moderate accessibility in an array.
        string[] type = { "Director Of Study", "Academic", "Module Leader", "Programme Director", "Faculty Hub" };

        // Converting the usernames and passwords into lists of strings.
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        List<string> name = new List<string>();
        List<string> types = new List<string>();

        private void button1_Click(object sender, EventArgs e) // Login Button
        {
            // If the username & password entered in the textboxes matches the values in the array, this statement is ran.
            if (username.Contains(usernameBox.Text) && password.Contains(passwordBox.Text) && Array.IndexOf(username, usernameBox.Text) == Array.IndexOf(password, passwordBox.Text))
            {
                /* string displayTypes = string.Join(Environment.NewLine, types);
                MessageBox.Show(displayTypes); */
                cUser = usernameBox.Text;
                Main mainForm = new Main(); // Creating an instance of the second window.
                mainForm.ShowDialog(); // Opening the main application page.
                this.Visible = false; // Closing the login page.

            }
            // Checking text box entries against array to ensure correct user type is assigned & logs them in.
            else if (users.Contains(usernameBox.Text) && pass.Contains(passwordBox.Text) && Array.IndexOf(users.ToArray(), usernameBox.Text) == Array.IndexOf(pass.ToArray(),
                passwordBox.Text))
            {
                var i = Array.IndexOf(users.ToArray(), usernameBox.Text); // The index of the specific user that logged in.
                var j = types[i]; // The specific user type.

                // Checking if the user is the director of studies.
                if (j == type[0])
                {
                    cUser = usernameBox.Text;
                    //MessageBox.Show("Dos");
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    mainForm.Show(); // Opening the main application page.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.setMAButtonVisible(false); // Setting the modify assessment button to invisible.
                    mainForm.setVASButtonVisible(false); // Setting the view assessment strategy button to invisible.
                }
                // Checking if the user is a lecturer.
                else if (j == type[1])
                {
                    cUser = usernameBox.Text;
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setUSButtonVisible(false); // Setting the update scrutiny form button to invisible.
                    mainForm.setVASButtonVisible(false); // Setting the view assessment strategy button to invisible.
                }
                // Checking if the user is a module leader.
                else if (j == type[2])
                {
                    cUser = usernameBox.Text;
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.

                }
                // Checking if the user is a program director.
                else if (j == type[3])
                {
                    cUser = usernameBox.Text;
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setMAButtonVisible(false); // Setting the modify assessment button to invisible.
                    mainForm.setVASButtonVisible(false); // Setting the view assessment strategy button to invisible.
                }
                // Checking if the user is a member of the faculty hub.
                else if (j == type[4])
                {
                    cUser = usernameBox.Text;
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setMAButtonVisible(false); // Setting the modify assessment button to invisible.
                    mainForm.setVASButtonVisible(false); // Setting the view assessment strategy button to invisible.
                }
            }
            else
                // Error message
                MessageBox.Show("The credentials you entered are invalid!");
        }

        private void Form1_Load(object sender, EventArgs e) // On original form load.
        {
            StreamReader sr = new StreamReader("users.txt"); // The data file name and extension.
            string line = null;
            // While the line isn't blank.
            while ((line = sr.ReadLine()) != null)
            {
                // Seperating the usernames and passwords that are saved on the same line.
                string[] components = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]); // Adding the first component of the line to the list of usernames.
                pass.Add(components[1]); // Adding the second component of the line to the list of passwords.
                name.Add(components[2]); // Adding the third comement of the line to the list of names.
                types.Add(components[3]); // Adding the fourth component of the line to the list of user types.

                string[] bits = line.Split(',');
                if (bits.Length == 4)
                {
                    if (bits[3] == "Director Of Study")
                    {
                        User.listOfUsers.Add(new DirectorOfStudy(bits[0], bits[2]));
                    }
                    if (bits[3] == "Programme Director")
                    {
                        User.listOfUsers.Add(new ProgrammeDirector(bits[0], bits[2]));
                    }
                    if (bits[3] == "Module Leader")
                    {
                        User.listOfUsers.Add(new ModuleLeader(bits[0], bits[2]));
                    }
                    if (bits[3] == "Academic")
                    {
                        User.listOfUsers.Add(new Academic(bits[0], bits[2]));
                    }
                    if (bits[3] == "Faculty Hub")
                    {
                        User.listOfUsers.Add(new FacultyHub(bits[0], bits[2]));
                    }
                }
            }
            sr.Close(); // End StreamReader

            //Load and save deadlines to lists
            string bitLine;
            StreamReader reader = new StreamReader(@".\\deadlines.txt");

            while ((bitLine = reader.ReadLine()) != null)
            {
                string[] bits = bitLine.Split(',');

                if (bits[0] == "Admin: Administer Panel")
                {
                    if (bits.Length == 6)
                    {
                        DeadlineClasses.panels.Add(new AdminPanel(bits[1], bits[2], bits[3], bits[4], bits[5]));
                    }
                    else
                    {
                        DeadlineClasses.panels.Add(new AdminPanel(bits[1], bits[2], bits[3], bits[4], ""));
                    }
                }

                if (bits[0] == "Admin: Book Meeting Room")
                {
                    if (bits.Length == 6)
                    {
                        DeadlineClasses.meetings.Add(new AdminMeeting(bits[1], bits[2], bits[3], bits[4], bits[5]));
                    }
                    else
                    {
                        DeadlineClasses.meetings.Add(new AdminMeeting(bits[1], bits[2], bits[3], bits[4], ""));
                    }
                }

                if (bits[0] == "Assignment")
                {
                    if (bits.Length == 6)
                    {
                        DeadlineClasses.assignments.Add(new Assignment(bits[1], bits[2], bits[3], bits[4], bits[5]));
                    }
                    else
                    {
                        DeadlineClasses.assignments.Add(new Assignment(bits[1], bits[2], bits[3], bits[4], ""));
                    }
                }
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
