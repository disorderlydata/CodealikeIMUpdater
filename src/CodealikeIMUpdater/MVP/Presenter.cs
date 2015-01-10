using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodealikeIMUpdater.MVP
{
    public class Presenter
    {
        private API.ICodealikeAPI codealikeApi;
        private API.IHipChatAPI hipChatApi;
        private IMUpdaterSettings settings;
        private int updateInterval;

        public Presenter(IMainView view)
        {
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
                this.settings = model;
                this.updateInterval = model.UpdateInterval * 60 * 1000;
            };

            view.SetUpdateInterval += (interval) =>
            {
                this.updateInterval = interval * 60 * 1000;
            };
        }
    }
}
