namespace CourseworkManagmentApplication
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDeadlines = new System.Windows.Forms.Button();
            this.buttonAssignModerator = new System.Windows.Forms.Button();
            this.buttonViewAssessmentStrategy = new System.Windows.Forms.Button();
            this.buttonUpdateScrutinyForm = new System.Windows.Forms.Button();
            this.buttonTasks = new System.Windows.Forms.Button();
            this.buttonModifyAssessment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeadlines
            // 
            this.buttonDeadlines.Location = new System.Drawing.Point(17, 38);
            this.buttonDeadlines.Name = "buttonDeadlines";
            this.buttonDeadlines.Size = new System.Drawing.Size(171, 124);
            this.buttonDeadlines.TabIndex = 0;
            this.buttonDeadlines.Text = "Deadlines";
            this.buttonDeadlines.UseVisualStyleBackColor = true;
            this.buttonDeadlines.Click += new System.EventHandler(this.buttonDeadlines_Click);
            // 
            // buttonAssignModerator
            // 
            this.buttonAssignModerator.Location = new System.Drawing.Point(206, 38);
            this.buttonAssignModerator.Name = "buttonAssignModerator";
            this.buttonAssignModerator.Size = new System.Drawing.Size(171, 124);
            this.buttonAssignModerator.TabIndex = 1;
            this.buttonAssignModerator.Text = "Assign Moderators";
            this.buttonAssignModerator.UseVisualStyleBackColor = true;
            this.buttonAssignModerator.Click += new System.EventHandler(this.buttonAssignModerator_Click);
            // 
            // buttonViewAssessmentStrategy
            // 
            this.buttonViewAssessmentStrategy.Location = new System.Drawing.Point(206, 325);
            this.buttonViewAssessmentStrategy.Name = "buttonViewAssessmentStrategy";
            this.buttonViewAssessmentStrategy.Size = new System.Drawing.Size(171, 124);
            this.buttonViewAssessmentStrategy.TabIndex = 2;
            this.buttonViewAssessmentStrategy.Text = "View Assessment Strategy";
            this.buttonViewAssessmentStrategy.UseVisualStyleBackColor = true;
            this.buttonViewAssessmentStrategy.Click += new System.EventHandler(this.buttonViewAssessmentStrategy_Click);
            // 
            // buttonUpdateScrutinyForm
            // 
            this.buttonUpdateScrutinyForm.Location = new System.Drawing.Point(17, 325);
            this.buttonUpdateScrutinyForm.Name = "buttonUpdateScrutinyForm";
            this.buttonUpdateScrutinyForm.Size = new System.Drawing.Size(171, 124);
            this.buttonUpdateScrutinyForm.TabIndex = 5;
            this.buttonUpdateScrutinyForm.Text = "Update Scrutiny Form";
            this.buttonUpdateScrutinyForm.UseVisualStyleBackColor = true;
            this.buttonUpdateScrutinyForm.Click += new System.EventHandler(this.buttonUpdateScrutinyForm_Click);
            // 
            // buttonTasks
            // 
            this.buttonTasks.Location = new System.Drawing.Point(206, 180);
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Size = new System.Drawing.Size(171, 124);
            this.buttonTasks.TabIndex = 4;
            this.buttonTasks.Text = "Tasks";
            this.buttonTasks.UseVisualStyleBackColor = true;
            this.buttonTasks.Click += new System.EventHandler(this.buttonTasks_Click);
            // 
            // buttonModifyAssessment
            // 
            this.buttonModifyAssessment.Location = new System.Drawing.Point(17, 180);
            this.buttonModifyAssessment.Name = "buttonModifyAssessment";
            this.buttonModifyAssessment.Size = new System.Drawing.Size(171, 124);
            this.buttonModifyAssessment.TabIndex = 3;
            this.buttonModifyAssessment.Text = "Modify Assessment";
            this.buttonModifyAssessment.UseVisualStyleBackColor = true;
            this.buttonModifyAssessment.Click += new System.EventHandler(this.buttonModifyAssessment_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 495);
            this.Controls.Add(this.buttonUpdateScrutinyForm);
            this.Controls.Add(this.buttonTasks);
            this.Controls.Add(this.buttonModifyAssessment);
            this.Controls.Add(this.buttonViewAssessmentStrategy);
            this.Controls.Add(this.buttonAssignModerator);
            this.Controls.Add(this.buttonDeadlines);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeadlines;
        private System.Windows.Forms.Button buttonAssignModerator;
        private System.Windows.Forms.Button buttonViewAssessmentStrategy;
        private System.Windows.Forms.Button buttonUpdateScrutinyForm;
        private System.Windows.Forms.Button buttonTasks;
        private System.Windows.Forms.Button buttonModifyAssessment;
    }
}