using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodealikeIMUpdater
{
    public partial class MainForm : Form
    {

        private static string[] hipChatStatus = new string[] { "Available", "Away", "DND" };
        private Timer updateTimer;
        private API.ICodealikeAPI codealikeApi;
        private API.CodealikeStatus previousCodealikeStatus;
        private API.IHipChatAPI hipChatApi;

        public MainForm()
        {
            InitializeComponent();

            this.codealikeApi = new API.Impl.CodealikeAPI();
            this.hipChatApi = new API.Impl.HipChatAPI();

            cbUnknown.Items.AddRange(hipChatStatus);
            cbCanInterrupt.Items.AddRange(hipChatStatus);
            cbCannotInterrupt.Items.AddRange(hipChatStatus);
            cbNoActivity.Items.AddRange(hipChatStatus);

            cbUpdateInterval.SelectedIndex = 0;

            cbUnknown.SelectedIndex = 0;
            cbCanInterrupt.SelectedIndex = 0;
            cbCannotInterrupt.SelectedIndex = 2;
            cbNoActivity.SelectedIndex = 0;

            txtCannotInterruptMsg.Text = "On fire!";
            txtCanInterruptMsg.Text = "Trying to focus";

            this.updateTimer = new Timer();
            updateTimer.Interval = int.Parse(cbUpdateInterval.Text) * 1000 * 60;
            this.updateTimer.Tick += updateTimer_Tick;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            var codealikeStatus = this.codealikeApi.GetUsersStatus(txtCodealikeUser.Text);

            if (codealikeStatus != previousCodealikeStatus)
            {
                var user = this.hipChatApi.GetUser(txtHipChatToken.Text, txtHipChatEmail.Text);

                user.presence = new API.Presence()
                {
                    show = MapHipChatStatus(codealikeStatus),
                    status = MapHipChatMessage(codealikeStatus)
                };
                string token = txtHipChatToken.Text;
                hipChatApi.UpdateUserStatus(token, user);

                previousCodealikeStatus = codealikeStatus;
            }
        }

        private string MapHipChatMessage(API.CodealikeStatus codealikeStatus)
        {
            switch (codealikeStatus)
            {
                case API.CodealikeStatus.NoActivity:
                    return txtNoActivityMsg.Text;
                case API.CodealikeStatus.CanInterrupt:
                    return txtCanInterruptMsg.Text;
                case API.CodealikeStatus.CannotInterrupt:
                    return txtCannotInterruptMsg.Text;
                case API.CodealikeStatus.Unknown:
                default:
                    return txtUnknownMsg.Text;
            }
        }

        private string MapHipChatStatus(API.CodealikeStatus codealikeStatus)
        {
            //away, available, dnd
            switch (codealikeStatus)
            {
                case API.CodealikeStatus.NoActivity:
                    return cbNoActivity.Text.ToLower();
                case API.CodealikeStatus.CanInterrupt:
                    return cbCanInterrupt.Text.ToLower();
                case API.CodealikeStatus.CannotInterrupt:
                    return cbCannotInterrupt.Text.ToLower();
                case API.CodealikeStatus.Unknown:
                default:
                    return cbUnknown.Text.ToLower();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateTimer_Tick(null, null);

            updateTimer.Interval = int.Parse(cbUpdateInterval.Text) * 1000 * 60;
            if (!updateTimer.Enabled)
            {
                updateTimer.Stop();
            }
            updateTimer.Start();

            MessageBox.Show("Updated Settings.", "CodealikeIM Updater", MessageBoxButtons.OK);
            //this.Hide();
        }

        private void btnTestCodealike_Click(object sender, EventArgs e)
        {
            string userName = txtCodealikeUser.Text;


            var status = codealikeApi.GetUsersStatus(userName);

            string message = string.Format("The current status for {0} is {1}", userName, status.ToString());
            MessageBox.Show(message, "Codealike Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTestHipChat_Click(object sender, EventArgs e)
        {
            string token = txtHipChatToken.Text;
            string email = txtHipChatEmail.Text;

            var user = hipChatApi.GetUser(token, email);

            var message = string.Format("{0} is currently set as {1} with the message '{2}'", user.name, user.presence.show, user.presence.status);
            MessageBox.Show(message, "HipChat Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
