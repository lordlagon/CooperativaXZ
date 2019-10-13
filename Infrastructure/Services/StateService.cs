using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaXZ
{
    public class StateService
    {
        private readonly IApiService api;

        public StateService(IApiService api)
        {
            this.api = api;
            User = new UserModel();
        }

        public event Action OnUserChange;

        private void NotifyUserChanged() => OnUserChange?.Invoke();

        public UserModel User { get; private set; }

        public bool IsSignedIn => User?.Token != null;

        public void UpdateUser(UserModel user)
        {
            var oldToken = User?.Token;
            var newToken = user?.Token;

            if (oldToken != newToken)
            {
                User = user;

                if (newToken != null)
                    api.SetToken(newToken);
                else
                    api.ClearToken();

                NotifyUserChanged();
            }
        }
    }
}
