using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FireRTC_Caller_ID_Changer
{
    public partial class MainForm : Form
    {
        private Dictionary<string, int[]> areaCodes = new Dictionary<string, int[]> {
            { "Random Area", new int[]{ } },
            { "Alaska", new int[]{ 907 } },
            { "Alabama", new int[]{ 205, 251, 256, 334 } },
            { "Arkansas", new int[]{ 479, 501, 870 } },
            { "Arizona", new int[]{ 480, 520, 602, 623, 928 } },
            { "California", new int[]{ 209, 213, 310, 323, 408, 415, 510, 530, 559, 562, 619, 626, 650, 661, 707, 714, 760, 805, 818, 831, 858, 909, 916, 925, 949, 951 } },
            { "Colorado", new int []{ 303, 719, 970 } },
            { "Connecticut", new int []{ 203, 860 } },
            { "District of Columbia", new int []{ 202 } },
            { "Delaware", new int[]{ 302 } },
            { "Florida", new int[]{ 239, 305, 321, 352, 386, 407, 561, 727, 772, 813, 850, 863, 904, 941, 954 } },
            { "Georgia", new int[]{ 229, 404, 478, 706, 770, 912 } },
            { "Hawaii", new int[]{ 808 } },
            { "Iowa", new int[]{ 319, 515, 563, 641, 712 } },
            { "Idaho", new int[]{ 208 } },
            { "Illinois", new int[]{ 217, 309, 312, 618, 630, 708, 773, 815, 847 } },
            { "Indiana", new int[]{ 219, 260, 317, 574, 765, 812 } },
            { "Kansas", new int[]{ 316, 620, 913 } },
            { "Kentucky", new int[]{ 270, 502, 606, 859 } },
            { "Louisiana", new int[]{ 225, 318, 337, 504, 985 } },
            { "Massachusetts", new int[]{ 413, 508, 617, 781, 978 } },
            { "Maryland", new int[]{ 301,410 } },
            { "Maine", new int[]{ 207 } },
            { "Michigan", new int[]{ 231, 248, 269, 313, 517, 586, 616, 734, 810, 906, 989 } },
            { "Minnesota", new int[]{ 218, 320, 507, 612, 651, 763, 952 } },
            { "Missouri", new int[]{ 314, 417, 573, 636, 660, 816 } },
            { "Mississippi", new int[]{ 228, 601, 662 } },
            { "Montana", new int[]{ 406 } },
            { "North Carolina", new int[]{ 252, 336, 704, 828, 910, 919 } },
            { "North Dakota", new int[]{ 701 } },
            { "Nebraska", new int[]{ 308, 402 } },
            { "New Hampshire", new int[]{ 603 } },
            { "New Jersey", new int[]{ 201, 609, 732, 856, 908, 973 } },
            { "New Mexico", new int[]{ 505, 575 } },
            { "Nevada", new int[]{ 702, 775 } },
            { "New York", new int[]{ 212, 315, 516, 518, 585, 607, 631, 716, 718, 845, 914 } },
            { "Ohio", new int[]{ 216, 330, 419, 440, 513, 614, 740, 937 } },
            { "Oklahoma", new int[]{ 405, 580, 918 } },
            { "Oregon", new int[]{ 503, 541 } },
            { "Pennsylvania", new int[]{ 215, 412, 570, 610, 717, 724, 814 } },
            { "Rhode Island", new int[]{ 401 } },
            { "South Carolina", new int[]{ 803, 843, 864 } },
            { "South Dakota", new int[]{ 605 } },
            { "Tennessee", new int[]{ 423, 615, 731, 865, 901, 931 } },
            { "Texas", new int[]{ 210, 214, 254, 281, 325, 361, 409, 432, 512, 713, 806, 817, 830, 903, 915, 936, 940, 956, 972, 979 } },
            { "Utah", new int[]{ 435, 801 } },
            { "Virginia", new int[]{ 276, 434, 540, 703, 757, 804 } },
            { "Vermont", new int[]{ 802 } },
            { "Washington", new int[]{ 206, 253, 360, 425, 509 } },
            { "Wisconsin", new int[]{ 262, 414, 608, 715, 920 } },
            { "West Virginia", new int[]{ 304 } },
            { "Wyoming", new int[]{ 307 } }
        };

        private bool changingCallerID = false;
        private string taguiName = Path.Combine(Application.StartupPath, "tagui\\src\\tagui.cmd");

        public MainForm()
        {
            InitializeComponent();

            foreach (var item in areaCodes)
            {
                areaComboBox.Items.Add(item.Key);
            }

            areaComboBox.SelectedIndex = Properties.Settings.Default.area;
            emailTextBox.Text = Properties.Settings.Default.email;
            passwordTextBox.Text = Properties.Settings.Default.password;
        }

        private string generateNumber()
        {
            Random random = new Random();
            string area;

            if (areaComboBox.SelectedIndex == 0)
            {
                area = areaComboBox.Items[random.Next(1, areaComboBox.Items.Count - 1)].ToString();
            }
            else
            {
                area = areaComboBox.Text;
            }

            int[] currentAreaCodes = areaCodes[area];
            int areaCode = currentAreaCodes[random.Next(currentAreaCodes.Length)];
            int w = random.Next(1, 10);
            int x = random.Next(0, 10);
            int y;

            if (x == 1)
            {
                y = random.Next(1, 10);
            }
            else
            {
                y = random.Next(0, 10);
            }

            int zzzz = random.Next(0, 10000);

            return string.Format("({0}){1}{2}{3}-{4}", areaCode, w.ToString("D1"), x.ToString("D1"), y.ToString("D1"), zzzz.ToString("D4"));
        }

        private string getTagUIScript(string number)
        {
            string rawScript = @"https://phone.firertc.com/phone
type user_email as <EMAIL>
type user_password as <PASSWORD>
click commit

if present('alert alert-alert col-sm-10 col-sm-offset-1 col-xs-10 col-xs-offset-1')
{
echo 'Failed to login'
}

https://phone.firertc.com/settings
type address_ua_config_display_name as [clear]<NUMBER>
click Save

if present('alert alert-error col-sm-10 col-sm-offset-1 col-xs-10 col-xs-offset-1')
{
echo 'Failed to change your Caller ID'
}
else if present('alert alert-notice col-sm-10 col-sm-offset-1 col-xs-10 col-xs-offset-1')
{
echo 'Successfully changed your Caller ID'
}";

            rawScript = rawScript.Replace("<EMAIL>", emailTextBox.Text.Replace("\\", "\\\\"));
            rawScript = rawScript.Replace("<PASSWORD>", passwordTextBox.Text.Replace("\\", "\\\\"));
            rawScript = rawScript.Replace("<NUMBER>", number);

            return rawScript;
        }

        private void changeCallerID()
        {
            if (!changingCallerID)
            {
                changingCallerID = true;
                programNotifyIcon.ContextMenuStrip = null;
                programNotifyIcon.ShowBalloonTip(5000, "Information", "Changing Caller ID...", ToolTipIcon.Info);

                if (File.Exists(taguiName))
                {
                    Guid scriptGuid = Guid.NewGuid();
                    string scriptFileName = string.Format("{0}.txt", scriptGuid.ToString());
                    string scriptPath = Path.Combine(Path.GetTempPath(), scriptFileName);
                    string number = generateNumber();
                    File.WriteAllText(scriptPath, getTagUIScript(number));

                    Process tagui = new Process();
                    tagui.StartInfo.FileName = taguiName;
                    tagui.StartInfo.Arguments = string.Format("\"{0}\"", scriptPath);
                    tagui.StartInfo.UseShellExecute = false;
                    tagui.StartInfo.RedirectStandardOutput = true;
                    tagui.StartInfo.CreateNoWindow = true;
                    tagui.Start();
                    tagui.WaitForExit(60000);

                    string[] scriptFiles = Directory.GetFiles(Path.GetTempPath(), string.Format("{0}*", scriptFileName));

                    foreach (string filePath in scriptFiles)
                    {
                        File.Delete(filePath);
                    }

                    bool balloonTipDisplayed = false;
                    StringBuilder stringBuilder = new StringBuilder();

                    while (!tagui.StandardOutput.EndOfStream)
                    {
                        string line = tagui.StandardOutput.ReadLine();
                        stringBuilder.AppendLine(line);

                        if (!balloonTipDisplayed)
                        {
                            if (line == "Failed to login")
                            {
                                programNotifyIcon.ShowBalloonTip(5000, "Error", "Failed to login to FireRTC! Please check your email and password.", ToolTipIcon.Error);
                                balloonTipDisplayed = true;
                            }
                            else if (line == "Failed to change your Caller ID")
                            {
                                programNotifyIcon.ShowBalloonTip(5000, "Error", string.Format("Failed to change your Caller ID! The generated number {0} seems to be invalid.", number), ToolTipIcon.Error);
                                balloonTipDisplayed = true;
                            }
                            else if (line.StartsWith("Successfully changed your Caller ID"))
                            {
                                programNotifyIcon.ShowBalloonTip(5000, "Information", string.Format("Your Caller ID has been changed to {0}!", number), ToolTipIcon.Info);
                                balloonTipDisplayed = true;
                            }
                        }
                    }

                    if (balloonTipDisplayed)
                    {
                        Clipboard.SetText(number);
                    }
                    else
                    {
                        if (stringBuilder.Length > 0)
                        {
                            Clipboard.SetText(stringBuilder.ToString());
                        }
                        else
                        {
                            Clipboard.SetText("TagUI has not been executed or has not returned any output!");
                        }
                        
                        programNotifyIcon.ShowBalloonTip(5000, "Error", string.Format("An error occurred while changing your Caller ID! The error log has been copied to your clipboard.", number), ToolTipIcon.Error);
                    }
                }

                programNotifyIcon.ContextMenuStrip = notifyIconMenu;
                changingCallerID = false;
            }
        }

        private string getStringFromKeyEventArgs(KeyEventArgs args)
        {
            KeysConverter converter = new KeysConverter();

            return converter.ConvertToInvariantString(args.KeyData);
        }

        private Keys getKeysFromString(string keys)
        {
            KeysConverter converter = new KeysConverter();

            return (Keys)converter.ConvertFromInvariantString(keys);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(taguiName))
            {
                MessageBox.Show("TagUI has not been found in the startup directory of this program! Exiting...", "TagUI not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.area = areaComboBox.SelectedIndex;
            Properties.Settings.Default.email = emailTextBox.Text;
            Properties.Settings.Default.password = passwordTextBox.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("The settings have been successfully saved!", "Settings successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void minimizeToTrayButton_Click(object sender, EventArgs e)
        {
            if (areaComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please selected an area!", "Area required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (emailTextBox.TextLength == 0)
            {
                MessageBox.Show("Please enter the email address of your FireRTC account!", "Email required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (passwordTextBox.TextLength == 0)
            {
                MessageBox.Show("Please enter the password of your FireRTC account!", "Password required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            Visible = false;
            programNotifyIcon.Visible = true;
        }

        private void programNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                changeCallerID();
            }
        }

        private void changeCallerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeCallerID();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Visible)
            {
                programNotifyIcon.Visible = false;
                Visible = true;
                BringToFront();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }
    }
}
