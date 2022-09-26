using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleUserBoard
{
    public partial class Main : Form
    {
        string conf_path = "Conf.txt";
        Default_things dt = new Default_things();
        public Main()
        {
            InitializeComponent();

            MemUsage();

            #region default_options
            dt.default_form(this);
            dt.default_buttons(new List<Button>() 
            {   Xbtn,
                OpenLinkbtn,
                MyGitHubbtn,
                MyInstagrambtn,
                MyLinkedInbtn,
                Confbtn,
                Epicbtn,
                Steambtn,
                Xboxbtn});

            dt.default_panels(new List<Panel> 
            {   Left_panel,
                Top_panel,
                Gamespanel,
                PCSpecspanel,
                Stuffpanel});

            dt.default_combobox(new List<ComboBox> 
            {   OpenLinkcb});

            dt.default_groupbox(new List<GroupBox>
            {   Helpgb,
                HDSSDgb});

            dt.default_labels(new List<Label>
            {   Howtolbl,
                Howtolbltxt,
                Gameslbl,
                Gameshelplbl,
                PCSlbl,
                PCSinfolbl,
                FreeSpacedeflbl,
                FreeSpacedeflbl2,
                FreeSpacelbl,
                FreeSpacedefBYTESlbl,
                FreeSpacedefBYTESlbl2,
                Timelbl,
                Datelbl,
                Nonlbl,
                Contactlbl,
                label1});

            var drive = DriveInfo.GetDrives();
            FreeSpacedeflbl.Text =
                (drive[0].Name + " " + drive[0].AvailableFreeSpace/1024/1024/1024).ToString() + " GB";
            FreeSpacedefBYTESlbl.Text =
                " (" + (drive[0].AvailableFreeSpace).ToString() + " BYTES" + ")";

            if (drive[1] != null)
            {
                FreeSpacedeflbl2.Text =
                    (drive[1].Name + " " + drive[1].AvailableFreeSpace / 1024 / 1024 / 1024).ToString() + " GB";
                FreeSpacedefBYTESlbl2.Text =
                    " (" + (drive[1].AvailableFreeSpace).ToString() + " BYTES" + ")";
            }
            #endregion
        }
        private void Xbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Chart Aint Working
        public void MemUsage()
        {
            Title t = new Title();
            t.Font = new Font("Arial", 14, FontStyle.Bold);
            t.ForeColor = dt.defaulttxt_color;
            t.Text = "Memory Usage";
            //MemUsagechart.Titles.Add(t);

            //MemUsagechart.Series.Add("Memory Usage");
            //MemUsagechart.Series[0].LegendText = "Memory Usage";

            //MemUsagechart.Series[0].ChartType = SeriesChartType.Column;

            //MemUsagechart.Series[0].BorderWidth = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"  Physical memory usage     : {Process.GetCurrentProcess().PrivateMemorySize64 / 1024}";
            //MemUsagechart.Series[0].Points.AddXY(Process.GetCurrentProcess().PrivateMemorySize64 / 1024, Process.GetCurrentProcess().PrivateMemorySize64 / 1024);
            Timelbl.Text = DateTime.Now.ToShortTimeString();
            Datelbl.Text = DateTime.Now.ToShortDateString();
        }
        #endregion
        private void OpenLinkbtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?q=" + OpenLinkcb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an valid option.");
            }
        }

        #region hoverthings
        int normal_heigh = 76;
        int hover_heigh = 70;
        private void Epicbtn_MouseLeave(object sender, EventArgs e)
        {
            EpicImage.Location = new System.Drawing.Point(13, normal_heigh);
        }

        private void Xboxbtn_MouseLeave(object sender, EventArgs e)
        {
            XboxImage.Location = new System.Drawing.Point(199, normal_heigh);
        }

        private void Steambtn_MouseLeave(object sender, EventArgs e)
        {
            SteamImage.Location = new System.Drawing.Point(106, normal_heigh);
        }

        private void Epicbtn_MouseEnter(object sender, EventArgs e)
        {
            EpicImage.Location = new System.Drawing.Point(13, hover_heigh);
        }

        private void Steambtn_MouseEnter(object sender, EventArgs e)
        {
            SteamImage.Location = new System.Drawing.Point(106, hover_heigh);
        }

        private void Xboxbtn_MouseEnter(object sender, EventArgs e)
        {
            XboxImage.Location = new System.Drawing.Point(199, hover_heigh);
        }

        private void Epicbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://store.epicgames.com/");
        }

        private void Steambtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://store.steampowered.com/");
        }

        private void Xboxbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.xbox.com/");
        }
        #endregion

        #region mylinks
        private void MyGitHubbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TavaresNatan"); 
        }

        private void MyLinkedInbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.linkedin.com/in/dhonatan-tavares-n4t4n");
        }

        private void MyInstagrambtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/04_natan_10/"); 
        }
        #endregion

        private void Confbtn_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ShowDialog();
        }
    }
}