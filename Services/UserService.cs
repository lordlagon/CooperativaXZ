using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaXZ
{
    public class UserService
    {
        private readonly IJwtService jwtService;
        private readonly IApiService api;
        private readonly StateService state;
    }
}
