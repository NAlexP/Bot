using System;
using Bot.Domain.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bot.Data
{
    public class BotContext : IdentityDbContext<User, Role, int>
    {
    }
}
