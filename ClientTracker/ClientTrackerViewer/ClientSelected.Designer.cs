namespace ClientTrackerViewer
{
    partial class ClientSelected
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
            this.clientSelectedLabel = new System.Windows.Forms.Label();
            this.clientInfo = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientSelectedLabel
            // 
            this.clientSelectedLabel.AutoSize = true;
            this.clientSelectedLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSelectedLabel.Location = new System.Drawing.Point(37, 45);
            this.clientSelectedLabel.Name = "clientSelectedLabel";
            this.clientSelectedLabel.Size = new System.Drawing.Size(187, 47);
            this.clientSelectedLabel.TabIndex = 0;
            this.clientSelectedLabel.Text = "Client Info:";
            // 
            // clientInfo
            // 
            this.clientInfo.FormattingEnabled = true;
            this.clientInfo.ItemHeight = 24;
            this.clientInfo.Location = new System.Drawing.Point(45, 102);
            this.clientInfo.Name = "clientInfo";
            this.clientInfo.Size = new System.Drawing.Size(711, 292);
            this.clientInfo.TabIndex = 3;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(45, 400);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(164, 56);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Info";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClientSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.clientInfo);
            this.Controls.Add(this.clientSelectedLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Name = "ClientSelected";
            this.Text = "Client Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientSelectedLabel;
        private System.Windows.Forms.ListBox clientInfo;
        private System.Windows.Forms.Button updateButton;
    }
}