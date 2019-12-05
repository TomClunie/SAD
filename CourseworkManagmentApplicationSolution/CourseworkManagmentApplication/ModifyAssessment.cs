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
    public partial class ModifyAssessment : Form
    {
        public ModifyAssessment()
        {
            InitializeComponent();

            for (int i = 0; i < DeadlineClasses.assignments.Count; i++)
            {
                comboBoxName.Items.Add(DeadlineClasses.assignments[i].getName());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Writing changes to the assignment 1 file
            if (comboBoxName.SelectedItem.ToString() == "Assignment 1")
            {
                using (StreamWriter sw = new StreamWriter("Assignment 1.txt"))
                {
                    sw.WriteLine(richTextBox1.Text);
                }
            }
            // Writing changes to the assignment 2 file
            else if (comboBoxName.SelectedItem.ToString() == "Assignment 2")
            {
                using (StreamWriter sw1 = new StreamWriter("Assignment 2.txt"))
                {
                    sw1.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Takes you to the webpage where you can upload the modified assessment, in this case we have used the canvas website as a placeholder URL
            System.Diagnostics.Process.Start("https://canvas.hull.ac.uk/");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem.ToString() == "Assignment 1")
            {
                // This displays the fist line of Assignment 1
                StreamReader sr = new StreamReader("Assignment 1.txt");
                richTextBox1.Text = sr.ReadToEnd();

                sr.Close();
            }

            else if (comboBoxName.SelectedItem.ToString() == "Assignment 2")
            {
                // This doesnt work
                StreamReader sr1 = new StreamReader("Assignment 2.txt");
                string line = null;
                while ((line = sr1.ReadLine()) != null)
                {
                    richTextBox1.Text = sr1.ReadToEnd();
                }

                sr1.Close();
            }
        }
    }
}
