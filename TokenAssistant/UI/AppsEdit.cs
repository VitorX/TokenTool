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
using TokenAssistant.Data.DataLayer;
using TokenAssistant.DataService;

namespace TokenAssistant
{
    public partial class AppsEdit : Form
    {

        TokenAssistantServiceClient dataService = new TokenAssistantServiceClient();

        public AppsEdit()
        {
            InitializeComponent();
        }

        public AppsEdit(string clientId)
        {
            InitializeComponent();

            AzureApp app = dataService.GetApp(clientId);
            comboType.DataSource = Enum.GetValues(typeof(AzureAppType)).Cast<AzureAppType>();

            txtAppName.Text = app.AppName;
            txtClientId.Text = app.ClientId;
            txtRedirectURL.Text = app.RedirectURL;

            if (app.Type == AzureAppType.client)
            {
                lblSecret.Visible = false;
                txtSecret.Visible = false;
                comboType.SelectedItem = AzureAppType.client;
            }
            else
            {
                comboType.SelectedItem = AzureAppType.Server;
                txtSecret.Text = ((ServerAzureApp)app).Secret;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AzureApp app;
            if (((AzureAppType)comboType.SelectedItem) == AzureAppType.Server)
            {
                app = new ServerAzureApp();
                ((ServerAzureApp)app).Secret = txtSecret.Text;

            }
            else
            {
                app = new ClientAzureApp();
                
            }
            app.ClientId = txtClientId.Text;
            app.AppName = txtAppName.Text;
            app.RedirectURL = txtRedirectURL.Text;
            dataService.SaveApp(app);

            MessageBox.Show("Modify Successfuly!");

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
