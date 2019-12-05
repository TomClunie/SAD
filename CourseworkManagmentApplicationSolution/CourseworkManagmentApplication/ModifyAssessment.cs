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
            // Opening a file from the machine in use and loading contents into the textbox
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string s = File.ReadAllText(ofd.FileName);
                textBox1.Text = s;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Takes you to the webpage where you can upload the modified assessment, in this case we have used the canvas website as a placeholder URL
            System.Diagnostics.Process.Start("https://canvas.hull.ac.uk/");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
