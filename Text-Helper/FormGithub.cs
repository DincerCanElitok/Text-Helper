using System.Diagnostics;
using System.Windows.Forms;

namespace Text_Helper
{
    public partial class FormGithub : Form
    {
        public FormGithub()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/DincerCanElitok",
                UseShellExecute = true
            });

        }
    }
}
