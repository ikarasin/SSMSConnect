using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSMSConnect
{
    public partial class SettingsDialog : Form
    {
        public Settings settings;

        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void SettingsDialog_Shown(object sender, EventArgs e)
        {
            checkBoxConnectAtStartup.Checked = settings.connectAtStartup;

            foreach(ServerSettings server in settings.servers) 
            {
                object[] newRow = new object[] { server.serverPath, server.serverDescription, server.userDomain, server.serverIsEnabled };
                dataGridViewServers.Rows.Add(newRow);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings = new Settings();
            settings.connectAtStartup = checkBoxConnectAtStartup.Checked;

            foreach(DataGridViewRow row in dataGridViewServers.Rows)
            {
                settings.servers.Add(new ServerSettings { serverPath = (string)row.Cells[0].Value, serverDescription = (string)row.Cells[1].Value, userDomain = (string)row.Cells[2].Value, serverIsEnabled = (bool)row.Cells[3].Value });
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
