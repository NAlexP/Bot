using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Bot.Domain.Auth
{
    public class Role : IdentityRole<int>
    {
        public class Constants
        {
            public const string Admin = "Admin";
            public const string User = "User";
        }
    }
}
