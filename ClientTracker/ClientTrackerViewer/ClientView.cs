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
            listClients.DisplayMember = "lastName";
            foreach(var o in clientList)
            {
                listClients.Items.Add(o);
            }
        }

        private void ListClients_DoubleClick(object sender, EventArgs e)
        {
            ClientModel selectedObj = (ClientModel)listClients.SelectedItem;
            ClientSelected clientSelected = new ClientSelected();
            clientSelected.showInfo(selectedObj);
            clientSelected.Show();
        }
    }
}
