using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace ClientTrackerViewer
{
    public partial class AppointmentForm : Form
    {
        ClientModel c;
        public AppointmentForm(ClientModel client)
        {
            c = client;
            InitializeComponent();
        }

        private void ScheduleApptBtn_Click(object sender, EventArgs e)
        {
            if(c.appointment != null)
            {
                var warningBox = MessageBox.Show("Client already has an appoinment! Did you want to overwrite?", "Appointment Warning", MessageBoxButtons.YesNo);
                if(warningBox == DialogResult.Yes)
                {
                    bool msg = ClientAPI.updateAppointment(c, apptCalendar.SelectionStart.Date, timePicker.Value, apptText.Text);

                    if (msg)
                    {
                        MessageBox.Show("Success!", "Added Appointment", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Did not create appointment. Please try again.", "ERROR", MessageBoxButtons.OK);
                    }
                } else if(warningBox == DialogResult.No)
                {
                    this.Close();
                }
            } else
            {
                bool msg = ClientAPI.updateAppointment(c, apptCalendar.SelectionStart.Date, timePicker.Value, apptText.Text);

                if (msg)
                {
                    MessageBox.Show("Success!", "Added Appointment", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Try again idiot!");
                }
            }
        }

        private void ApptCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            apptCreated.Items.Clear();
            List<ClientModel> clientList = ClientAPI.getClients();
            foreach(var c in clientList)
            {
                if (c.appointment != null)
                {
                    if (c.appointment.date.Date == apptCalendar.SelectionStart.Date)
                    {
                        apptCreated.Items.Add(c);
                    }
                }
            }
        }

        private void ApptCreated_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastName = ((ClientModel)e.ListItem).lastName;
            string firstName = ((ClientModel)e.ListItem).firstName;
            string date = ((ClientModel)e.ListItem).appointment.date.ToString("dd MMMM yyyy hh:mm tt");
            e.Value = lastName + ", " + firstName + ": " + date;
        }

        private void ApptCreated_MouseClick(object sender, MouseEventArgs e)
        {
            ClientModel selectedAppt = (ClientModel)apptCreated.SelectedItem;
            apptText.Text = selectedAppt.appointment.description;
            timePicker.Value = selectedAppt.appointment.date;
        }
    }
}
