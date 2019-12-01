using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkManagmentApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonDeadlines_Click(object sender, EventArgs e)
        {
            Deadlines deadlines = new Deadlines();
            deadlines.Show();
        }

        private void buttonAssignModerator_Click(object sender, EventArgs e)
        {

            AssignModerator assignModerator = new AssignModerator();
            assignModerator.Show();
        }

        private void buttonModifyAssessment_Click(object sender, EventArgs e)
        {
            ModifyAssessment modifyAssessment = new ModifyAssessment();
            modifyAssessment.Show();
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
           
        }

        private void buttonUpdateScrutinyForm_Click(object sender, EventArgs e)
        {
            UpdateScrutiny updateScrutiny = new UpdateScrutiny();
            updateScrutiny.Show();
        }

        private void buttonViewAssessmentStrategy_Click(object sender, EventArgs e)
        {
            //Takes you to the webpage where you can view the assessment strategy, in this case we have used the canvas website as a placeholder URL
            System.Diagnostics.Process.Start("https://canvas.hull.ac.uk/");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
