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
        public ClientSelected()
        {
            InitializeComponent();
        }

        public void showInfo(ClientModel client)
        {
            clientInfo.Items.Add(client.firstName);
            clientInfo.Items.Add(client.lastName);
            clientInfo.Items.Add(client.email);
            clientInfo.Items.Add(client.phoneNumber);
        }
    }
}
