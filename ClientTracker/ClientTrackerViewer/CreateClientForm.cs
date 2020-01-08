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
    public partial class CreateClientForm : Form
    {
        ClientView originalForm;
        public CreateClientForm(ClientView incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var msg = ClientAPI.postClient(firstNameBox.Text, lastNameBox.Text, phoneNumberBox.Text.ToString(), emailBox.Text);

            if (!msg.msgError)
            {
                MessageBox.Show("Created client succesfully!");
                originalForm.listClients.Items.Clear();
                List<ClientModel> clientList = ClientAPI.getClients();
                originalForm.listClients.DisplayMember = "lastName";
                foreach (var o in clientList)
                {
                    originalForm.listClients.Items.Add(o);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Client not created...");
                this.Close();
            }
        }
    }
}
