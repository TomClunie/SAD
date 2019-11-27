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
            //Display first item in combo box
            //comboBoxType.SelectedIndex = comboBoxType.Items.Count - 1;

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
            comboBoxName.Items.Clear();
            if (comboBoxType.SelectedIndex == 0)
            {
                
                for (int i = 0; i < panels.Count; i++)
                {
                    comboBoxName.Items.Add(panels[i].getName());
                }
            }

            if (comboBoxType.SelectedIndex == 1)
            {
                
                for (int i = 0; i < panels.Count; i++)
                {
                    comboBoxName.Items.Add(meetings[i].getName());
                }
            }

            if (comboBoxType.SelectedIndex == 2)
            {
                
                for (int i = 0; i < panels.Count; i++)
                {
                    comboBoxName.Items.Add(assignments[i].getName());
                }
            }
        }
    }
}
