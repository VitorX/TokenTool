using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OAuth2;
using Newtonsoft.Json.Linq;
using TokenAssistant.BusniessLayer;
using TokenAssistant.Data;
using TokenAssistant.DataService;

namespace TokenAssistant
{
    public partial class Main : Form
    {
        AzureAppServiceClient dataService=new AzureAppServiceClient();

        public Main()
        {
            InitializeComponent();

            BindListApps();

            lstResrouce.DataSource = Resources.Resrouces;
            lstUsers.DataSource = Users.UserNames;

            RefreshTokenControlUI();
        }

        private static AzureAppServiceClient getDbContext()
        {
            return new AzureAppServiceClient();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string clientId = ((AzureApp)listApps.SelectedItem).ClientId;
            dataService.DeleteApp(clientId);
            RefreshListApps();
            MessageBox.Show("Delete app sucessfully!");
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshListApps();
        }

        private void RefreshListApps()
        {
            dataService =getDbContext();
            BindListApps();
        }

        private void BindListApps()
        {
            listApps.DataSource = dataService.GetAllApps();
            listApps.DisplayMember = "AppName";
            listApps.ValueMember = "ClientId";
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AppsAdd formAdd = new AppsAdd();
            ShowFormBeside(this, formAdd);
            RefreshListApps();
        }

        private void btnModifyApp_Click(object sender, EventArgs e)
        {
            string clientId = ((AzureApp)listApps.SelectedItem).ClientId;
            AppsEdit formEdit = new AppsEdit(clientId);
            ShowFormBeside(this, formEdit);

        }

        private void btnDelegateToken_Click(object sender, EventArgs e)
        {
            string clientId = ((AzureApp)listApps.SelectedItem).ClientId;
            AzureApp app = dataService.GetApp(clientId);
            TokenRequest tokenRequest = new TokenRequest(app, lstResrouce.Text, lstUsers.Text);
            TokenRequestHelp tokenRequestHelp = new TokenRequestHelp(tokenRequest);
            tokenRequestHelp.Send("https://login.microsoftonline.com");

            dataService.SaveApp(app);

            RefreshTokenControlUI();
            MessageBox.Show(tokenRequest.AccessToken);

        }

        private void RefreshTokenControlUI()
        {
            try
            {
                dataService =getDbContext();
                var appId = ((AzureApp)listApps.SelectedItem).ClientId;
                var app = dataService.GetApp(appId);

                var tokenRequestIndex = app.tokenRequests.FindIndex(tokekRequest => (tokekRequest.Resource == lstResrouce.Text && tokekRequest.SignInUserName == lstUsers.Text));
                if (tokenRequestIndex != -1)
                {
                    txtAccessToken.Text = app.tokenRequests[tokenRequestIndex].AccessToken;
                    txtRefreshToken.Text = app.tokenRequests[tokenRequestIndex].RefreshToken;
                }
                else
                {
                    txtAccessToken.Text = "";
                    txtRefreshToken.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void btnAppToken_Click(object sender, EventArgs e)
        {
            var appId = ((AzureApp)listApps.SelectedItem).ClientId;
            var app = dataService.GetApp(appId);
            var authority = "https://login.microsoftonline.com/o365e3w15.onmicrosoft.com/oauth2/token";
            var secret = "";
            if (app.Type == AzureAppType.Server)
                secret = ((ServerAzureApp)app).Secret;
            var appToken = await new TokenHelper(authority).AcquireTokenAsync(app.ClientId, secret, lstResrouce.Text);
            MessageBox.Show(appToken);
            Clipboard.SetText(appToken);
        }

        private void btnRenewToken_Click(object sender, EventArgs e)
        {
            var appId = ((AzureApp)listApps.SelectedItem).ClientId;
            var app = dataService.GetApp(appId);

            TokenHelper tokenHelper = new TokenHelper("https://login.microsoftonline.com/Common/oauth2/token");
            JObject response = null;
            if (!String.IsNullOrEmpty(txtRefreshToken.Text))
                response = tokenHelper.RefreshToken(app.ClientId, ((ServerAzureApp)app).Secret, lstResrouce.Text, txtRefreshToken.Text);
            else
            {

                var tokenRequest = app.tokenRequests.FindLast(request => !String.IsNullOrEmpty(request.RefreshToken));
                if (tokenRequest != null)
                {
                    response = tokenHelper.RefreshToken(app.ClientId, ((ServerAzureApp)app).Secret, lstResrouce.Text, tokenRequest.RefreshToken);
                }
            }

            if (response != null)
            {
                var accessToken = response["access_token"].ToString();
                var newRefreshToken = response["refresh_token"].ToString();

                var targetTokenRequest = app.tokenRequests.FirstOrDefault(tokekRequest => (tokekRequest.Resource == lstResrouce.Text && tokekRequest.SignInUserName == lstUsers.Text));
                if (targetTokenRequest !=null)
                {
                    targetTokenRequest.AccessToken = accessToken;
                    targetTokenRequest.RefreshToken = newRefreshToken;
                }
                else
                {
                    var tokenRequest = new TokenRequest(app, lstResrouce.Text, lstUsers.Text);
                    tokenRequest.AccessToken = accessToken;
                    tokenRequest.RefreshToken = newRefreshToken;
                    app.tokenRequests.Add(tokenRequest);
                }

                dataService.SaveApp(app);
                RefreshTokenControlUI();
            }
            else
            {
                MessageBox.Show("Not able to find the RefreshToken!");
            }

        }

        private void ShowFormBeside(Form parent, Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Left = parent.Right;
            form.Top = parent.Top;
            form.ShowDialog();
        }

        private void lstUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
                Clipboard.SetText(((ListBox)sender).Text);
        }

        private void lstResrouce_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTokenControlUI();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTokenControlUI();
        }

        private void listApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTokenControlUI();
        }

        private void txtAccessToken_Click(object sender, EventArgs e)
        {
            SetTextFromTextBox(sender);
        }

        private void txtRefreshToken_Click(object sender, EventArgs e)
        {
            SetTextFromTextBox(sender);
        }

        private void txtAccessToken_Enter(object sender, EventArgs e)
        {
            SetTextFromTextBox(sender);
        }

        private void txtRefreshToken_Enter(object sender, EventArgs e)
        {
            SetTextFromTextBox(sender);
        }

        private static void SetTextFromTextBox(object sender)
        {
            TextBox textbox = (TextBox)sender;
            textbox.SelectAll();
            if (!String.IsNullOrEmpty(textbox.Text))
                Clipboard.SetText(textbox.Text);
        }


    }
}
