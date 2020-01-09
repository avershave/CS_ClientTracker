namespace ClientTrackerViewer
{
    partial class ClientView
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.listClients = new System.Windows.Forms.ListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.apptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(38, 41);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(74, 28);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Clients:";
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.ItemHeight = 28;
            this.listClients.Location = new System.Drawing.Point(102, 133);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(631, 452);
            this.listClients.TabIndex = 1;
            this.listClients.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ListClients_Format);
            this.listClients.DoubleClick += new System.EventHandler(this.ListClients_DoubleClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(102, 607);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(92, 43);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(286, 607);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 42);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // apptButton
            // 
            this.apptButton.Location = new System.Drawing.Point(469, 607);
            this.apptButton.Name = "apptButton";
            this.apptButton.Size = new System.Drawing.Size(264, 42);
            this.apptButton.TabIndex = 4;
            this.apptButton.Text = "Schedule Appoinment";
            this.apptButton.UseVisualStyleBackColor = true;
            this.apptButton.Click += new System.EventHandler(this.ApptButton_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 699);
            this.Controls.Add(this.apptButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ClientView";
            this.Text = "View Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createButton;
        public System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button apptButton;
    }
}

