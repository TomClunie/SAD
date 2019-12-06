namespace CourseworkManagmentApplication
{
    partial class UpdateScrutiny
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
            this.comboBoxAssignment = new System.Windows.Forms.ComboBox();
            this.checkedListBoxModerator = new System.Windows.Forms.CheckedListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAssignment
            // 
            this.comboBoxAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAssignment.FormattingEnabled = true;
            this.comboBoxAssignment.Location = new System.Drawing.Point(12, 31);
            this.comboBoxAssignment.Name = "comboBoxAssignment";
            this.comboBoxAssignment.Size = new System.Drawing.Size(177, 21);
            this.comboBoxAssignment.TabIndex = 3;
            // 
            // checkedListBoxModerator
            // 
            this.checkedListBoxModerator.FormattingEnabled = true;
            this.checkedListBoxModerator.Location = new System.Drawing.Point(12, 73);
            this.checkedListBoxModerator.Name = "checkedListBoxModerator";
            this.checkedListBoxModerator.Size = new System.Drawing.Size(777, 364);
            this.checkedListBoxModerator.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(714, 472);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UpdateScrutiny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 507);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkedListBoxModerator);
            this.Controls.Add(this.comboBoxAssignment);
            this.Name = "UpdateScrutiny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateScrutiny";
            this.Load += new System.EventHandler(this.UpdateScrutiny_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAssignment;
        private System.Windows.Forms.CheckedListBox checkedListBoxModerator;
        private System.Windows.Forms.Button buttonSave;
    }
}