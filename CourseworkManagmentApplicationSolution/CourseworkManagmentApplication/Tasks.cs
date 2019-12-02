﻿using System;
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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }
        string currentUser = Form1.cUser;

        private void Tasks_Load(object sender, EventArgs e)
        {
            string line;
            textBox1.Text = currentUser;
            StreamReader reader = new StreamReader(@".\\deadlines.txt");

            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(currentUser))
                {
                    listBox1.Items.Add(line);
                }
                else
                {
                    listBox1.Items.Remove(line);
                }
            }

        }
    }
}
