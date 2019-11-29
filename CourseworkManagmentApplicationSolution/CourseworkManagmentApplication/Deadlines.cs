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
        List<AdminPanel> panels = new List<AdminPanel>();
        List<AdminMeeting> meetings = new List<AdminMeeting>();
        List<Assignment> assignments = new List<Assignment>();

        public Deadlines()
        {
            InitializeComponent();
        }

        private void Deadlines_Load(object sender, EventArgs e)
        {
            //set initial date time picker value
            dateTimePicker.Value = dateTimePicker.MinDate;

            //Load and save deadlines
            string line;
            StreamReader reader = new StreamReader(@".\\deadlines.txt");

            while ((line = reader.ReadLine()) != null)
            {
                string[] bits = line.Split(',');

                if (bits[0] == comboBoxType.Items[0].ToString())
                {
                    if (bits.Length == 5)
                    {
                        panels.Add(new AdminPanel(bits[1], bits[2], bits[3], bits[4]));
                    }
                    else
                    {
                        panels.Add(new AdminPanel(bits[1], bits[2], bits[3], ""));
                    }
                }

                if (bits[0] == comboBoxType.Items[1].ToString())
                {
                    if (bits.Length == 5)
                    {
                        meetings.Add(new AdminMeeting(bits[1], bits[2], bits[3], bits[4]));
                    }
                    else
                    {
                        meetings.Add(new AdminMeeting(bits[1], bits[2], bits[3], ""));
                    }
                }

                if (bits[0] == comboBoxType.Items[2].ToString())
                {
                    if (bits.Length == 5)
                    {
                        assignments.Add(new Assignment(bits[1], bits[2], bits[3], bits[4]));
                    }
                    else
                    {
                        assignments.Add(new Assignment(bits[1], bits[2], bits[3], ""));
                    }
                }
            }
            reader.Close();

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear items and selection if selected item in combo box 1 changes
            richTextBox.Clear();
            dateTimePicker.Value = dateTimePicker.MinDate;
            comboBoxName.SelectedIndex = -1;
            comboBoxName.Items.Clear();

            //Change contents of the 2nd combo box depending on which item is selected in the first combobox
            if (comboBoxType.SelectedIndex == 0)
            {
                
                for (int i = 0; i < panels.Count; i++)
                {
                    comboBoxName.Items.Add(panels[i].getName());
                }
            }

            if (comboBoxType.SelectedIndex == 1)
            {
                
                for (int i = 0; i < meetings.Count; i++)
                {
                    comboBoxName.Items.Add(meetings[i].getName());
                }
            }

            if (comboBoxType.SelectedIndex == 2)
            {
                
                for (int i = 0; i < assignments.Count; i++)
                {
                    comboBoxName.Items.Add(assignments[i].getName());
                }
            }
        }

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
                        richTextBox.Clear();
                        dateTimePicker.Value = dateTimePicker.MinDate;
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
                        richTextBox.Clear();
                        dateTimePicker.Value = dateTimePicker.MinDate;
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
                        richTextBox.Clear();
                        dateTimePicker.Value = dateTimePicker.MinDate;
                    }
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter(@".\\deadlines.txt");

            //Validation
            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else if (comboBoxName.Text.ToString() == "")
            {
                MessageBox.Show("Please select an item");
            }

            var dueDate = dateTimePicker.Value.ToShortDateString();
            var setDate = DateTime.Now.ToShortDateString();

            if (comboBoxType.SelectedIndex == 0)
            {

                if (richTextBox.TextLength == 0)
                {
                    panels.Add(new AdminPanel(comboBoxName.Text.ToString(), dueDate, setDate, ""));
                }
                else
                {
                    panels.Add(new AdminPanel(comboBoxName.Text.ToString(), dueDate, setDate, richTextBox.Text));
                }
                comboBoxName.Items.Add(comboBoxName.Text.ToString());
                comboBoxName.Text = "";
                richTextBox.Clear();
                dateTimePicker.Value = dateTimePicker.MinDate;
                MessageBox.Show("Item has been added");
            }

            if (comboBoxType.SelectedIndex == 1)
            {
                if (richTextBox.TextLength == 0)
                {
                    meetings.Add(new AdminMeeting(comboBoxName.Text.ToString(), dueDate, setDate, ""));
                }
                else
                {
                    meetings.Add(new AdminMeeting(comboBoxName.Text.ToString(), dueDate, setDate, richTextBox.Text));
                }

                comboBoxName.Items.Add(comboBoxName.Text.ToString());
                comboBoxName.Text = "";
                richTextBox.Clear();
                dateTimePicker.Value = dateTimePicker.MinDate;
                MessageBox.Show("Item has been added");
            }

            if (comboBoxType.SelectedIndex == 2)
            {
                if (richTextBox.TextLength == 0)
                {
                    assignments.Add(new Assignment(comboBoxName.Text.ToString(), dueDate, setDate, ""));
                }
                else
                {
                    assignments.Add(new Assignment(comboBoxName.Text.ToString(), dueDate, setDate, richTextBox.Text));
                }
                comboBoxName.Items.Add(comboBoxName.Text.ToString());
                comboBoxName.Text = "";
                richTextBox.Clear();
                dateTimePicker.Value = dateTimePicker.MinDate;
                MessageBox.Show("Item has been added");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
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
        }
    }
}
