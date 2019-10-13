using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaXZ
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Token { get; set; }
    }

    public class UserCredentials
    {
        [JsonProperty(PropertyName = "name")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "cpf")]
        public string Cpf { get; set; }
    }

}
