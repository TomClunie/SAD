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
