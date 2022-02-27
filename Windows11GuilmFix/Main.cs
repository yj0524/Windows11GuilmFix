using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Win11GulimFix
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void on_btn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey gulimKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", true);
                gulimKey.SetValue("Gulim & GulimChe & Dotum & DotumChe (TrueType)", "");
                gulimKey.SetValue("Gulim & GulimChe & Dotum & DotumChe", "");
                MessageBox.Show("재부팅하면 적용됩니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void off_btn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey gulimKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", true);
                gulimKey.SetValue("Gulim & GulimChe & Dotum & DotumChe (TrueType)", "gulim.ttc");
                gulimKey.SetValue("Gulim & GulimChe & Dotum & DotumChe", "gulim.ttc");
                MessageBox.Show("재부팅하면 적용됩니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboutlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yj0524");
        }
    }
}
