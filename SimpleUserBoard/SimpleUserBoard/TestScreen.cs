using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserBoard
{
    public partial class TestScreen : Form
    {
        public TestScreen()
        {
            InitializeComponent();

            var dt = new Default_things();
            dt.default_labels(new List<Label>()
            {
                Testlbl,
                Problemslbl});

            Test();
        }
        public void Test()
        {
            string testing = @"
[TESTING] - ";
            string ok = " [100%]";
            string fail = " [FAILED]";
            var drive = DriveInfo.GetDrives();
            foreach(var d in drive)
            {
                if (d.IsReady)
                {
                    Testtxt.Text += testing + d.Name + " - " + d.IsReady + ok;
                }
                else
                {
                    Testtxt.Text += testing + d.Name + " - " + d.IsReady + fail;
                }
            }
        }
    }
}
