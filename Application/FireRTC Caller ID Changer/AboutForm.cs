using System.Windows.Forms;

namespace FireRTC_Caller_ID_Changer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            versionLabel.Text = string.Format("Version {0}", Application.ProductVersion);
        }
    }
}
