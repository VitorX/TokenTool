using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokenAssistant.Data;

namespace TokenAssistant
{
    public partial class AppsAdd : Form
    {
        public AppsAdd()
        {
            InitializeComponent();

            comboType.DataSource = Enum.GetValues(typeof(AzureAppType)).Cast<AzureAppType>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AzureApp app;
            if (((AzureAppType)comboType.SelectedItem) == AzureAppType.Server)
            {
                app = new ServerAzureApp
                {
                    AppName = textAppName.Text,
                    ClientId = txtClientId.Text,
                    RedirectURL = txtRedirectURL.Text,
                    Secret = txtSecret.Text
                };
            }
            else
            {
                app = new ClientAzureApp
                {
                    AppName = textAppName.Text,
                    ClientId = txtClientId.Text,
                    RedirectURL = txtRedirectURL.Text,
                };
            }


            AzureAppDbFactory.GetDbContext().AddApp(app);

            MessageBox.Show("Add successfully!");

            this.Close();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((AzureAppType)((ComboBox)sender).SelectedItem) == AzureAppType.Server)
            {
                lblSecret.Visible = true;
                txtSecret.Visible = true;
            }
            else
            {
                lblSecret.Visible = false;
                txtSecret.Visible = false;
            }
        }
    }
}
