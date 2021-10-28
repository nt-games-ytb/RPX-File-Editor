#region Using
#region Utile
using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO.Compression;
using RPX_File_Editor;
using RPX_File_Editor.Properties;
using DiscordRpcDemo;
#endregion

#region Inutile
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Reflection;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Threading;
using System.CodeDom;
using System.Collections;
using System.Configuration;
using System.Linq;
using System.Deployment;
using System.Dynamic;
using System.Management;
using System.Net.Mail;
using System.Net.Mime;
using System.Resources;
using System.Runtime;
using System.Security;
using System.Timers;
using System.Web;
using System.Windows;
using System.Xml;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.DesignerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Hosting;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Windows.Markup;
using System.Windows.Input;
using System.Net.Cache;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
#endregion
#endregion

namespace RPX_File_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Update
            WebClient webClient = new WebClient();
            try
            {
                if (webClient.DownloadString("https://pastebin.com/raw/JJnDTmDw").Contains("1.0.0.0"))
                {
                }
                else
                {
                    if (MessageBox.Show("There are a new version of RPX File Editor ! Would you like to download it ?", "RPX File Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        try
                        {
                            //Process.Start("Updater.exe");
                            try
                            {
                                File.Delete(@"Update/RPX File Editor.exe");
                                File.Delete(@"Update/wiiurpxtool.exe");
                                File.Delete(@"Update/discord-rpc-w32.dll");
                            }
                            catch { }
                            //MessageBox.Show("Your software is Updating...\r\nPlese wait", "RPX File Editor");
                            webClient.DownloadFile("https://nt-games-site.000webhostapp.com/img/RPX%20File%20Editor.zip", "RPX File Editor.zip");
                            ZipFile.ExtractToDirectory("RPX File Editor.zip", @"./Update");
                            File.Delete("RPX File Editor.zip");
                            MessageBox.Show("Software update !\r\nThe last update of the software is on the \"Update\" folder.", "RPX File Editor");
                            Process.Start(@"Update\RPX File Editor.exe");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                    }
                }
            }
            catch
            {
                MessageBox.Show("The application can't check if there are a update because you are not connected to internet or other !", "RPX File Editor");
            }
            #endregion
        }

        int jeu = 0;
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        string fileName;

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Installation
            /*if (!Directory.Exists(@"C:/Users/" + Environment.UserName + "/AppData/Local/nt games Company"))
            {
                Directory.CreateDirectory(@"C:/Users/" + Environment.UserName + "/AppData/Local/nt games Company");
            }
            else { }
            if (!Directory.Exists(@"C:/Users/" + Environment.UserName + "/AppData/Local/nt games Company/RPX File Editor"))
            {
                Directory.CreateDirectory(@"C:/Users/" + Environment.UserName + "/AppData/Local/nt games Company/RPX File Editor");
            }
            else { }*/
            #endregion

            try
            {
                File.Delete("RPX File.rpx");
            }
            catch { }

            #region Discord Precense
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("814975524383883266", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("814975524383883266", ref this.handlers, true, null);
            this.presence.details = "V1";
            //this.presence.state = "";
            this.presence.largeImageKey = "rpx_file_editor";
            //this.presence.smallImageKey = "minecraft";
            this.presence.largeImageText = "RPX File Editor V1";
            //this.presence.smallImageText = "Minecraft";
            DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long startTimestamp = (long)(DateTime.UtcNow - d).TotalSeconds;
            this.presence.startTimestamp = startTimestamp;
            DiscordRpc.UpdatePresence(ref this.presence);
            #endregion
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "RPX/RPL Files (*.rpx/*.rpl)|*.rpx;*.rpl";
                fileDialog.Title = Resources.DialogOpen;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = fileDialog.FileName;
                    fileName = fileDialog.SafeFileName;
                    Process start = new Process();
                    start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    start.StartInfo.FileName = "wiiurpxtool.exe";
                    start.StartInfo.Arguments = "-d \"" + filepath + "\" \"" + "RPX File.rpx\"";//@"C:/Users/" + Environment.UserName + "/AppData/Local/nt games Company/RPX File Editor/RPX File.rpx\"";
                    start.Start();
                    start.WaitForExit();

                    MessageBox.Show("RPX Loaded !", "RPX File Editor");
                    ActiveForm.Text = "RPX File Editor V1 - Editing : " + fileName;
                    this.presence.state = "Editing : " + fileDialog.SafeFileName;
                    DiscordRpc.UpdatePresence(ref this.presence);
                    adress.Enabled = true;
                    value.Enabled = true;
                    change.Enabled = true;
                    save.Enabled = true;

                    #region Check game
                    if (fileDialog.SafeFileName == "Minecraft.Client.rpx")
                    {
                        game.SelectedIndex = 0;
                    }
                    if (fileDialog.SafeFileName == "t6_cafef_launcher.rpx")
                    {
                        game.SelectedIndex = 1;
                    }
                    if (fileDialog.SafeFileName == "t6_cafef_rpl.rpl")
                    {
                        game.SelectedIndex = 2;
                    }
                    if (fileDialog.SafeFileName == "t6mp_cafef_rpl.rpl")
                    {
                        game.SelectedIndex = 3;
                    }
                    if (fileDialog.SafeFileName == "carrot.rpx")
                    {
                        game.SelectedIndex = 4;
                    }
                    if (fileDialog.SafeFileName == "Turbo.rpx")
                    {
                        game.SelectedIndex = 5;
                    }
                    if (fileDialog.SafeFileName == "mvplayer.rpl")
                    {
                        game.SelectedIndex = 6;
                    }
                    if (fileDialog.SafeFileName == "mw_shamo.rpl")
                    {
                        game.SelectedIndex = 7;
                    }
                    if (fileDialog.SafeFileName == "mw_shamo_sbc.rpl")
                    {
                        game.SelectedIndex = 8;
                    }
                    if (fileDialog.SafeFileName == "RedCarpet.rpx")
                    {
                        game.SelectedIndex = 9;
                    }
                    if (fileDialog.SafeFileName == "Block.rpx")
                    {
                        game.SelectedIndex = 10;
                    }
                    if (fileDialog.SafeFileName == "nn_olv2.rpl")
                    {
                        game.SelectedIndex = 11;
                    }
                    if (fileDialog.SafeFileName == "red-pro2.rpx")
                    {
                        game.SelectedIndex = 12;
                    }
                    if (fileDialog.SafeFileName == "ferrum_app.rpx")
                    {
                        game.SelectedIndex = 13;
                    }
                    if (fileDialog.SafeFileName == "cross_f.rpx")
                    {
                        game.SelectedIndex = 14;
                    }
                    if (fileDialog.SafeFileName == "Gambit.rpx")
                    {
                        game.SelectedIndex = 15;
                    }
                    if (fileDialog.SafeFileName == "U-King.rpx")
                    {
                        game.SelectedIndex = 16;
                    }
                    /*else
                    {
                        comboBox1.SelectedIndex = 17;
                    }*/
                    #endregion
                }
            }
            catch
            {
                MessageBox.Show("Error !", "RPX File Editor");
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite("RPX File.rpx"));//@"C:/Users/" + Environment.UserName + "/AppData/Local/nt games Company/RPX File Editor/RPX File.rpx"));
                binaryWriter.BaseStream.Position = Convert.ToInt32(adress.Text, 16) + jeu;//adress
                byte[] value = BitConverter.GetBytes(Convert.ToInt32(this.value.Text, 16));//value
                Array.Reverse(value);
                binaryWriter.Write(value);
                binaryWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RPX File Editor");
            }
        }
        
        private void game_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (game.SelectedIndex == 0)//mc
            {
                jeu = 13380192 - 33554432;//CC2A60 - 02000000
                this.presence.smallImageKey = "minecraft";
                this.presence.smallImageText = "Minecraft";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 1)//bo2
            {
                jeu = 11456 - 33554432;//2CC0 - 02000000
                this.presence.smallImageKey = "bo2";
                this.presence.smallImageText = "Call of Duty : Black Ops II";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 2)//bo2
            {
                jeu = 4327552 - 33554432;//420880 - 02000000
                this.presence.smallImageKey = "wii_u";
                this.presence.smallImageText = "Wii U RPX/RPL File";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 3)//bo2
            {
                jeu = 4923200 - 33554432;//4B1F40 - 02000000
                this.presence.smallImageKey = "wii_u";
                this.presence.smallImageText = "Wii U RPX/RPL File";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 4)//Pikmin 3
            {
                jeu = 4233568 - 33554432;//409960 - 02000000
                this.presence.smallImageKey = "pikmin";
                this.presence.smallImageText = "Pikmin 3";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 5)//mk8
            {
                jeu = 1788448 - 33554432;//1B4A20 - 02000000
                this.presence.smallImageKey = "mario_kart_8";
                this.presence.smallImageText = "Mario Kart 8";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 6)//mvplayer
            {
                jeu = 320640 - 33554432;//4E480 - 02000000
                this.presence.smallImageKey = "wii_u";
                this.presence.smallImageText = "Wii U RPX/RPL File";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 7)//shamo
            {
                jeu = 473984 - 33554432;//73B80 - 02000000
                this.presence.smallImageKey = "wii_u";
                this.presence.smallImageText = "Wii U RPX/RPL File";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 8)//shamo sbc
            {
                jeu = 5120 - 33554432;//1400 - 02000000
                this.presence.smallImageKey = "wii_u";
                this.presence.smallImageText = "Wii U RPX/RPL File";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 9)//3d world
            {
                jeu = 4095008 - 33554432;//3E7C20 - 02000000
                this.presence.smallImageKey = "super_mario_3d_world_logo";
                this.presence.smallImageText = "Super Mario 3D World";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 10)//mario maker
            {
                jeu = 1865568 - 33554432;//1C7760 - 02000000
                this.presence.smallImageKey = "mario_maker";
                this.presence.smallImageText = "Super Mario Maker";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 11)//nn olv2
            {
                jeu = 442880 - 33554432;//6C200 - 02000000
                this.presence.smallImageKey = "wii_u";
                this.presence.smallImageText = "Wii U RPX/RPL File";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 12)//new super mario
            {
                jeu = 2111968 - 33554432;//2039E0 - 02000000
                this.presence.smallImageKey = "new_super_mario_bros__u_logo";
                this.presence.smallImageText = "New Super Mario Bros U";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 13)//pokken
            {
                jeu = 8085088 - 33554432;//7B5E60 - 02000000
                this.presence.smallImageKey = "pokken";
                this.presence.smallImageText = "Pokken";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 14)//smash4
            {
                jeu = 4704736 - 33554432;//47C9E0 - 02000000
                this.presence.smallImageKey = "smash4";
                this.presence.smallImageText = "Super Smash Bros U";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 15)//splatoon
            {
                jeu = 2040032 - 33554432;//1F20E0 - 02000000
                this.presence.smallImageKey = "splatoon";
                this.presence.smallImageText = "Splatoon";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 16)//zelda btow
            {
                jeu = 4765152 - 33554432;//48B5E0 - 02000000
                this.presence.smallImageKey = "zelda";
                this.presence.smallImageText = "Zelda : Breath of the Wild";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (game.SelectedIndex == 17)//other
            {
                this.presence.smallImageKey = "wii_u";
                this.presence.smallImageText = "Wii U RPX/RPL File";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "RPX/RPL Files (*.rpx/*.rpl)|*.rpx;*.rpl";
                fileDialog.InitialDirectory = Environment.CurrentDirectory;
                fileDialog.FileName = System.IO.Path.GetFileName(fileName);
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = fileDialog.FileName;
                    Process start = new Process();
                    start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    start.StartInfo.FileName = "wiiurpxtool.exe";
                    start.StartInfo.Arguments = "-c \"RPX File.rpx\" \"" + filepath + "\"";//@"C:/Users/" + Environment.UserName + "/AppData/Local/nt games Company/RPX File Editor/RPX File.rpx\"";
                    start.Start();
                    start.WaitForExit();
                    MessageBox.Show("RPX Saved !", "RPX File Editor");
                }
                fileDialog.Dispose();
            }
            catch
            {
                MessageBox.Show("Error !", "RPX File Editor");
            }
        }

        private void channel_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/nt-games-ytb");
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/nk22HmUDJC");
        }

        #region Test
        /*private byte[] HexStringToByteArray(string Hex)
        {
            return Enumerable.Range(0, Hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(Hex.Substring(x, 2), 16))
                     .ToArray();
        }*/
        #endregion
    }
}
