namespace ClientTrackerViewer
{
    partial class AppointmentForm
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
            this.apptCalendar = new System.Windows.Forms.MonthCalendar();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.scheduleApptBtn = new System.Windows.Forms.Button();
            this.apptText = new System.Windows.Forms.TextBox();
            this.apptCreated = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // apptCalendar
            // 
            this.apptCalendar.Location = new System.Drawing.Point(18, 18);
            this.apptCalendar.Name = "apptCalendar";
            this.apptCalendar.TabIndex = 1;
            this.apptCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.ApptCalendar_DateSelected);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(18, 192);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(82, 20);
            this.timePicker.TabIndex = 4;
            this.timePicker.Value = new System.DateTime(2020, 1, 8, 12, 0, 0, 0);
            // 
            // scheduleApptBtn
            // 
            this.scheduleApptBtn.Location = new System.Drawing.Point(18, 231);
            this.scheduleApptBtn.Name = "scheduleApptBtn";
            this.scheduleApptBtn.Size = new System.Drawing.Size(75, 23);
            this.scheduleApptBtn.TabIndex = 5;
            this.scheduleApptBtn.Text = "Schedule";
            this.scheduleApptBtn.UseVisualStyleBackColor = true;
            this.scheduleApptBtn.Click += new System.EventHandler(this.ScheduleApptBtn_Click);
            // 
            // apptText
            // 
            this.apptText.Location = new System.Drawing.Point(107, 192);
            this.apptText.Multiline = true;
            this.apptText.Name = "apptText";
            this.apptText.Size = new System.Drawing.Size(138, 62);
            this.apptText.TabIndex = 6;
            // 
            // apptCreated
            // 
            this.apptCreated.FormattingEnabled = true;
            this.apptCreated.Location = new System.Drawing.Point(257, 20);
            this.apptCreated.Name = "apptCreated";
            this.apptCreated.Size = new System.Drawing.Size(230, 160);
            this.apptCreated.TabIndex = 7;
            this.apptCreated.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ApptCreated_MouseClick);
            this.apptCreated.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ApptCreated_Format);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 288);
            this.Controls.Add(this.apptCreated);
            this.Controls.Add(this.apptText);
            this.Controls.Add(this.scheduleApptBtn);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.apptCalendar);
            this.Name = "AppointmentForm";
            this.Text = "Appointment Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar apptCalendar;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button scheduleApptBtn;
        private System.Windows.Forms.TextBox apptText;
        private System.Windows.Forms.ListBox apptCreated;
    }
}