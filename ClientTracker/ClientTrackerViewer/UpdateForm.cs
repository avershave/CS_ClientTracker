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
    public partial class updateForm : Form
    {
        ClientModel passedClient;
        ClientSelected passedForm;
        public updateForm(ClientModel client, ClientSelected form)
        {
            passedClient = client;
            passedForm = form;
            InitializeComponent();
            updateFirstName.Text = client.firstName;
            updateLastName.Text = client.lastName;
            updatePhoneNumber.Text = client.phoneNumber;
            updateEmail.Text = client.email;
        }

        private void UpdateClientButton_Click(object sender, EventArgs e)
        {
            if(ClientAPI.updateClient(passedClient, updateFirstName.Text, updateLastName.Text, updatePhoneNumber.Text, updateEmail.Text))
            {
                MessageBox.Show("Client updated succesfully!");
                passedClient.firstName = updateFirstName.Text;
                passedClient.lastName = updateLastName.Text;
                passedClient.phoneNumber = updatePhoneNumber.Text;
                passedClient.email = updateEmail.Text;
                ClientSelected clientSelected = new ClientSelected(passedClient);
                clientSelected.Show();
                this.Close();
                
            } else
            {
                MessageBox.Show("Client not updated. Please check text field.");
            }
            

        }
    }
}
