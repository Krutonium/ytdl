using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SharpCompress;
using SharpCompress.Archives;
using SharpCompress.Common;

namespace ytdl
{
    public class DownloadProgs
    {

        public async Task DownloadFile(string url, string path)
        {
            HttpClient client = new HttpClient();
            using (var response = await client.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    using (var fileStream = File.Create(path))
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                }
            }
        }
        public static void unpack(string archivepath, string extractpath)
        {
            // ZipFile.ExtractToDirectory(archivepath, extractpath);
            //SharpCompress.Archives.SevenZip.SevenZipArchive.Open(archivepath).ExtractAllEntries();

            // Extract the 7z file to the extractpath
            var archive = SharpCompress.Archives.SevenZip.SevenZipArchive.Open(archivepath);
            foreach (var entry in archive.Entries)
            {
                if (!entry.IsDirectory)
                {
                    entry.WriteToDirectory(extractpath, new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
                }
            }
        }
        public async Task GetDeps()
        {

            string depsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ytdl");

            //Check if the binaries are more than 1 week old
            // If they are, download them again
            // If they are not, use them
            // If they don't exist, download them
            if (Directory.Exists(depsFolder))
            {
                //Get the age of yt-dlp.exe
                string ytDlpPath = Path.Combine(depsFolder, "yt-dlp.exe");
                if (File.Exists(ytDlpPath))
                {
                    DateTime ytDlpCreationTime = File.GetCreationTime(ytDlpPath);
                    DateTime now = DateTime.Now;
                    if (now - ytDlpCreationTime < TimeSpan.FromDays(7))
                    {
                        return;
                    }
                }
            }

            string ytDlpUrl = "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe";
            string ffmpegUrl = "https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.7z";

            // Folder for deps in appdata
            if(Directory.Exists(depsFolder))
            {
                Directory.Delete(depsFolder, true);
            }
            Directory.CreateDirectory(depsFolder);
            

            

            string savePathtmp = (Path.Combine(Path.GetTempPath(), "ytdltmp"));
            string savePathffmpeg = Path.Combine(savePathtmp, "ffmpeg.7z");
            string savePathytdlp = Path.Combine(savePathtmp, "yt-dlp.exe");

            if (!Directory.Exists(savePathtmp))
            {
                Directory.CreateDirectory(savePathtmp);
            }
            else
            {
                Directory.Delete(savePathtmp, true);
                Directory.CreateDirectory(savePathtmp);
            }


            // Create new instances for each download
            DownloadProgs ytDlpDownloader = new DownloadProgs();
            DownloadProgs ffmpegDownloader = new DownloadProgs();

            Task ytDlpDownloadTask = ytDlpDownloader.DownloadFile(ytDlpUrl, savePathytdlp);
            Task ffmpegDownloadTask = ffmpegDownloader.DownloadFile(ffmpegUrl, savePathffmpeg);

            // Wait for both tasks to complete
            await Task.WhenAll(ytDlpDownloadTask, ffmpegDownloadTask);

            // Assuming unpacking is synchronous and needs to be done before copying
            unpack(savePathffmpeg, savePathtmp);

            // Perform file copy operations synchronously after downloads and any necessary unpacking
            string ffmpegExePath = Directory.GetFiles(savePathtmp, "ffmpeg.exe", SearchOption.AllDirectories).FirstOrDefault();
            if (ffmpegExePath != null)
            {
                File.Copy(ffmpegExePath, Path.Combine(depsFolder, "ffmpeg.exe"), overwrite: true);
            }
            string ffprobeExePath = Directory.GetFiles(savePathtmp, "ffprobe.exe", SearchOption.AllDirectories).FirstOrDefault();
            if (ffmpegExePath != null)
            {
                File.Copy(ffmpegExePath, Path.Combine(depsFolder, "ffprobe.exe"), overwrite: true);
            }
            File.Copy(Path.Combine(savePathtmp, "yt-dlp.exe"), Path.Combine(depsFolder, "yt-dlp.exe"), overwrite: true);
        }
    }
}
