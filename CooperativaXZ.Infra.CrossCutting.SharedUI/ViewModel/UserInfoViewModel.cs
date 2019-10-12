using System.Collections.Generic;

namespace CooperativaXZ.Infra.CrossCutting.SharedUI.ViewModel
{
    public class UserInfoViewModel
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> ExposedClaims { get; set; }
    }
}
