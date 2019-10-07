using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Bot.Discord.Module
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("roll")]
        public async Task Roll()
        {
            await ReplyAsync($"Rolling 1D20: {new Random().Next(1,20)}");
        }

        [Command("hi")]
        public async Task SayHi()
        {
            await ReplyAsync($"Priviet commerade, donte esta la bibliotecha");
        }
    }
}
