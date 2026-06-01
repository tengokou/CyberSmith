using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSmith
{
    public partial class Form1 : Form
    {
        private string currentVideoPath = "";

        // video urls
        private const string IntroVideoUrl = "https://github.com/tengokou/CyberSmith-videos/releases/download/v1.0-videos/intro.mp4";
        private const string Option1VideoUrl = "https://github.com/tengokou/CyberSmith-videos/releases/download/v1.0-videos/option1.mp4";
        private const string Option2VideoUrl = "https://github.com/tengokou/CyberSmith-videos/releases/download/v1.0-videos/option2.mp4";
        private const string Option3VideoUrl = "https://github.com/tengokou/CyberSmith-videos/releases/download/v1.0-videos/option3.mp4";

        // Original resolution
        private const int OriginalWidth = 1920;
        private const int OriginalHeight = 1080;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Interactive Video Menu";
            this.ClientSize = new Size(1920, 1080);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;

            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ConfigureButtonHover(btnOption1);
            ConfigureButtonHover(btnOption2);
            ConfigureButtonHover(btnOption3);

            this.Resize += Form1_Resize;
        }

        private void ConfigureButtonHover(Button btn)
        {
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayIntroVideo();
        }

        private void PlayIntroVideo()
        {
            currentVideoPath = "";
            axWindowsMediaPlayer1.URL = IntroVideoUrl;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            panelMenu.Visible = false;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1 || e.newState == 8) // Stopped or Ended
            {
                ShowMenu();
            }
        }

        private void ShowMenu()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            panelMenu.Visible = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;

            float scaleX = (float)this.ClientSize.Width / OriginalWidth;
            float scaleY = (float)this.ClientSize.Height / OriginalHeight;

            ScaleControl(btnOption1, scaleX, scaleY);
            ScaleControl(btnOption2, scaleX, scaleY);
            ScaleControl(btnOption3, scaleX, scaleY);
        }

        private void ScaleControl(Control ctrl, float scaleX, float scaleY)
        {
            ctrl.Location = new Point((int)(ctrl.Location.X * scaleX), (int)(ctrl.Location.Y * scaleY));
            ctrl.Size = new Size((int)(ctrl.Size.Width * scaleX), (int)(ctrl.Size.Height * scaleY));
            ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size * Math.Min(scaleX, scaleY));
        }

        private void PlayAnimation(string videoUrl)
        {
            currentVideoPath = videoUrl;
            panelMenu.Visible = false;
            axWindowsMediaPlayer1.URL = videoUrl;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        // Button clicks
        private void btnOption1_Click(object sender, EventArgs e) => PlayAnimation(Option1VideoUrl);
        private void btnOption2_Click(object sender, EventArgs e) => PlayAnimation(Option2VideoUrl);
        private void btnOption3_Click(object sender, EventArgs e) => PlayAnimation(Option3VideoUrl);
    }
}