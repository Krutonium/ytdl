using System.Linq.Expressions;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;
namespace ytdl
{
    public partial class Form1 : Form
    {
        public static readonly string binpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ytdl");
        public static readonly string ytdlp = Path.Combine(binpath, "yt-dlp.exe");
        public static readonly string ffmpeg = Path.Combine(binpath, "ffmpeg.exe");
        public static YoutubeDL dl = new YoutubeDL();
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Task task = new DownloadProgs().GetDeps();
            //Disable Window Resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            await YoutubeDLSharp.Utils.DownloadBinaries(true, binpath);
            await dl.RunUpdate();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            //Check if the deps are downloaded

            string url = tbURL.Text;


            dl.YoutubeDLPath = ytdlp;
            dl.FFmpegPath = ffmpeg;


            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            FolderBrowserDialog bfDialog = new FolderBrowserDialog();
            bfDialog.Description = "Select where to save videos";

            var result = bfDialog.ShowDialog();
            OptionSet sett = new OptionSet();
            if (chkFirefox.Checked)
            {
                sett.CookiesFromBrowser = "firefox";
            }
            else
            {
                sett.CookiesFromBrowser = "chrome";
            }
            string toRemove = "";
            if (chkSponsor.Checked)
            {
                toRemove += "sponsor";
            }
            if (chkIntroOutro.Checked)
            {
                if (toRemove != "")
                {
                    toRemove += ",";
                }
                toRemove += "intro,outro";
            }
            if (chkPreview.Checked)
            {
                if (toRemove != "")
                {
                    toRemove += ",";
                }
                toRemove += "preview";
            }
            if (chkPreview.Checked)
            {
                if (toRemove != "")
                {
                    toRemove += ",";
                }
                toRemove += "preview,interaction";
            }
            if (toRemove != "")
            {
                sett.SponsorblockRemove = toRemove;
            }
            if (result == DialogResult.OK)
            {
                // Get the file path
                string path = bfDialog.SelectedPath;
                if (path == "")
                {
                    MessageBox.Show("Invalid Path!");
                    return;
                }
                dl.OutputFolder = Path.GetDirectoryName(path);
                IProgress<DownloadProgress> progress = new Progress<DownloadProgress>(value =>
                {
                    pbDownload.Value = (int)value.Progress;
                });
        
                if (chkVideo.Checked)
                {
                    if (chkSingle.Checked)
                    {
                        //Update pbProgress from progress
                        await  dl.RunVideoDownload(url, overrideOptions: sett, progress: progress);
                        MessageBox.Show("Download Complete!");
                    } 
                    else if (chkPlaylist.Checked)
                    {

                       await dl.RunVideoPlaylistDownload(url, overrideOptions: sett, progress: progress);
                    }
                } else if (chkAudio.Checked)
                {
                    if (chkSingle.Checked)
                    {
                        await dl.RunAudioDownload(url, overrideOptions: sett, progress: progress);
                    }
                    else if (chkPlaylist.Checked)
                    {
                        await dl.RunAudioPlaylistDownload(url, overrideOptions: sett, progress: progress);
                    }     
                }   
            }
        }
        public void EnableDisableUI(bool enabled)
        {
            tbURL.Enabled = enabled;
            //btnDownload.Enabled = enabled;
            pbDownload.Enabled = enabled;
            chkVideo.Enabled = enabled;
            chkAudio.Enabled = enabled;
            chkFirefox.Enabled = enabled;
            chkChrome.Enabled = enabled;
            if (enabled)
            {
                this.Text = "Youtube Downloader";
            }
            else
            {
                this.Text = "Doing Setup (Downloading Files)";
            }
        }
        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            EnableDisableUI(File.Exists(ffmpeg));
            //If no text in tbURL, disable the download button
            btnDownload.Enabled = tbURL.Text != "";
           // pbDownload.Value;
        }
    }
}
