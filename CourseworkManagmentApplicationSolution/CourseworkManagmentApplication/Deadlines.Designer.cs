namespace CourseworkManagmentApplication
{
    partial class Deadlines
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.labelDeadlineType = new System.Windows.Forms.Label();
            this.labelDeadlineName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(35, 162);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(310, 197);
            this.richTextBox.TabIndex = 12;
            this.richTextBox.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(35, 378);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Value = new System.DateTime(2019, 11, 27, 0, 0, 0, 0);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(258, 416);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(87, 31);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Admin: Administer Panel",
            "Admin: Book Meeting Room",
            "Assignment"});
            this.comboBoxType.Location = new System.Drawing.Point(35, 32);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(310, 21);
            this.comboBoxType.TabIndex = 8;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(35, 72);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(310, 21);
            this.comboBoxName.TabIndex = 9;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(35, 416);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 31);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(35, 122);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(310, 21);
            this.comboBoxUser.TabIndex = 13;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(32, 362);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(53, 13);
            this.labelDueDate.TabIndex = 14;
            this.labelDueDate.Text = "Due Date";
            this.labelDueDate.Click += new System.EventHandler(this.labelDueDate_Click);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(32, 146);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(56, 13);
            this.labelComments.TabIndex = 15;
            this.labelComments.Text = "Comments";
            // 
            // labelRecipient
            // 
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Location = new System.Drawing.Point(32, 106);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(52, 13);
            this.labelRecipient.TabIndex = 16;
            this.labelRecipient.Text = "Recipient";
            // 
            // labelDeadlineType
            // 
            this.labelDeadlineType.AutoSize = true;
            this.labelDeadlineType.Location = new System.Drawing.Point(32, 16);
            this.labelDeadlineType.Name = "labelDeadlineType";
            this.labelDeadlineType.Size = new System.Drawing.Size(76, 13);
            this.labelDeadlineType.TabIndex = 17;
            this.labelDeadlineType.Text = "Deadline Type";
            // 
            // labelDeadlineName
            // 
            this.labelDeadlineName.AutoSize = true;
            this.labelDeadlineName.Location = new System.Drawing.Point(32, 56);
            this.labelDeadlineName.Name = "labelDeadlineName";
            this.labelDeadlineName.Size = new System.Drawing.Size(80, 13);
            this.labelDeadlineName.TabIndex = 18;
            this.labelDeadlineName.Text = "Deadline Name";
            // 
            // Deadlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 459);
            this.Controls.Add(this.labelDeadlineName);
            this.Controls.Add(this.labelDeadlineType);
            this.Controls.Add(this.labelRecipient);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.richTextBox);
            this.Name = "Deadlines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deadlines";
            this.Load += new System.EventHandler(this.Deadlines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.Label labelDeadlineType;
        private System.Windows.Forms.Label labelDeadlineName;
    }
}