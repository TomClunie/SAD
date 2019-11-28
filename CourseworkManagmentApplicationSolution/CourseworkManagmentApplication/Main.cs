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

        // Allowing the assign moderator button visibility property to be changed on another form.
        public void setAMButtonVisible(Boolean flag)
        {
            this.buttonAssignModerator.Visible = flag;
        }
        // Allowing the update scrutiny button visibility property to be changed on another form.
        public void setUSButtonVisible(Boolean flag)
        {
            this.buttonUpdateScrutinyForm.Visible = flag;
        }
        // Allowing the update modify assessment button visibility property to be changed on another form.
        public void setMAButtonVisible(Boolean flag)
        {
            this.buttonModifyAssessment.Visible = flag;
        }
        // Allowing the view assessment strategy button visibility property to be changed on another form.
        public void setVASButtonVisible(Boolean flag)
        {
            this.buttonViewAssessmentStrategy.Visible = flag;
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
            
        }
    }
}
