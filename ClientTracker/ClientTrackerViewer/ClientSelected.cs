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
    public partial class ClientSelected : Form
    {
        ClientModel selectedClient;
        public ClientSelected(ClientModel client)
        {
            selectedClient = client;
            InitializeComponent();
            clientInfo.Items.Add("First Name: " + client.firstName);
            clientInfo.Items.Add("Last Name: " + client.lastName);
            clientInfo.Items.Add("Email: " + client.email);
            clientInfo.Items.Add("Phone Number: " + client.phoneNumber);
            if (client.appointment != null)
            {
                clientInfo.Items.Add("Appointment: " + client.appointment.date);
                clientInfo.Items.Add("Description: " + client.appointment.description);
            }
        }

        public ListBox clientInfoBox { get; set; }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            updateForm u = new updateForm(selectedClient, this);
            u.Show();
            this.Close();
        }
    }
}
