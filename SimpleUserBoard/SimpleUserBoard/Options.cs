using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserBoard
{
    public partial class Options : Form
    {
        Default_things dt = new Default_things();
        public Options()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(64, 64, 64);

            #region default_options

            dt.default_form(this);
            dt.default_labels(new List<Label> 
            {   Optionslbl });

            dt.default_buttons(new List<Button> 
            {   Darkbtn,
                Brightbtn,
                Orangebtn,
                Xbtn,
                Testsbtn});
            
            dt.default_groupbox(new List<GroupBox> 
            {   Themegb,
                Languagegb });

            dt.default_checkbox(new List<CheckBox> 
            {   Engcb,
                Ptcb });
            #endregion
        }

        private void Xbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RESTART TO APPLY SETTINGS...","ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void Darkbtn_Click(object sender, EventArgs e)
        {
            dt.Set_conf("theme", "dark");
        }

        private void Brightbtn_Click(object sender, EventArgs e)
        {
            dt.Set_conf("theme", "bright");
        }

        private void Orangebtn_Click(object sender, EventArgs e)
        {
            dt.Set_conf("theme", "orange");
        }

        private void Testsbtn_Click(object sender, EventArgs e)
        {
            var t = new TestScreen();
            t.Show();
        }
    }
}
