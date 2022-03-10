namespace PyllaBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        internal void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.LoadConfig = new System.Windows.Forms.Button();
            this.NewConfig = new System.Windows.Forms.Button();
            this.ConfigPath = new System.Windows.Forms.TextBox();
            this.Logs = new System.Windows.Forms.Button();
            this.OpenProgramFolder = new System.Windows.Forms.Button();
            this.GuildsView = new System.Windows.Forms.TreeView();
            this.DiscordInfo = new System.Windows.Forms.RichTextBox();
            this.RoleBtn = new System.Windows.Forms.Button();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.DeafenBtn = new System.Windows.Forms.Button();
            this.MicBtn = new System.Windows.Forms.Button();
            this.BanBtn = new System.Windows.Forms.Button();
            this.KickBtn = new System.Windows.Forms.Button();
            this.SendMsgBtn = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeconnectBtn = new System.Windows.Forms.Button();
            this.MoveBtn = new System.Windows.Forms.Button();
            this.KickReason = new System.Windows.Forms.TextBox();
            this.BanReason = new System.Windows.Forms.TextBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RoleCombo = new System.Windows.Forms.ComboBox();
            this.DeviceCombo = new System.Windows.Forms.ComboBox();
            this.RolesUser = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UnBanReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnBanBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.NumberOfMsgsToShow = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfMsgsToShow)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 37);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(12, 55);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(90, 37);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LoadConfig
            // 
            this.LoadConfig.Location = new System.Drawing.Point(12, 98);
            this.LoadConfig.Name = "LoadConfig";
            this.LoadConfig.Size = new System.Drawing.Size(90, 37);
            this.LoadConfig.TabIndex = 2;
            this.LoadConfig.Text = "Load Config";
            this.LoadConfig.UseVisualStyleBackColor = true;
            this.LoadConfig.Click += new System.EventHandler(this.LoadConfig_Click);
            // 
            // NewConfig
            // 
            this.NewConfig.Location = new System.Drawing.Point(12, 141);
            this.NewConfig.Name = "NewConfig";
            this.NewConfig.Size = new System.Drawing.Size(90, 37);
            this.NewConfig.TabIndex = 3;
            this.NewConfig.Text = "New Config";
            this.NewConfig.UseVisualStyleBackColor = true;
            this.NewConfig.Click += new System.EventHandler(this.NewConfig_Click);
            // 
            // ConfigPath
            // 
            this.ConfigPath.Location = new System.Drawing.Point(108, 98);
            this.ConfigPath.Name = "ConfigPath";
            this.ConfigPath.Size = new System.Drawing.Size(231, 22);
            this.ConfigPath.TabIndex = 4;
            this.ConfigPath.Text = "config.json";
            // 
            // Logs
            // 
            this.Logs.Location = new System.Drawing.Point(12, 227);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(75, 23);
            this.Logs.TabIndex = 5;
            this.Logs.Text = "logs";
            this.Logs.UseVisualStyleBackColor = true;
            this.Logs.Click += new System.EventHandler(this.Logs_Click);
            // 
            // OpenProgramFolder
            // 
            this.OpenProgramFolder.Location = new System.Drawing.Point(12, 184);
            this.OpenProgramFolder.Name = "OpenProgramFolder";
            this.OpenProgramFolder.Size = new System.Drawing.Size(90, 37);
            this.OpenProgramFolder.TabIndex = 6;
            this.OpenProgramFolder.Text = "Program Folder";
            this.OpenProgramFolder.UseVisualStyleBackColor = true;
            this.OpenProgramFolder.Click += new System.EventHandler(this.OpenProgramFolder_Click);
            // 
            // GuildsView
            // 
            this.GuildsView.Location = new System.Drawing.Point(441, 12);
            this.GuildsView.Name = "GuildsView";
            this.GuildsView.Size = new System.Drawing.Size(272, 622);
            this.GuildsView.TabIndex = 7;
            this.GuildsView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.GuildsView_AfterSelect);
            // 
            // DiscordInfo
            // 
            this.DiscordInfo.Location = new System.Drawing.Point(12, 256);
            this.DiscordInfo.Name = "DiscordInfo";
            this.DiscordInfo.Size = new System.Drawing.Size(423, 378);
            this.DiscordInfo.TabIndex = 8;
            this.DiscordInfo.Text = "";
            // 
            // RoleBtn
            // 
            this.RoleBtn.Location = new System.Drawing.Point(719, 12);
            this.RoleBtn.Name = "RoleBtn";
            this.RoleBtn.Size = new System.Drawing.Size(124, 23);
            this.RoleBtn.TabIndex = 9;
            this.RoleBtn.Text = "assign role";
            this.RoleBtn.UseVisualStyleBackColor = true;
            this.RoleBtn.Click += new System.EventHandler(this.RoleBtn_Click);
            // 
            // MuteBtn
            // 
            this.MuteBtn.Location = new System.Drawing.Point(719, 41);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(124, 23);
            this.MuteBtn.TabIndex = 10;
            this.MuteBtn.Text = "mute";
            this.MuteBtn.UseVisualStyleBackColor = true;
            // 
            // DeafenBtn
            // 
            this.DeafenBtn.Location = new System.Drawing.Point(719, 70);
            this.DeafenBtn.Name = "DeafenBtn";
            this.DeafenBtn.Size = new System.Drawing.Size(124, 23);
            this.DeafenBtn.TabIndex = 11;
            this.DeafenBtn.Text = "deafen";
            this.DeafenBtn.UseVisualStyleBackColor = true;
            // 
            // MicBtn
            // 
            this.MicBtn.Location = new System.Drawing.Point(719, 99);
            this.MicBtn.Name = "MicBtn";
            this.MicBtn.Size = new System.Drawing.Size(124, 23);
            this.MicBtn.TabIndex = 13;
            this.MicBtn.Text = "activate mic";
            this.MicBtn.UseVisualStyleBackColor = true;
            // 
            // BanBtn
            // 
            this.BanBtn.Location = new System.Drawing.Point(719, 186);
            this.BanBtn.Name = "BanBtn";
            this.BanBtn.Size = new System.Drawing.Size(124, 23);
            this.BanBtn.TabIndex = 14;
            this.BanBtn.Text = "ban";
            this.BanBtn.UseVisualStyleBackColor = true;
            // 
            // KickBtn
            // 
            this.KickBtn.Location = new System.Drawing.Point(719, 244);
            this.KickBtn.Name = "KickBtn";
            this.KickBtn.Size = new System.Drawing.Size(124, 23);
            this.KickBtn.TabIndex = 15;
            this.KickBtn.Text = "kick";
            this.KickBtn.UseVisualStyleBackColor = true;
            // 
            // SendMsgBtn
            // 
            this.SendMsgBtn.Location = new System.Drawing.Point(719, 273);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.SendMsgBtn.Size = new System.Drawing.Size(124, 23);
            this.SendMsgBtn.TabIndex = 17;
            this.SendMsgBtn.Text = "send msg";
            this.SendMsgBtn.UseVisualStyleBackColor = true;
            // 
            // Msg
            // 
            this.Msg.Location = new System.Drawing.Point(883, 277);
            this.Msg.Multiline = true;
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(248, 91);
            this.Msg.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "msg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "reason";
            // 
            // DeconnectBtn
            // 
            this.DeconnectBtn.Location = new System.Drawing.Point(719, 128);
            this.DeconnectBtn.Name = "DeconnectBtn";
            this.DeconnectBtn.Size = new System.Drawing.Size(124, 23);
            this.DeconnectBtn.TabIndex = 23;
            this.DeconnectBtn.Text = "deconnect";
            this.DeconnectBtn.UseVisualStyleBackColor = true;
            // 
            // MoveBtn
            // 
            this.MoveBtn.Location = new System.Drawing.Point(719, 157);
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Size = new System.Drawing.Size(124, 23);
            this.MoveBtn.TabIndex = 24;
            this.MoveBtn.Text = "move";
            this.MoveBtn.UseVisualStyleBackColor = true;
            // 
            // KickReason
            // 
            this.KickReason.Location = new System.Drawing.Point(904, 245);
            this.KickReason.Name = "KickReason";
            this.KickReason.Size = new System.Drawing.Size(227, 22);
            this.KickReason.TabIndex = 26;
            // 
            // BanReason
            // 
            this.BanReason.Location = new System.Drawing.Point(904, 187);
            this.BanReason.Name = "BanReason";
            this.BanReason.Size = new System.Drawing.Size(227, 22);
            this.BanReason.TabIndex = 27;
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 14;
            this.Users.Location = new System.Drawing.Point(1137, 12);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(332, 578);
            this.Users.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(849, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "device";
            // 
            // RoleCombo
            // 
            this.RoleCombo.FormattingEnabled = true;
            this.RoleCombo.Location = new System.Drawing.Point(849, 13);
            this.RoleCombo.Name = "RoleCombo";
            this.RoleCombo.Size = new System.Drawing.Size(282, 22);
            this.RoleCombo.TabIndex = 30;
            // 
            // DeviceCombo
            // 
            this.DeviceCombo.FormattingEnabled = true;
            this.DeviceCombo.Location = new System.Drawing.Point(904, 100);
            this.DeviceCombo.Name = "DeviceCombo";
            this.DeviceCombo.Size = new System.Drawing.Size(227, 22);
            this.DeviceCombo.TabIndex = 31;
            // 
            // RolesUser
            // 
            this.RolesUser.FormattingEnabled = true;
            this.RolesUser.ItemHeight = 14;
            this.RolesUser.Location = new System.Drawing.Point(883, 370);
            this.RolesUser.Name = "RolesUser";
            this.RolesUser.Size = new System.Drawing.Size(248, 256);
            this.RolesUser.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(835, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "roles";
            // 
            // UnBanReason
            // 
            this.UnBanReason.Location = new System.Drawing.Point(904, 216);
            this.UnBanReason.Name = "UnBanReason";
            this.UnBanReason.Size = new System.Drawing.Size(227, 22);
            this.UnBanReason.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "reason";
            // 
            // UnBanBtn
            // 
            this.UnBanBtn.Location = new System.Drawing.Point(719, 215);
            this.UnBanBtn.Name = "UnBanBtn";
            this.UnBanBtn.Size = new System.Drawing.Size(124, 23);
            this.UnBanBtn.TabIndex = 34;
            this.UnBanBtn.Text = "unban";
            this.UnBanBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1137, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1137, 625);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 18);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Username";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1225, 625);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 18);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "Displayname";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1218, 596);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 40;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1334, 625);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 18);
            this.checkBox3.TabIndex = 41;
            this.checkBox3.Text = "Role";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumberOfMsgsToShow
            // 
            this.NumberOfMsgsToShow.Location = new System.Drawing.Point(315, 229);
            this.NumberOfMsgsToShow.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumberOfMsgsToShow.Name = "NumberOfMsgsToShow";
            this.NumberOfMsgsToShow.Size = new System.Drawing.Size(120, 22);
            this.NumberOfMsgsToShow.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 14);
            this.label7.TabIndex = 45;
            this.label7.Text = "Number of messages";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(1394, 625);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(61, 18);
            this.checkBox4.TabIndex = 46;
            this.checkBox4.Text = "Guild";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 646);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfMsgsToShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UnBanReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnBanBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolesUser);
            this.Controls.Add(this.DeviceCombo);
            this.Controls.Add(this.RoleCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.BanReason);
            this.Controls.Add(this.KickReason);
            this.Controls.Add(this.MoveBtn);
            this.Controls.Add(this.DeconnectBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.SendMsgBtn);
            this.Controls.Add(this.KickBtn);
            this.Controls.Add(this.BanBtn);
            this.Controls.Add(this.MicBtn);
            this.Controls.Add(this.DeafenBtn);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.RoleBtn);
            this.Controls.Add(this.DiscordInfo);
            this.Controls.Add(this.GuildsView);
            this.Controls.Add(this.OpenProgramFolder);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.ConfigPath);
            this.Controls.Add(this.NewConfig);
            this.Controls.Add(this.LoadConfig);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfMsgsToShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Button Start;
        internal Button Stop;
        internal Button LoadConfig;
        internal Button NewConfig;
        internal TextBox ConfigPath;
        internal Button Logs;
        internal Button OpenProgramFolder;
        internal TreeView GuildsView;
        internal RichTextBox DiscordInfo;
        internal Button RoleBtn;
        internal Button MuteBtn;
        internal Button DeafenBtn;
        internal Button MicBtn;
        internal Button BanBtn;
        internal Button KickBtn;
        internal Button SendMsgBtn;
        internal TextBox Msg;
        internal Label label1;
        internal Label label3;
        internal Label label4;
        internal Button DeconnectBtn;
        internal Button MoveBtn;
        internal TextBox KickReason;
        internal TextBox BanReason;
        internal ListBox Users;
        internal Label label5;
        internal ComboBox RoleCombo;
        internal ComboBox DeviceCombo;
        internal ListBox RolesUser;
        internal Label label6;
        internal TextBox UnBanReason;
        internal Label label2;
        internal Button UnBanBtn;
        internal Button button1;
        internal CheckBox checkBox1;
        internal CheckBox checkBox2;
        internal TextBox textBox1;
        internal CheckBox checkBox3;
        private Button button2;
        private NumericUpDown NumberOfMsgsToShow;
        private Label label7;
        private CheckBox checkBox4;
    }
}