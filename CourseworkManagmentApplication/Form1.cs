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
        // Creating arrays with some preset values.
        string[] username = { "Callum", "Tom" };
        string[] password = { "admin", "loser" };

        // Pre-defining the user types to moderate accessibility in an array.
        string[] type = { "DoS", "Lec", "ModLead", "Moderator", "ProgDirector", "facHub" };

        // Converting the usernames and passwords into lists of strings.
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        List<string> types = new List<string>();
        private void button1_Click(object sender, EventArgs e) // Login Button
        {
            // If the username & password entered in the textboxes matches the values in the array, this statement is ran.
            if (username.Contains(usernameBox.Text) && password.Contains(passwordBox.Text) && Array.IndexOf(username, usernameBox.Text) == Array.IndexOf(password, passwordBox.Text))
            {

                /* string displayTypes = string.Join(Environment.NewLine, types);
                MessageBox.Show(displayTypes); */

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
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setAMButtonVisible(false); // Setting the deadline button to invisible.
                    mainForm.setUSButtonVisible(false); // Setting the update scrutiny form button to invisible.
                    mainForm.setVASButtonVisible(false); // Setting the view assessment strategy button to invisible.
                }
                // Checking if the user is a module leader.
                else if (j == type[2])
                {
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setAMButtonVisible(false); // Setting the deadline button to invisible.

                }
                // Checking if the user is a moderator.
                else if (j == type[3])
                {
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setAMButtonVisible(false); // Setting the deadline button to invisible.
                    mainForm.setMAButtonVisible(false); // Setting the modify assessment button to invisible.
                    mainForm.setVASButtonVisible(false); // Setting the view assessment strategy button to invisible.
                }
                // Checking if the user is a program director.
                else if (j == type[4])
                {
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setAMButtonVisible(false); // Setting the deadline button to invisible.
                    mainForm.setMAButtonVisible(false); // Setting the modify assessment button to invisible.
                    mainForm.setVASButtonVisible(false); // Setting the view assessment strategy button to invisible.
                }
                // Checking if the user is a member of the faculty hub.
                else if (j == type[5])
                {
                    Main mainForm = new Main(); // Creating an instance of the second window.
                    this.Visible = false; // Setting the login form to invisible.
                    mainForm.Show(); // Opening the main application page.
                    mainForm.setAMButtonVisible(false); // Setting the deadline button to invisible.
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
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]); // Adding the first component of the line to the list of usernames.
                pass.Add(components[1]); // Adding the second component of the line to the list of passwords.
                types.Add(components[2]); // Adding the third component of the line to the list of user types.
            }
            sr.Close(); // End StreamReader
        }
    }
}
