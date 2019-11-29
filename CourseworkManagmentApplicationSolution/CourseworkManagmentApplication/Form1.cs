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

        // Converting the usernames and passwords into lists of strings.
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        List<string> type = new List<string>();
        private void button1_Click(object sender, EventArgs e) // Login Button
        {
            // If the username & password entered in the textboxes matches the values in the array, this statement is ran.
            if (username.Contains(usernameBox.Text) && password.Contains(passwordBox.Text) && Array.IndexOf(username, usernameBox.Text) == Array.IndexOf(password, passwordBox.Text))
            {
                Main mainForm = new Main(); // Creating an instance of the second window.
                mainForm.ShowDialog(); // Opening the main application page.
                this.Visible = false; // Closing the login page.

            }
            // Converting the users & pass values into arrays
            else if (users.Contains(usernameBox.Text) && pass.Contains(passwordBox.Text) && Array.IndexOf(users.ToArray(), usernameBox.Text) == Array.IndexOf(pass.ToArray(), passwordBox.Text))
            {
                Main mainForm = new Main(); // Creating an instance of the second window.
                mainForm.ShowDialog(); // Opening the main application page.
                this.Visible = false; // Closing the login page.
            }
            else
                // Error message
                MessageBox.Show("The credentials you entered are invalid");
        }

        private void Form1_Load(object sender, EventArgs e) // On original form load.
        {
            StreamReader sr = new StreamReader("users.txt"); // The data file name and extension.
            string line = null;
            // While the line isn't blank.
            while ((line = sr.ReadLine()) != null) {
                // Seperating the usernames and passwords that are saved on the same line.
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]); // Adding the first component of the line to the list of usernames.
                pass.Add(components[1]); // Adding the second component of the line to the list of passwords.
                type.Add(components[2]); // Adding the third component of the line to the list of user types.
            }
            sr.Close(); // End StreamReader
        }
    }
}
