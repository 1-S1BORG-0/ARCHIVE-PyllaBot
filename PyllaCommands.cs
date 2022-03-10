using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity.Extensions;
using DSharpPlus.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus.Interactivity;
using DSharpPlus.Net.Models;
using System.Xml;

namespace PyllaBot
{
    public class PyllaSave
    {
        public PyllaSave()
        {
            
        }

     
        [JsonProperty]
        public Dictionary<ulong, List<ulong>> customRoles = new Dictionary<ulong, List<ulong>>();
        [JsonProperty]
        public ulong guildId;
        [JsonProperty]
        public ulong scriptChannelId;
        [JsonProperty]
        public ulong levelChannelId;
        [JsonProperty]
        public ulong logChannelId;
        [JsonProperty]
        public ulong logAdminChannelId;
        [JsonProperty]
        public ulong welcomeChannelId;
        [JsonProperty]
        public ulong activityChannelId;
        [JsonProperty]
        public List<ulong> normalRoles = new List<ulong>();
        [JsonProperty]
        public List<PyllaAccount> pyllaAccounts = new List<PyllaAccount>();

        public async Task<bool> ContainsUserAccount(DiscordUser user)
        {
            foreach (PyllaAccount acc in pyllaAccounts)
            {
                if (acc.user == user) return true;
            }
            return false;
        }        
        public async Task<PyllaAccount?> GetUserAccount(DiscordUser user)
        {
            PyllaAccount? account = null;
            foreach (PyllaAccount acc in pyllaAccounts)
            {
                if (acc.user == user) account = acc;
            }
            return account;
        }

        [JsonIgnore]
        public DiscordGuild? guild 
        { 
            get
            {
                DiscordGuild? guild = null;
                if (Bot.bot != null)
                {
                    foreach (var pair in Bot.bot.Client.Guilds)
                    {
                        if (pair.Key == guildId)
                        {
                            guild = pair.Value;
                            break;
                        }
                    }
                }
                return guild;
            } 
        }

        [JsonIgnore]
        public DiscordChannel? scriptChannel => guild.GetChannel(scriptChannelId);
        [JsonIgnore]
        public DiscordChannel? levelChannel => guild.GetChannel(levelChannelId);
        [JsonIgnore]
        public DiscordChannel? logChannel => guild.GetChannel(logChannelId);
        [JsonIgnore]
        public DiscordChannel? logAdminChannel => guild.GetChannel(logAdminChannelId);
        [JsonIgnore]
        public DiscordChannel? welcomeChannel => guild.GetChannel(welcomeChannelId);
        [JsonIgnore]
        public DiscordChannel? activityChannel => guild.GetChannel(activityChannelId);
    }

    public class Script
    {
        public string Name = string.Empty;
        public string Description = string.Empty;
        public ulong ownerId;
        public string Code = string.Empty;
    }

    public class PyllaAccount
    {
        [JsonIgnore]
        public DiscordGuild? guild;

        [JsonProperty]
        public ulong userId;
        [JsonIgnore]
        public DiscordUser user => guild.GetMemberAsync(userId).GetAwaiter().GetResult();
        [JsonProperty]
        public double money;
        [JsonProperty]
        public double moneyInBank;
        [JsonProperty]
        public int lvlProgression;
        [JsonProperty]
        public int level = 1;
        [JsonProperty]
        public Script[]? scripts;

        [JsonIgnore]
        public double totalMoney { get { return money + moneyInBank; }
            set
            {
                if (money <= value)
                {
                    double n = money - value;
                    money = 0;

                    moneyInBank += n;
                }
                else
                {
                    money -= value;
                }
            }
        }
    }

    

    public class PyllaCommands : BaseCommandModule
    {
        #region fields
        public static PyllaSave pylla => config.pylla;
        public static Configuration config;
        #endregion

        #region others funcs
        public static void Init(Configuration config)
        {
            PyllaCommands.config = config;
        }

        public static Configuration Exit()
        {
            return config;
        }
        #endregion
        #region events
        public static async Task OnMessage(DiscordClient client, MessageCreateEventArgs args)
        {
            if (args.Message.Content.Contains(client.CurrentUser.Mention))
            {
                await args.Channel.SendMessageAsync("Some body called me?");
            }
        }
        #endregion
        #region cmds
        #region for normies
        [Command("ping")]
        public async Task PingCmd(CommandContext ctx)
        {
            await ctx.RespondAsync("Pong!");
        }
        #endregion
        #region for staff / people friends
        #endregion
        #region for . & ,
        #endregion
        #region config

        #endregion
        #endregion
    }
}
