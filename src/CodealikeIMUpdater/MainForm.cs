using CodealikeIMUpdater.MVP;
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
    public partial class MainForm : Form, IMainView
    {
        public event Action<string> TestCodealike;
        public event Action<string, string> TestHipChat;
        public event Action<IMUpdaterSettings> Save;
        public event Action<int> SetUpdateInterval;


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
            if (this.Save != null)
            {
                IMUpdaterSettings settings = new IMUpdaterSettings()
                {
                    CodealikeUsername = txtCodealikeUser.Text,
                    HipChatToken = txtHipChatToken.Text,
                    HipChatEmail = txtHipChatEmail.Text,
                    UpdateInterval = int.Parse(cbUpdateInterval.Text),
                    HipChatStatusMappings = GetMappings()
                };

                Save(settings);
            }
        }

        private List<HipChatStatusMapping> GetMappings()
        {
            var unknown = new HipChatStatusMapping()
            {
                CodealikeStatus = API.CodealikeStatus.Unknown,
                HipChatMessage = txtUnknownMsg.Text,
                HipChatStatus = cbUnknown.Text.ToLower()
            };
            var noActivity = new HipChatStatusMapping()
            {
                CodealikeStatus = API.CodealikeStatus.NoActivity,
                HipChatMessage = txtNoActivityMsg.Text,
                HipChatStatus = cbNoActivity.Text.ToLower()
            };
            var canInterrupt = new HipChatStatusMapping()
            {
                CodealikeStatus = API.CodealikeStatus.CanInterrupt,
                HipChatMessage = txtCanInterruptMsg.Text,
                HipChatStatus = cbCanInterrupt.Text.ToLower()
            };
            var cannotInterrupt = new HipChatStatusMapping()
            {
                CodealikeStatus = API.CodealikeStatus.CannotInterrupt,
                HipChatMessage = txtCannotInterruptMsg.Text,
                HipChatStatus = cbCannotInterrupt.Text.ToLower()
            };


            return new List<HipChatStatusMapping>()
            {
                unknown, noActivity, canInterrupt, cannotInterrupt
            };
        }

        private void btnTestCodealike_Click(object sender, EventArgs e)
        {
            if (this.TestCodealike != null)
            {
                string userName = txtCodealikeUser.Text;
                this.TestCodealike(userName);
            }
        }

        private void btnTestHipChat_Click(object sender, EventArgs e)
        {
            if (this.TestHipChat != null)
            {
                string token = txtHipChatToken.Text;
                string email = txtHipChatEmail.Text;

                this.TestHipChat(token, email);
            }
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



        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void updateIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = null;
            
            this.disabledToolStripMenuItem.Checked = false;
            this.every5MinutesToolStripMenuItem.Checked = false;
            this.every10MinutesToolStripMenuItem.Checked = false;
            this.every15MinutesToolStripMenuItem.Checked = false;

            if (sender == this.disabledToolStripMenuItem)
            {
                item = this.disabledToolStripMenuItem;
                this.SetUpdateInterval(0);
            }
            else if (sender == this.every5MinutesToolStripMenuItem)
            {
                item = this.every5MinutesToolStripMenuItem;
                this.SetUpdateInterval(5);
            }
            else if (sender == this.every10MinutesToolStripMenuItem)
            {
                item = this.every10MinutesToolStripMenuItem;
                this.SetUpdateInterval(10);
            }
            else if (sender == this.every15MinutesToolStripMenuItem)
            {
                item = this.every15MinutesToolStripMenuItem;
                this.SetUpdateInterval(15);
            }

            if (item != null)
            {
                item.Checked = true;
            }
        }
    }
}
