using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseworkManagmentApplication
{
    public partial class Deadlines : Form
    {
        //Deadline lists
        List<AdminPanel> panels = new List<AdminPanel>();
        List<AdminMeeting> meetings = new List<AdminMeeting>();
        List<Assignment> assignments = new List<Assignment>();

        public Deadlines()
        {
            InitializeComponent();
        }

        private void Deadlines_Load(object sender, EventArgs e)
        {
            //Set initial date time picker value
            dateTimePicker.Value = DateTime.Now;

            //Load and save deadlines to lists
            string line;
            StreamReader reader = new StreamReader(@".\\deadlines.txt");

            while ((line = reader.ReadLine()) != null)
            {
                string[] bits = line.Split(',');

                if (bits[0] == comboBoxType.Items[0].ToString())
                {
                    if (bits.Length == 6)
                    {
                        panels.Add(new AdminPanel(bits[1], bits[2], bits[3], bits[4], bits[5]));
                    }
                    else
                    {
                        panels.Add(new AdminPanel(bits[1], bits[2], bits[3], bits[4], ""));
                    }
                }

                if (bits[0] == comboBoxType.Items[1].ToString())
                {
                    if (bits.Length == 6)
                    {
                        meetings.Add(new AdminMeeting(bits[1], bits[2], bits[3], bits[4], bits[5]));
                    }
                    else
                    {
                        meetings.Add(new AdminMeeting(bits[1], bits[2], bits[3], bits[4], ""));
                    }
                }

                if (bits[0] == comboBoxType.Items[2].ToString())
                {
                    if (bits.Length == 6)
                    {
                        assignments.Add(new Assignment(bits[1], bits[2], bits[3], bits[4], bits[5]));
                    }
                    else
                    {
                        assignments.Add(new Assignment(bits[1], bits[2], bits[3], bits[4], ""));
                    }
                }
            }
            reader.Close();

            //Read and save users
            StreamReader userReader = new StreamReader(@".\\userz.txt");

            while ((line = userReader.ReadLine()) != null)
            {
                string[] bits = line.Split(',');
                if (bits.Length == 3)
                {
                    if (bits[2] == "Director Of Study")
                    {
                        User.listOfUsers.Add(new DirectorOfStudy(bits[0], bits[1]));
                    }
                    if (bits[2] == "Programme Director")
                    {
                        User.listOfUsers.Add(new ProgrammeDirector(bits[0], bits[1]));
                    }
                    if (bits[2] == "Module Leader")
                    {
                        User.listOfUsers.Add(new ModuleLeader(bits[0], bits[1]));
                    }
                    if (bits[2] == "Academic")
                    {
                        User.listOfUsers.Add(new Academic(bits[0], bits[1]));
                    }
                    if (bits[2] == "Moderator")
                    {
                        User.listOfUsers.Add(new Moderator(bits[0], bits[1]));
                    }
                    if (bits[2] == "Faculty Hub")
                    {
                        User.listOfUsers.Add(new FacultyHub(bits[0], bits[1]));
                    }
                }
            }

            userReader.Close();

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear items and selection if selected item in combo box 1 changes
            richTextBox.Clear();
            dateTimePicker.Value = DateTime.Now;
            comboBoxName.SelectedIndex = -1;
            comboBoxName.Items.Clear();
            comboBoxUser.SelectedIndex = -1;
            comboBoxUser.Items.Clear();

            //Change contents of the 2nd combo box depending on which item is selected in the first combobox
            if (comboBoxType.SelectedIndex == 0)
            {       
                for (int i = 0; i < panels.Count; i++)
                {
                    comboBoxName.Items.Add(panels[i].getName());
                }
                for (int j = 0; j < User.listOfUsers.Count; j++)
                {
                    if (User.listOfUsers[j].GetType().ToString().Contains("FacultyHub"))
                    {
                        comboBoxUser.Items.Add(User.listOfUsers[j].getName());
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 1)
            {
                for (int i = 0; i < meetings.Count; i++)
                {
                    comboBoxName.Items.Add(meetings[i].getName());
                }

                for (int j = 0; j < User.listOfUsers.Count; j++)
                {
                    if (User.listOfUsers[j].GetType().ToString().Contains("FacultyHub"))
                    {
                        comboBoxUser.Items.Add(User.listOfUsers[j].getName());
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 2)
            {
                for (int i = 0; i < assignments.Count; i++)
                {
                    comboBoxName.Items.Add(assignments[i].getName());
                    
                }

                for (int j = 0; j < User.listOfUsers.Count; j++)
                {
                    if (User.listOfUsers[j].GetType().ToString().Contains("ModuleLeader") || User.listOfUsers[j].GetType().ToString().Contains("Academic") || User.listOfUsers[j].GetType().ToString().Contains("Moderator") || User.listOfUsers[j].GetType().ToString().Contains("ProgrammeDirector"))
                    {
                        comboBoxUser.Items.Add(User.listOfUsers[j].getName());
                    }
                }
            }
        }

        //Display information for each selected item
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                for (int i = 0; i < panels.Count; i++)
                {
                    if (panels[i].getName() == comboBoxName.Text.ToString())
                    {
                        richTextBox.Text = panels[i].getComment();
                        dateTimePicker.Value = DateTime.Parse(panels[i].getDueDate());

                        var username = panels[i].getUser();

                        for (int j = 0; j < User.listOfUsers.Count; j++)
                        {
                            if (username == User.listOfUsers[j].getUsername())
                            {
                                comboBoxUser.SelectedItem = User.listOfUsers[j].getName();
                            }
                        }
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 1)
            {
                for (int i = 0; i < meetings.Count; i++)
                {
                    if (meetings[i].getName() == comboBoxName.Text.ToString())
                    {
                        richTextBox.Text = meetings[i].getComment();
                        dateTimePicker.Value = DateTime.Parse(meetings[i].getDueDate());

                        var username = meetings[i].getUser();

                        for (int j = 0; j < User.listOfUsers.Count; j++)
                        {
                            if (username == User.listOfUsers[j].getUsername())
                            {
                                comboBoxUser.SelectedItem = User.listOfUsers[j].getName();
                            }
                        }
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 2)
            {
                for (int i = 0; i < assignments.Count; i++)
                {
                    if (assignments[i].getName() == comboBoxName.Text.ToString())
                    {
                        richTextBox.Text = assignments[i].getComment();
                        dateTimePicker.Value = DateTime.Parse(assignments[i].getDueDate());

                        var username = assignments[i].getUser();

                        for (int j = 0; j < User.listOfUsers.Count; j++)
                        {
                            if (username == User.listOfUsers[j].getUsername())
                            {
                                comboBoxUser.SelectedItem = User.listOfUsers[j].getName();
                            }
                        }
                    }
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {   //Validation
            if (comboBoxName.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                //Removing items
                if (comboBoxType.SelectedIndex == 0)
                {
                    for (int i = 0; i < panels.Count; i++)
                    {
                        if (panels[i].getName() == comboBoxName.Text.ToString())
                        {
                            panels.RemoveAt(i);
                            comboBoxName.Items.Remove(comboBoxName.SelectedItem);
                            comboBoxName.Text = "";
                            comboBoxUser.Items.Remove(comboBoxUser.SelectedItem);
                            comboBoxUser.SelectedIndex = -1;
                            richTextBox.Clear();
                            dateTimePicker.Value = DateTime.Now;
                        }
                    }
                }

                if (comboBoxType.SelectedIndex == 1)
                {
                    for (int i = 0; i < meetings.Count; i++)
                    {
                        if (meetings[i].getName() == comboBoxName.Text.ToString())
                        {
                            meetings.RemoveAt(i);
                            comboBoxName.Items.Remove(comboBoxName.SelectedItem);
                            comboBoxName.Text = "";
                            comboBoxUser.Items.Remove(comboBoxUser.SelectedItem);
                            comboBoxUser.SelectedIndex = -1;
                            richTextBox.Clear();
                            dateTimePicker.Value = DateTime.Now;
                        }
                    }
                }

                if (comboBoxType.SelectedIndex == 2)
                {
                    for (int i = 0; i < assignments.Count; i++)
                    {
                        if (assignments[i].getName() == comboBoxName.Text.ToString())
                        {
                            assignments.RemoveAt(i);
                            comboBoxName.Items.Remove(comboBoxName.SelectedItem);
                            comboBoxName.Text = "";
                            comboBoxUser.Items.Remove(comboBoxUser.SelectedItem);
                            comboBoxUser.SelectedIndex = -1;
                            richTextBox.Clear();
                            dateTimePicker.Value = DateTime.Now;
                        }
                    }
                }

                //Rewrite file
                using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt"))
                {
                    for (int i = 0; i < panels.Count; i++)
                    {
                        writer.WriteLine(panels[i].getInfo());
                    }
                    for (int i = 0; i < meetings.Count; i++)
                    {
                        writer.WriteLine(meetings[i].getInfo());
                    }
                    for (int i = 0; i < assignments.Count; i++)
                    {
                        writer.WriteLine(assignments[i].getInfo());
                    }
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Validation
            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else if (comboBoxName.Text.ToString() == "")
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                //Add new items to the elements and write them to file
                var dueDate = dateTimePicker.Value.ToShortDateString();
                var setDate = DateTime.Now.ToShortDateString();

                if (comboBoxType.SelectedIndex == 0)
                {
                    var name = comboBoxUser.SelectedItem.ToString();
                    string username = "";

                    for (int i = 0; i < User.listOfUsers.Count; i++)
                    {
                        if (User.listOfUsers[i].getName() == name)
                        {
                            username = User.listOfUsers[i].getUsername();
                        }
                    }

                    if (richTextBox.TextLength == 0)
                    {
                        panels.Add(new AdminPanel(comboBoxName.Text.ToString(), username, dueDate, setDate, ""));
                    }
                    else
                    {
                        panels.Add(new AdminPanel(comboBoxName.Text.ToString(), username, dueDate, setDate, richTextBox.Text));
                    }

                    comboBoxName.Items.Add(comboBoxName.Text.ToString());
                    comboBoxName.Text = "";
                    comboBoxUser.SelectedIndex = -1;
                    richTextBox.Clear();
                    dateTimePicker.Value = DateTime.Now;
                    MessageBox.Show("Item has been added");

                    int index = panels.Count - 1;
                    using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt", true))
                    {
                        writer.WriteLine(panels[index].getInfo(), Environment.NewLine);
                    }

                }

                if (comboBoxType.SelectedIndex == 1)
                {
                    var name = comboBoxUser.SelectedItem.ToString();
                    string username = "";

                    for (int i = 0; i < User.listOfUsers.Count; i++)
                    {
                        if (User.listOfUsers[i].getName() == name)
                        {
                            username = User.listOfUsers[i].getUsername();
                        }
                    }

                    if (richTextBox.TextLength == 0)
                    {

                        meetings.Add(new AdminMeeting(comboBoxName.Text.ToString(), username, dueDate, setDate, ""));
                    }
                    else
                    {
                        meetings.Add(new AdminMeeting(comboBoxName.Text.ToString(), username, dueDate, setDate, richTextBox.Text));
                    }

                    comboBoxName.Items.Add(comboBoxName.Text.ToString());
                    comboBoxName.Text = "";
                    comboBoxUser.SelectedIndex = -1;
                    richTextBox.Clear();
                    dateTimePicker.Value = DateTime.Now;
                    MessageBox.Show("Item has been added");

                    int index = meetings.Count - 1;
                    using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt", true))
                    {
                        writer.WriteLine(meetings[index].getInfo(), Environment.NewLine);
                    }
                }

                if (comboBoxType.SelectedIndex == 2)
                {
                    var name = comboBoxUser.SelectedItem.ToString();
                    string username = "";

                    for (int i = 0; i < User.listOfUsers.Count; i++)
                    {
                        if (User.listOfUsers[i].getName() == name)
                        {
                            username = User.listOfUsers[i].getUsername();
                        }
                    }

                    if (richTextBox.TextLength == 0)
                    {
                        assignments.Add(new Assignment(comboBoxName.Text.ToString(), username, dueDate, setDate, ""));
                    }
                    else
                    {
                        assignments.Add(new Assignment(comboBoxName.Text.ToString(), username, dueDate, setDate, richTextBox.Text));
                    }
                    comboBoxName.Items.Add(comboBoxName.Text.ToString());
                    comboBoxName.Text = "";
                    comboBoxUser.SelectedIndex = -1;
                    richTextBox.Clear();
                    dateTimePicker.Value = DateTime.Now;
                    MessageBox.Show("Item has been added");

                    int index = assignments.Count - 1;
                    using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt", true))
                    {
                        writer.WriteLine(assignments[index].getInfo(), Environment.NewLine);
                    }
                }
            }
        }

        private void labelDueDate_Click(object sender, EventArgs e)
        {

        }
    }
}
