namespace ClientTrackerViewer
{
    partial class updateForm
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
            this.updateFirstName = new System.Windows.Forms.TextBox();
            this.updateLastName = new System.Windows.Forms.TextBox();
            this.updatePhoneNumber = new System.Windows.Forms.TextBox();
            this.updateEmail = new System.Windows.Forms.TextBox();
            this.updateFirstNameLabel = new System.Windows.Forms.Label();
            this.updateLastNameLabel = new System.Windows.Forms.Label();
            this.updatePhoneNumberLabel = new System.Windows.Forms.Label();
            this.updateEmailLabel = new System.Windows.Forms.Label();
            this.updateClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateFirstName
            // 
            this.updateFirstName.Location = new System.Drawing.Point(81, 65);
            this.updateFirstName.Name = "updateFirstName";
            this.updateFirstName.Size = new System.Drawing.Size(202, 29);
            this.updateFirstName.TabIndex = 0;
            // 
            // updateLastName
            // 
            this.updateLastName.Location = new System.Drawing.Point(81, 148);
            this.updateLastName.Name = "updateLastName";
            this.updateLastName.Size = new System.Drawing.Size(202, 29);
            this.updateLastName.TabIndex = 1;
            // 
            // updatePhoneNumber
            // 
            this.updatePhoneNumber.Location = new System.Drawing.Point(81, 230);
            this.updatePhoneNumber.Name = "updatePhoneNumber";
            this.updatePhoneNumber.Size = new System.Drawing.Size(202, 29);
            this.updatePhoneNumber.TabIndex = 2;
            // 
            // updateEmail
            // 
            this.updateEmail.Location = new System.Drawing.Point(81, 312);
            this.updateEmail.Name = "updateEmail";
            this.updateEmail.Size = new System.Drawing.Size(202, 29);
            this.updateEmail.TabIndex = 3;
            // 
            // updateFirstNameLabel
            // 
            this.updateFirstNameLabel.AutoSize = true;
            this.updateFirstNameLabel.Location = new System.Drawing.Point(81, 34);
            this.updateFirstNameLabel.Name = "updateFirstNameLabel";
            this.updateFirstNameLabel.Size = new System.Drawing.Size(112, 25);
            this.updateFirstNameLabel.TabIndex = 4;
            this.updateFirstNameLabel.Text = "First Name:";
            // 
            // updateLastNameLabel
            // 
            this.updateLastNameLabel.AutoSize = true;
            this.updateLastNameLabel.Location = new System.Drawing.Point(81, 120);
            this.updateLastNameLabel.Name = "updateLastNameLabel";
            this.updateLastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.updateLastNameLabel.TabIndex = 5;
            this.updateLastNameLabel.Text = "Last Name:";
            // 
            // updatePhoneNumberLabel
            // 
            this.updatePhoneNumberLabel.AutoSize = true;
            this.updatePhoneNumberLabel.Location = new System.Drawing.Point(81, 202);
            this.updatePhoneNumberLabel.Name = "updatePhoneNumberLabel";
            this.updatePhoneNumberLabel.Size = new System.Drawing.Size(143, 25);
            this.updatePhoneNumberLabel.TabIndex = 6;
            this.updatePhoneNumberLabel.Text = "Phone Number";
            // 
            // updateEmailLabel
            // 
            this.updateEmailLabel.AutoSize = true;
            this.updateEmailLabel.Location = new System.Drawing.Point(81, 284);
            this.updateEmailLabel.Name = "updateEmailLabel";
            this.updateEmailLabel.Size = new System.Drawing.Size(66, 25);
            this.updateEmailLabel.TabIndex = 7;
            this.updateEmailLabel.Text = "Email:";
            // 
            // updateClientButton
            // 
            this.updateClientButton.Location = new System.Drawing.Point(111, 347);
            this.updateClientButton.Name = "updateClientButton";
            this.updateClientButton.Size = new System.Drawing.Size(139, 49);
            this.updateClientButton.TabIndex = 8;
            this.updateClientButton.Text = "Update";
            this.updateClientButton.UseVisualStyleBackColor = true;
            this.updateClientButton.Click += new System.EventHandler(this.UpdateClientButton_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 435);
            this.Controls.Add(this.updateClientButton);
            this.Controls.Add(this.updateEmailLabel);
            this.Controls.Add(this.updatePhoneNumberLabel);
            this.Controls.Add(this.updateLastNameLabel);
            this.Controls.Add(this.updateFirstNameLabel);
            this.Controls.Add(this.updateEmail);
            this.Controls.Add(this.updatePhoneNumber);
            this.Controls.Add(this.updateLastName);
            this.Controls.Add(this.updateFirstName);
            this.Name = "updateForm";
            this.Text = "Update Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox updateFirstName;
        private System.Windows.Forms.TextBox updateLastName;
        private System.Windows.Forms.TextBox updatePhoneNumber;
        private System.Windows.Forms.TextBox updateEmail;
        private System.Windows.Forms.Label updateFirstNameLabel;
        private System.Windows.Forms.Label updateLastNameLabel;
        private System.Windows.Forms.Label updatePhoneNumberLabel;
        private System.Windows.Forms.Label updateEmailLabel;
        private System.Windows.Forms.Button updateClientButton;
    }
}