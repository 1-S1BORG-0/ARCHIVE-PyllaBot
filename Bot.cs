
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;

namespace PyllaBot
{
    public partial class Bot
    {
        public static Bot bot { get; private set; }
        public Configuration configuration = new Configuration();
        public DiscordClient Client { get; private set; }
        public CommandsNextExtension commands { get; private set; }
        private bool exiting = false;

        public async Task RunAsync(Configuration Configuration)
        {
            Bot.bot = this;
            configuration = Configuration;
            DiscordConfiguration config = new DiscordConfiguration()
            {
                Token = configuration.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.None,

            };

            Client = new DiscordClient(config);
            Client.UseInteractivity(new InteractivityConfiguration()
            {
                PollBehaviour = DSharpPlus.Interactivity.Enums.PollBehaviour.KeepEmojis,

            });

            Client.Ready += onStart;

            List<string> prefixes = new List<string>();
            foreach (string str in configuration.prefixes)
            {
                prefixes.Add(str);
            }

            CommandsNextConfiguration commandsConfig = new CommandsNextConfiguration
            {
                CaseSensitive = false,
                StringPrefixes = prefixes,
                EnableDms = true,
                EnableMentionPrefix = true,
                DmHelp = true
            };

            commands = Client.UseCommandsNext(commandsConfig);

            commands.RegisterCommands<PyllaCommands>();
            PyllaCommands.Init(configuration);
            Client.MessageCreated += PyllaCommands.OnMessage;
            await Client.ConnectAsync();

            await Task.Delay(1000);

            Form1.Update(Client);

            while (true)
            {
                await Task.Delay(100);
                if (exiting)
                    break;
            }
            exiting = false;
        }

        private Task onStart(DiscordClient c, ReadyEventArgs e)
        {
            Client.UpdateStatusAsync(new DSharpPlus.Entities.DiscordActivity("des trucs de bot", DSharpPlus.Entities.ActivityType.Playing), DSharpPlus.Entities.UserStatus.Online);
            return Task.CompletedTask;
        }

        public async Task Stop()
        {
            await Client.DisconnectAsync();
            configuration = PyllaCommands.Exit();
            Form1.UpdateStop();
            exiting = true;
        }
    }
}
