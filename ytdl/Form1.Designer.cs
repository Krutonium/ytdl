namespace ytdl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbBrowser = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            chkFirefox = new RadioButton();
            chkChrome = new RadioButton();
            tbURL = new TextBox();
            pbDownload = new ProgressBar();
            btnDownload = new Button();
            gbOptions = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            chkAudio = new RadioButton();
            chkVideo = new RadioButton();
            groupBox2 = new GroupBox();
            chkPlaylist = new RadioButton();
            chkSingle = new RadioButton();
            groupBox3 = new GroupBox();
            splitContainer1 = new SplitContainer();
            tmrUpdateUI = new System.Windows.Forms.Timer(components);
            chkSponsor = new CheckBox();
            chkSelfPromo = new CheckBox();
            chkPreview = new CheckBox();
            chkIntroOutro = new CheckBox();
            gbBrowser.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            gbOptions.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // gbBrowser
            // 
            gbBrowser.Controls.Add(flowLayoutPanel1);
            gbBrowser.Dock = DockStyle.Fill;
            gbBrowser.Location = new Point(0, 0);
            gbBrowser.Name = "gbBrowser";
            gbBrowser.Size = new Size(109, 100);
            gbBrowser.TabIndex = 0;
            gbBrowser.TabStop = false;
            gbBrowser.Text = "Cookie Source";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(chkFirefox);
            flowLayoutPanel1.Controls.Add(chkChrome);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.MinimumSize = new Size(50, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(103, 75);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // chkFirefox
            // 
            chkFirefox.AutoSize = true;
            chkFirefox.Checked = true;
            chkFirefox.Location = new Point(3, 3);
            chkFirefox.Name = "chkFirefox";
            chkFirefox.Size = new Size(61, 19);
            chkFirefox.TabIndex = 0;
            chkFirefox.TabStop = true;
            chkFirefox.Text = "Firefox";
            chkFirefox.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            chkChrome.AutoSize = true;
            chkChrome.Location = new Point(3, 28);
            chkChrome.Name = "chkChrome";
            chkChrome.Size = new Size(68, 19);
            chkChrome.TabIndex = 1;
            chkChrome.Text = "Chrome";
            chkChrome.UseVisualStyleBackColor = true;
            // 
            // tbURL
            // 
            tbURL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbURL.Location = new Point(12, 128);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(613, 23);
            tbURL.TabIndex = 1;
            // 
            // pbDownload
            // 
            pbDownload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbDownload.Location = new Point(12, 167);
            pbDownload.Name = "pbDownload";
            pbDownload.Size = new Size(760, 23);
            pbDownload.TabIndex = 2;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDownload.Location = new Point(636, 128);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(133, 23);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // gbOptions
            // 
            gbOptions.Controls.Add(flowLayoutPanel2);
            gbOptions.Dock = DockStyle.Fill;
            gbOptions.Location = new Point(0, 0);
            gbOptions.Name = "gbOptions";
            gbOptions.Size = new Size(647, 100);
            gbOptions.TabIndex = 1;
            gbOptions.TabStop = false;
            gbOptions.Text = "Options";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Controls.Add(groupBox2);
            flowLayoutPanel2.Controls.Add(groupBox3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(641, 78);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAudio);
            groupBox1.Controls.Add(chkVideo);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(77, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Format";
            // 
            // chkAudio
            // 
            chkAudio.AutoSize = true;
            chkAudio.Location = new Point(6, 47);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(57, 19);
            chkAudio.TabIndex = 1;
            chkAudio.TabStop = true;
            chkAudio.Text = "Audio";
            chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkVideo
            // 
            chkVideo.AutoSize = true;
            chkVideo.Checked = true;
            chkVideo.Location = new Point(6, 22);
            chkVideo.Name = "chkVideo";
            chkVideo.Size = new Size(55, 19);
            chkVideo.TabIndex = 0;
            chkVideo.TabStop = true;
            chkVideo.Text = "Video";
            chkVideo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkPlaylist);
            groupBox2.Controls.Add(chkSingle);
            groupBox2.Location = new Point(86, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 72);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Type";
            // 
            // chkPlaylist
            // 
            chkPlaylist.AutoSize = true;
            chkPlaylist.Location = new Point(6, 47);
            chkPlaylist.Name = "chkPlaylist";
            chkPlaylist.Size = new Size(62, 19);
            chkPlaylist.TabIndex = 1;
            chkPlaylist.TabStop = true;
            chkPlaylist.Text = "Playlist";
            chkPlaylist.UseVisualStyleBackColor = true;
            // 
            // chkSingle
            // 
            chkSingle.AutoSize = true;
            chkSingle.Checked = true;
            chkSingle.Location = new Point(6, 22);
            chkSingle.Name = "chkSingle";
            chkSingle.Size = new Size(90, 19);
            chkSingle.TabIndex = 0;
            chkSingle.TabStop = true;
            chkSingle.Text = "Single Video";
            chkSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkIntroOutro);
            groupBox3.Controls.Add(chkPreview);
            groupBox3.Controls.Add(chkSelfPromo);
            groupBox3.Controls.Add(chkSponsor);
            groupBox3.Location = new Point(206, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(216, 72);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "SponsorBlock";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gbOptions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gbBrowser);
            splitContainer1.Panel2MinSize = 50;
            splitContainer1.Size = new Size(760, 100);
            splitContainer1.SplitterDistance = 647;
            splitContainer1.TabIndex = 4;
            // 
            // tmrUpdateUI
            // 
            tmrUpdateUI.Enabled = true;
            tmrUpdateUI.Tick += tmrUpdateUI_Tick;
            // 
            // chkSponsor
            // 
            chkSponsor.AutoSize = true;
            chkSponsor.Location = new Point(6, 22);
            chkSponsor.Name = "chkSponsor";
            chkSponsor.Size = new Size(74, 19);
            chkSponsor.TabIndex = 0;
            chkSponsor.Text = "Sponsors";
            chkSponsor.UseVisualStyleBackColor = true;
            // 
            // chkSelfPromo
            // 
            chkSelfPromo.AutoSize = true;
            chkSelfPromo.Location = new Point(6, 47);
            chkSelfPromo.Name = "chkSelfPromo";
            chkSelfPromo.Size = new Size(105, 19);
            chkSelfPromo.TabIndex = 1;
            chkSelfPromo.Text = "Self Promotion";
            chkSelfPromo.UseVisualStyleBackColor = true;
            // 
            // chkPreview
            // 
            chkPreview.AutoSize = true;
            chkPreview.Location = new Point(113, 22);
            chkPreview.Name = "chkPreview";
            chkPreview.Size = new Size(72, 19);
            chkPreview.TabIndex = 2;
            chkPreview.Text = "Previews";
            chkPreview.UseVisualStyleBackColor = true;
            // 
            // chkIntroOutro
            // 
            chkIntroOutro.AutoSize = true;
            chkIntroOutro.Location = new Point(113, 47);
            chkIntroOutro.Name = "chkIntroOutro";
            chkIntroOutro.Size = new Size(87, 19);
            chkIntroOutro.TabIndex = 3;
            chkIntroOutro.Text = "Intro/Outro";
            chkIntroOutro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 201);
            Controls.Add(splitContainer1);
            Controls.Add(btnDownload);
            Controls.Add(pbDownload);
            Controls.Add(tbURL);
            MaximizeBox = false;
            Name = "Form1";
            Text = "YouTube & Co Downloader";
            Load += Form1_Load;
            gbBrowser.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            gbOptions.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbBrowser;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton chkFirefox;
        private RadioButton chkChrome;
        private TextBox tbURL;
        private ProgressBar pbDownload;
        private Button btnDownload;
        private GroupBox gbOptions;
        private FlowLayoutPanel flowLayoutPanel2;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton chkVideo;
        private RadioButton chkAudio;
        private System.Windows.Forms.Timer tmrUpdateUI;
        private RadioButton chkPlaylist;
        private RadioButton chkSingle;
        private GroupBox groupBox3;
        private CheckBox chkIntroOutro;
        private CheckBox chkPreview;
        private CheckBox chkSelfPromo;
        private CheckBox chkSponsor;
    }
}
