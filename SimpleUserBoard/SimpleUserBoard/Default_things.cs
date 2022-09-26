using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserBoard
{
    internal class Default_things
    {
        public Default_things()
        {
            //call load
            Load();
        }
        string conf_path = "Conf.txt";

        public Color defaulttxt_color {get; set;}
        Color defaulttheme_color { get; set; }
        Color defaultpanel_color { get; set; }
        Color defaultform_color { get; set; }
        public void Load()
        {
            if (Get_conf("theme") == "dark")
            {
                defaultform_color = Color.Gray;
                defaulttxt_color = Color.White;
                defaulttheme_color = Color.White;
                defaultpanel_color = Color.FromArgb(32, 32, 32);
            }
            else if(Get_conf("theme") == "bright")
            {
                defaultform_color = Color.FromArgb(180,180,180);
                defaulttxt_color = Color.Black;
                defaulttheme_color = Color.Black;
                defaultpanel_color = Color.FromArgb(200,200,200);
            }
            else
            {
                defaultform_color = Color.FromArgb(64, 64, 64);
                defaulttxt_color = Color.Orange;
                defaulttheme_color = Color.Orange;
                defaultpanel_color = Color.FromArgb(16, 16, 16);
            }
        }
        public void default_form(Form frm)
        {
            frm.BackColor = defaultform_color;
        }
        public void default_buttons(List<Button> lb)
        {
            var btn_border = 1;
            foreach (var btn in lb)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = defaulttheme_color;
                btn.BackColor = Color.Transparent;
                btn.ForeColor = defaulttxt_color;
                btn.FlatAppearance.BorderSize = btn_border;
                btn.Cursor = Cursors.Hand;
            }
        }
        public void default_panels(List<Panel> lp)
        {
            foreach (var panel in lp)
            {
                panel.BackColor = defaultpanel_color;
            }
        }
        public void default_combobox(List<ComboBox> lcb)
        {
            foreach (var cb in lcb)
            {
                //put any conf here
            }
        }
        public void default_groupbox(List<GroupBox> lgb)
        {
            foreach (var gb in lgb)
            {
                gb.ForeColor = defaulttxt_color;
            }
        }
        public void default_labels(List<Label> ll)
        {
            foreach (var label in ll)
            {
                label.ForeColor = defaulttxt_color;
                label.BackColor = Color.Transparent;
            }
        }
        public void default_checkbox(List<CheckBox> cb)
        {
            foreach (var c in cb)
            {
                c.ForeColor = defaulttxt_color;
            }
        }
        #region Config
        public void Set_conf(string where, string what)
        {
            string[] lines = File.ReadAllLines(conf_path);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(where))
                {
                    string thing = lines[i].Remove(where.Length + 3);
                    lines[i] = thing + what;
                    Console.WriteLine(lines[i]); //erase this one
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var line in lines)
            {
                sb.AppendLine(line);
            }
            Console.WriteLine(sb.ToString()); //erase this one

            using (StreamWriter sw = new StreamWriter(conf_path))
            {
                sw.Write(sb);
            }
        }

        public string Get_conf(string where)
        {
            string[] lines = File.ReadAllLines(conf_path);

            foreach (var line in lines)
            {
                if (line.StartsWith(where))
                {
                    string thing = line.Substring(where.Length + 3);
                    return thing;
                }
            }
            return null;
        }
        #endregion
    }
}