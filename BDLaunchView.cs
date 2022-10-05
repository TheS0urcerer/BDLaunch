using System.Net;
using WMPLib;
using System.Diagnostics;
using System.Net.Sockets;

namespace BDLaunch
{
    public partial class BDLaunchView : Form
    {
        #region Low Level Windows Code

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BDLaunchView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion  Low Level Windows Code
        public static string basePath = Application.StartupPath;
        public static ServiceIni serviceIni = new ServiceIni();
        private bool checkEnable { get; set; } = true;
        private bool hostAvail { get; set; } = false;
        private bool exeAvail = File.Exists("bin64\\BlackDesert64.exe");
        public BDLaunchView() => InitializeComponent();
        private void btnHide_MouseEnter(object sender, EventArgs e)
        {
            btnHide.BackgroundImage = global::BDLaunch.Properties.Resources.see;
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnHide_MouseLeave(object sender, EventArgs e)
        {
            btnHide.BackgroundImage = global::BDLaunch.Properties.Resources.nosee;
            txtPass.UseSystemPasswordChar = true;
        }
        private void btnExit_Click(object sender, EventArgs e) => Dispose();

        private TcpClient host = new TcpClient();
        private void checkServers()
        {
            if (!checkEnable)
                return;
            if (string.IsNullOrEmpty(serviceIni.host))
                return;

            IPAddress[] addresses = Dns.GetHostAddresses(serviceIni.host);
            if (addresses.Length > 0)
            {
                try
                {
                    host.Connect(addresses[0], serviceIni.port);
                }
                catch (Exception)
                {
                    return;
                }
            }
            hostAvail = true;
            host.Close();
        }
        const string AudioName = "audio.mp3";
        private void BDLaunchView_Load(object sender, EventArgs e)
        {
            // pull settings and set up

            chkRemember.Checked = Properties.Settings.Default.remember;
            txtUser.Text = Properties.Settings.Default.user;
            txtPass.Text = Properties.Settings.Default.pass;
            silence = Properties.Settings.Default.silence;
            if (!File.Exists(AudioName))
                File.WriteAllBytes(AudioName, Properties.Resources.audio);

            chkSilence_CheckedChanged(new object(), new EventArgs());
            worker.RunWorkerAsync();
        }

        //private SoundPlayer player = new SoundPlayer(Properties.Resources.BackgroundMusic);
        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        private void chkSilence_CheckedChanged(object sender, EventArgs e)
        {
            if (silence)
                stopPlaying();
            else
                startPlaying();
        }

        private void startPlaying()
        {
            btnSound.BackgroundImage = Properties.Resources.soundOn;
            wmp.URL = AudioName;
            wmp.controls.play();
        }

        private void stopPlaying()
        {
            btnSound.BackgroundImage = Properties.Resources.soundOff;
            wmp.controls.stop();
        }
        private string hostTxt = "Down";
        private Color hostColor = Color.DarkRed;
        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!worker.CancellationPending)
            {
                try
                {
                    
                    checkServers();
                    if (hostAvail)
                    {
                        hostTxt = "Up";
                        hostColor = Color.DarkGreen;
                        return;                     // we don't want to keep doing this. exit thread
                    }
                    Thread.Sleep(5000);            // checks are done every 5 sec until online
                }
                catch (Exception)
                {
                    break;
                }
            } // end while
            // thread ends.
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // launch the game client
            string exePath = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\bin64";
            Process.Start(new ProcessStartInfo()
            {
                WorkingDirectory = exePath,
                Verb = "runas",
                FileName = $@"{exePath}\BlackDesert64.exe",
                Arguments = " " + txtUser.Text + "," + txtPass.Text,
                CreateNoWindow = true
            });
            Thread.Sleep(1500);
            Process? process = null;
            while (process == null)
                process = ((IEnumerable<Process>)Process.GetProcessesByName("BlackDesert64")).FirstOrDefault<Process>();
            if (chkLaunchClose.Checked)
                Close();
        }

        private void BDLaunchView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.user = txtUser.Text;
                Properties.Settings.Default.pass = txtPass.Text;
                Properties.Settings.Default.remember = chkRemember.Checked;
                Properties.Settings.Default.silence = silence;
            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.silence = false;
            }
            Properties.Settings.Default.Save();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtServerState.Text = hostTxt;
            txtServerState.ForeColor = hostColor;
            // make the play button visible only of there us a host,
            // the game exe if accessible and there is userid & password provided
            if (hostAvail &&
                exeAvail &&
                !string.IsNullOrEmpty(txtPass.Text) &&
                !string.IsNullOrEmpty(txtUser.Text))
                btnPlay.Visible = true;
            else
                btnPlay.Visible = false; // in case one of the conditions changed
        }
        bool silence = Properties.Settings.Default.silence;
        private void btnSound_Click(object sender, EventArgs e)
        {
            silence = !silence;
            Properties.Settings.Default.silence = silence;
            Properties.Settings.Default.Save();
            if (silence)
                stopPlaying();
            else
                startPlaying();
        }

        private void chkLaunchClose_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
