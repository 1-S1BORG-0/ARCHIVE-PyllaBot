using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyllaBot
{
    

    public partial class Form1 : Form
    {
        static internal Form2? logForm = null;
        static internal Bot? bot = null;
        static internal Configuration? configuration = null;
        public Form1()
        {
            InitializeComponent();
        }

        internal static void Update(DiscordClient client)
        {
            var form = Program.form;
            form.GuildsView.Nodes.Clear();
            form.RoleCombo.Items.Clear();
            form.Users.Items.Clear();
            foreach (var guild in client.Guilds.Values)
            {
                #region channel n categories
                var node = form.GuildsView.Nodes.Add($"{guild.Name} ({guild.MemberCount}) : {guild.Description}");
                node.Tag = guild;

                foreach (var channel in guild.Channels.Values)
                {
                    if (channel.IsCategory)
                    {
                        var category = node.Nodes.Add(channel.Name);
                        category.Tag = channel;

                        foreach (var child in channel.Children)
                        {
                            var childNode = category.Nodes.Add(child.Name);
                            childNode.Tag = child;
                        }
                        continue;
                    }

                    if (channel.Parent == null)
                    {
                        var channelNode = node.Nodes.Add(channel.Name);
                        channelNode.Tag = channel;
                    }

                }
                #endregion
                #region roles
                foreach (var role in guild.Roles.Values)
                {
                    form.RoleCombo.Items.Add(new Stringifyible((role: role, guild: guild), 
                        (object? v) => v != null ? $"{(((DiscordRole role, DiscordGuild guild))v).role.Name} ({(((DiscordRole role, DiscordGuild guild))v).guild.Name})" : "it's null but how did that happen"
                        ));
                }
                #endregion
                foreach (var user in guild.GetAllMembersAsync().GetAwaiter().GetResult())
                {
                    form.Users.Items.Add(new Stringifyible(user, (v) => $"{(v as DiscordMember).Username}({(v as DiscordMember).DisplayName})#{(v as DiscordMember).Discriminator} ({(v as DiscordMember).Guild.Name})"));
                    
                }
            }



        }

        internal static void UpdateStop()
        {
            var form = Program.form;
            form.GuildsView.Nodes.Clear();
            form.RoleCombo.Items.Clear();
            form.Users.Items.Clear();
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            if (logForm != null)
            {
                logForm.Close();
            }
            logForm = new Form2();
            logForm.Show();
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (configuration != null)
                {
                    Start.Enabled = false;
                    Stop.Enabled = true;
                    bot = new Bot();
                    await Logger.LogAsync("Bot Starting", LogLevel.Info);
                    await bot.RunAsync(configuration);
                }
                else
                {
                    MessageBox.Show("config is null");
                }
            }
            catch (Exception error)
            {
                var dialog = MessageBox.Show("there was an error, info about the error is in error.txt. do you want do stop the bot", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                Logger.Log("error starting bot: " + error.ToString(), LogLevel.Error);
                switch (dialog)
                {
                    case DialogResult.Yes:
                        File.WriteAllText("error.txt", error.Message + ":\n" + error.ToString());
                        await Bot.bot.Stop();
                        break;
                    case DialogResult.No:
                        File.WriteAllText("error.txt", error.Message + ":\n" + error.ToString());
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Stop_Click(object sender, EventArgs e)
        {
            Start.Enabled = true;
            Stop.Enabled = false;
            if (bot != null)
            {
                await bot.Stop();
                File.WriteAllText(ConfigPath.Text, JsonConvert.SerializeObject(bot.configuration));
                MessageBox.Show("stopped successfully");
            }
            else
            {
                MessageBox.Show("bot is null");
            }
        }

        private void LoadConfig_Click(object sender, EventArgs e)
        {
            configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(ConfigPath.Text));
            if (configuration != null)
                MessageBox.Show("config has loaded successfully");
            else
                MessageBox.Show("config has loaded but is null");
        }

        private void NewConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("created a new valid json config file");
            if (File.Exists(ConfigPath.Text))
            {
                File.Move(ConfigPath.Text, "config.json.old", true);
            }
            File.WriteAllText(ConfigPath.Text, JsonConvert.SerializeObject(new Configuration()));


        }

        private void OpenProgramFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "explorer.exe";
            string path = Directory.GetCurrentDirectory();
            startInfo.Arguments = path;
            process.StartInfo = startInfo;
            process.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update(Bot.bot.Client);
        }

        private void GuildsView_AfterSelect(object sender, TreeViewEventArgs e)
        {
                                    
            if (e.Node != null)
            {
                if (e.Node.Tag != null) {
                    DiscordInfo.ResetText();
                    DiscordInfo.ReadOnly = true;
                    if (e.Node.Tag is DiscordGuild)
                    {
                        var guild = e.Node.Tag as DiscordGuild;

                        DiscordInfo.Text =
    $@"Name: {guild.Name}
Description: {guild.Description}
ID: {guild.Id}
Max Members: {guild.MaxMembers}
Member Count: {guild.MemberCount}
Premium Tier: {guild.PremiumTier}
Boosters Count: {guild.PremiumSubscriptionCount}
Owner:
    Username: {guild.Owner.Username}
    Displayname: {guild.Owner.DisplayName}
    Discriminator: {guild.Owner.Discriminator}
    As shown: {guild.Owner.DisplayName}#{guild.Owner.Discriminator}
";
                    }
                    else if (e.Node.Tag is DiscordChannel)
                    {
                        var channel = e.Node.Tag as DiscordChannel;
                        if (channel.IsCategory) {
                            
                            DiscordInfo.Text =
$@"Name: {channel.Name}
NSFW: {channel.IsNSFW}
ID: {channel.Id}
Type: {channel.Type}

";
                        }

                        if (channel.Type == ChannelType.Text)
                        {
                            DiscordInfo.Text =
$@"Name: {channel.Name}
NSFW: {channel.IsNSFW}
ID: {channel.Id}
Type: {channel.Type}



";
                            foreach (var msg in channel.GetMessagesAsync((int)NumberOfMsgsToShow.Value).GetAwaiter().GetResult())
                            {
                                DiscordInfo.Text += $"\n\n{msg.Author.Username}#{msg.Author.Discriminator} {msg.CreationTimestamp.Offset}\n\t\t{msg.Content}";
                            }
                        }

                        if (channel.Type == ChannelType.Voice)
                        {
                            DiscordInfo.Text =
$@"Name: {channel.Name}
Topic: {channel.Topic}
NSFW: {channel.IsNSFW}
ID: {channel.Id}
Type: {channel.Type}

Users:

";
                            foreach (var user in channel.Users)
                            {
                                DiscordInfo.Text += $"{user.Username}#{user.Discriminator} - {(user.VoiceState.IsServerDeafened ? " deafened(server)" : string.Empty)}{(user.VoiceState.IsServerMuted ? " muted(server)" : string.Empty)}{(user.VoiceState.IsSelfDeafened ? " deafened(self)" : string.Empty)}{(user.VoiceState.IsSelfMuted ? " muted(self)" : string.Empty)}";
                            }
                        }
                    }
                }
            }
        }

        private void RoleBtn_Click(object sender, EventArgs e)
        {

        }
    }
    public class Stringifyible
    {
        public Stringifyible(object valuu)
        {
            Value = valuu;
        }

        public Stringifyible(object valuu, Func<object, string> stringifyFunc)
        {
            Value = valuu;
            StringifyFunc = stringifyFunc;
        }

        public object? Value = null;
        public string ValueAsString => UseStringifyFunc ? (StringifyFunc != null ? StringifyFunc(Value) : "null-stringifier") : (Value != null ? (Value.ToString() ?? "null") : "null-object");
        public Func<object?, string>? StringifyFunc;
        public bool UseStringifyFunc = true;
        public override string ToString()
        {
            return ValueAsString;
        }
    }
}
