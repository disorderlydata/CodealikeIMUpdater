using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodealikeIMUpdater.MVP
{
    public class Presenter
    {
        private IMUpdaterSettings settings;
        private int updateInterval;

        private readonly API.ICodealikeAPI codealikeApi;
        private readonly API.IHipChatAPI hipChatApi;
        private readonly Timer updateTimer;
        private readonly IMainView view;
        private API.CodealikeStatus previousStatus;

        public Presenter(IMainView view)
        {
            this.updateTimer = new Timer();
            this.updateTimer.Interval += 5 * 60 * 1000; //default to 5 minutes
            this.updateTimer.Tick += updateTimer_Tick;

            this.view = view;

            this.codealikeApi = new API.Impl.CodealikeAPI();
            this.hipChatApi = new API.Impl.HipChatAPI();

            view.TestCodealike += (username) =>
            {
                var status = codealikeApi.GetUsersStatus(username);
                view.ShowMessage(string.Format("The current status for {0} is {1}", username, status.ToString()));
            };

            view.TestHipChat += (token, email) =>
            {
                var user = hipChatApi.GetUser(token, email);
                var message = string.Format("{0} is currently set as {1} with the message '{2}'", user.name, user.presence.show, user.presence.status);

                view.ShowMessage(message);
            };

            view.Save += (model) =>
            {
                if (VerifySettings(model))
                {
                    this.settings = model;
                    this.updateInterval = model.UpdateInterval * 60 * 1000;
                    this.updateTimer_Tick(null, null);
                    this.updateTimer.Start();
                }
                else
                {
                    view.ShowError("Settings not valid.");
                }
            };

            view.SetUpdateInterval += (interval) =>
            {
                this.updateInterval = interval * 60 * 1000;
                this.updateTimer.Interval = this.updateInterval;
                this.updateTimer.Stop();
                this.updateTimer.Start();
            };
        }

        private bool VerifySettings(IMUpdaterSettings model)
        {
            return model != null &&
                model.HipChatStatusMappings != null &&
                !string.IsNullOrWhiteSpace(model.CodealikeUsername) &&
                !string.IsNullOrWhiteSpace(model.HipChatEmail) &&
                !string.IsNullOrWhiteSpace(model.HipChatToken);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (this.settings == null)
            {
                updateTimer.Stop();
                view.ShowError("No settings configured");
            }

            var currentStatus = codealikeApi.GetUsersStatus(settings.CodealikeUsername);

            if (currentStatus != previousStatus)
            {
                var mapping = settings.HipChatStatusMappings.FirstOrDefault(m => m.CodealikeStatus == currentStatus);

                var user = this.hipChatApi.GetUser(settings.HipChatToken, settings.HipChatEmail);

                user.presence = new API.Presence()
                {
                    status = mapping.HipChatMessage,
                    show = mapping.HipChatStatus
                };

                hipChatApi.UpdateUserStatus(settings.HipChatToken, user);

                previousStatus = currentStatus;

                view.SetIconFromStatus(currentStatus);
            }
        }
    }
}
