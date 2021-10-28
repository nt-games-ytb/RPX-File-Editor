namespace RPX_File_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.load = new System.Windows.Forms.Button();
            this.adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.game = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.channel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(12, 12);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(400, 40);
            this.load.TabIndex = 0;
            this.load.Text = "Load RPX File";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // adress
            // 
            this.adress.Enabled = false;
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress.Location = new System.Drawing.Point(12, 82);
            this.adress.MaxLength = 8;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(190, 31);
            this.adress.TabIndex = 1;
            this.adress.Text = "02000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adress :";
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(12, 119);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(400, 40);
            this.change.TabIndex = 3;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(12, 165);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(400, 40);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // value
            // 
            this.value.Enabled = false;
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(222, 82);
            this.value.MaxLength = 8;
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(190, 31);
            this.value.TabIndex = 5;
            this.value.Text = "00000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 120);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // game
            // 
            this.game.AutoCompleteCustomSource.AddRange(new string[] {
            "Minecraft.Client.rpx (Minecraft)",
            "t6_cafef_launcher.rpx (Black Ops II)",
            "t6_cafef_rpl.rpl (Black Ops II)",
            "t6mp_cafef_rpl.rpl (Black Ops II)",
            "carrot.rpx (Pikmin 3)",
            "Turbo.rpx (Mario Kart 8)",
            "mvplayer.rpl (Mario Kart 8)",
            "mw_shamo.rpl (Mario Kart 8, Smash 4)",
            "mw_shamo_sbc.rpl (Mario Kart 8, Smash 4)",
            "RedCarpet.rpx (Super Mario 3D World)",
            "Block.rpx (Super Mario Maker)",
            "nn_olv2.rpl (Super Mario Maker, Smash 4)",
            "red-pro2.rpx (New Super Marios Bros U)",
            "ferrum_app.rpx (Pokken)",
            "cross_f.rpx (Smash 4)",
            "Gambit.rpx (Splatoon)",
            "U-King.rpx (Zelda BOTW)",
            "Others games"});
            this.game.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.game.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.FormattingEnabled = true;
            this.game.Items.AddRange(new object[] {
            "Minecraft.Client.rpx (Minecraft)",
            "t6_cafef_launcher.rpx (Black Ops II)",
            "t6_cafef_rpl.rpl (Black Ops II)",
            "t6mp_cafef_rpl.rpl (Black Ops II)",
            "carrot.rpx (Pikmin 3)",
            "Turbo.rpx (Mario Kart 8)",
            "mvplayer.rpl (Mario Kart 8)",
            "mw_shamo.rpl (Mario Kart 8, Smash 4)",
            "mw_shamo_sbc.rpl (Mario Kart 8, Smash 4)",
            "RedCarpet.rpx (Super Mario 3D World)",
            "Block.rpx (Super Mario Maker)",
            "nn_olv2.rpl (Super Mario Maker, Smash 4)",
            "red-pro2.rpx (New Super Marios Bros U)",
            "ferrum_app.rpx (Pokken)",
            "cross_f.rpx (Smash 4)",
            "Gambit.rpx (Splatoon)",
            "U-King.rpx (Zelda BOTW)",
            "Others games"});
            this.game.Location = new System.Drawing.Point(418, 12);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(304, 28);
            this.game.TabIndex = 8;
            this.game.Text = "Others games";
            this.game.SelectedIndexChanged += new System.EventHandler(this.game_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(418, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 155);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How it work ?";
            // 
            // discord
            // 
            this.discord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discord.Location = new System.Drawing.Point(574, 211);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(148, 29);
            this.discord.TabIndex = 10;
            this.discord.Text = "nt games discord";
            this.discord.UseVisualStyleBackColor = true;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "This was make by nt games with the wiiurpxtool.\r\nDiscord : nt games#0375";
            // 
            // channel
            // 
            this.channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel.Location = new System.Drawing.Point(418, 211);
            this.channel.Name = "channel";
            this.channel.Size = new System.Drawing.Size(148, 29);
            this.channel.TabIndex = 12;
            this.channel.Text = "nt games channel";
            this.channel.UseVisualStyleBackColor = true;
            this.channel.Click += new System.EventHandler(this.channel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 246);
            this.Controls.Add(this.channel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.game);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value);
            this.Controls.Add(this.save);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPX File Editor V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox game;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button channel;
    }
}

