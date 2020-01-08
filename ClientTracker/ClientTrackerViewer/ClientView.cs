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
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
            List<ClientModel> clientList = ClientAPI.getClients();
            foreach(var o in clientList)
            {
                listClients.Items.Add(o);
            }
        }

        public ListBox clientListBox { get; set; }

        private void ListClients_DoubleClick(object sender, EventArgs e)
        {
            ClientModel selectedObj = (ClientModel)listClients.SelectedItem;
            ClientSelected clientSelected = new ClientSelected(selectedObj);
            clientSelected.Show();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateClientForm createClient = new CreateClientForm(this);
            createClient.Show();
                
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ClientModel selectedObj = (ClientModel)listClients.SelectedItem;
            ClientAPI.deleteClient(selectedObj);
            listClients.Items.Remove(listClients.SelectedItem);
        }

        private void ListClients_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastName = ((ClientModel)e.ListItem).lastName;
            string firstName = ((ClientModel)e.ListItem).firstName;
            e.Value = lastName + ", " + firstName;
        }
    }
}
