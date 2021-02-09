using osu__Replay_Resampler.Controls;

namespace osu__Replay_Resampler
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.pnlMenuBar = new System.Windows.Forms.Panel();
      this.pctrbxExit = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.videoView = new LibVLCSharp.WinForms.VideoView();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtInputVideo = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.prprtyVideo = new System.Windows.Forms.PropertyGrid();
      this.label5 = new System.Windows.Forms.Label();
      this.pnlTmix = new System.Windows.Forms.Panel();
      this.rdbtnAscending = new System.Windows.Forms.RadioButton();
      this.rdbtnEqual = new System.Windows.Forms.RadioButton();
      this.rdbtnDescending = new System.Windows.Forms.RadioButton();
      this.label6 = new System.Windows.Forms.Label();
      this.txtOutputVideo = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.pnlExportInformations = new System.Windows.Forms.Panel();
      this.pctrbxHideExportInformations = new System.Windows.Forms.PictureBox();
      this.lblEstimatedTimeLeft = new System.Windows.Forms.Label();
      this.lblRenderTime = new System.Windows.Forms.Label();
      this.lblEstimatedFileSize = new System.Windows.Forms.Label();
      this.lblCurrentFileSize = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.pnlTblend = new System.Windows.Forms.Panel();
      this.lbl = new System.Windows.Forms.Label();
      this.trckBrOpacity = new System.Windows.Forms.TrackBar();
      this.lblOpacity = new System.Windows.Forms.Label();
      this.lblFrameSkip = new System.Windows.Forms.Label();
      this.trckBrFrameSkip = new System.Windows.Forms.TrackBar();
      this.label10 = new System.Windows.Forms.Label();
      this.prgrsExport = new osu__Replay_Resampler.Controls.CustomProgressBar();
      this.btnExport = new osu__Replay_Resampler.Controls.CustomButton();
      this.btnBrowseOutput = new osu__Replay_Resampler.Controls.CustomButton();
      this.btnTblend = new osu__Replay_Resampler.Controls.CustomButton();
      this.btnTmix = new osu__Replay_Resampler.Controls.CustomButton();
      this.title3 = new osu__Replay_Resampler.Controls.Title();
      this.title2 = new osu__Replay_Resampler.Controls.Title();
      this.btnBrowseInput = new osu__Replay_Resampler.Controls.CustomButton();
      this.title1 = new osu__Replay_Resampler.Controls.Title();
      this.btnTblendReset = new osu__Replay_Resampler.Controls.CustomButton();
      this.btnTmixReset = new osu__Replay_Resampler.Controls.CustomButton();
      this.pnlMenuBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pctrbxExit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
      this.pnlTmix.SuspendLayout();
      this.pnlExportInformations.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pctrbxHideExportInformations)).BeginInit();
      this.pnlTblend.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trckBrOpacity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trckBrFrameSkip)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1181, 1);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
      this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel2.Location = new System.Drawing.Point(1180, 1);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1, 564);
      this.panel2.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 1);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1, 564);
      this.panel3.TabIndex = 2;
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
      this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel4.Location = new System.Drawing.Point(1, 564);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(1179, 1);
      this.panel4.TabIndex = 3;
      // 
      // pnlMenuBar
      // 
      this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
      this.pnlMenuBar.Controls.Add(this.pctrbxExit);
      this.pnlMenuBar.Controls.Add(this.label1);
      this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlMenuBar.Location = new System.Drawing.Point(1, 1);
      this.pnlMenuBar.Name = "pnlMenuBar";
      this.pnlMenuBar.Size = new System.Drawing.Size(1179, 50);
      this.pnlMenuBar.TabIndex = 4;
      this.pnlMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
      // 
      // pctrbxExit
      // 
      this.pctrbxExit.Image = global::osu__Replay_Resampler.Properties.Resources.exit;
      this.pctrbxExit.Location = new System.Drawing.Point(19, 19);
      this.pctrbxExit.Name = "pctrbxExit";
      this.pctrbxExit.Size = new System.Drawing.Size(12, 12);
      this.pctrbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pctrbxExit.TabIndex = 6;
      this.pctrbxExit.TabStop = false;
      this.pctrbxExit.Click += new System.EventHandler(this.pctrbxExit_Click);
      this.pctrbxExit.MouseEnter += new System.EventHandler(this.pctrbxExit_MouseEnter);
      this.pctrbxExit.MouseLeave += new System.EventHandler(this.pctrbxExit_MouseLeave);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(1179, 50);
      this.label1.TabIndex = 0;
      this.label1.Text = "osu! Replay Resampler";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
      // 
      // panel6
      // 
      this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
      this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel6.Location = new System.Drawing.Point(1, 51);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(1179, 1);
      this.panel6.TabIndex = 5;
      // 
      // videoView
      // 
      this.videoView.BackColor = System.Drawing.Color.Black;
      this.videoView.Location = new System.Drawing.Point(529, 72);
      this.videoView.MediaPlayer = null;
      this.videoView.Name = "videoView";
      this.videoView.Size = new System.Drawing.Size(640, 360);
      this.videoView.TabIndex = 7;
      this.videoView.Text = "videoView1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.label2.Location = new System.Drawing.Point(17, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 15);
      this.label2.TabIndex = 8;
      this.label2.Text = "Input Video";
      // 
      // label3
      // 
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(61)))));
      this.label3.Location = new System.Drawing.Point(802, 53);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(368, 23);
      this.label3.TabIndex = 9;
      this.label3.Text = "Glitches that occur in the preview may not be visible in the exported video";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtInputVideo
      // 
      this.txtInputVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.txtInputVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtInputVideo.ForeColor = System.Drawing.Color.White;
      this.txtInputVideo.Location = new System.Drawing.Point(91, 86);
      this.txtInputVideo.Name = "txtInputVideo";
      this.txtInputVideo.ReadOnly = true;
      this.txtInputVideo.Size = new System.Drawing.Size(333, 20);
      this.txtInputVideo.TabIndex = 10;
      this.txtInputVideo.TextChanged += new System.EventHandler(this.txtInputVideo_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.label4.Location = new System.Drawing.Point(88, 109);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(305, 15);
      this.label4.TabIndex = 12;
      this.label4.Text = "Supported file formats are .mp4, .avi, .mov, .mkv and .flv";
      // 
      // prprtyVideo
      // 
      this.prprtyVideo.CategoryForeColor = System.Drawing.Color.White;
      this.prprtyVideo.CategorySplitterColor = System.Drawing.Color.White;
      this.prprtyVideo.CommandsForeColor = System.Drawing.Color.White;
      this.prprtyVideo.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.prprtyVideo.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
      this.prprtyVideo.HelpVisible = false;
      this.prprtyVideo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
      this.prprtyVideo.Location = new System.Drawing.Point(20, 127);
      this.prprtyVideo.Name = "prprtyVideo";
      this.prprtyVideo.PropertySort = System.Windows.Forms.PropertySort.Categorized;
      this.prprtyVideo.SelectedItemWithFocusForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
      this.prprtyVideo.Size = new System.Drawing.Size(500, 123);
      this.prprtyVideo.TabIndex = 15;
      this.prprtyVideo.ToolbarVisible = false;
      this.prprtyVideo.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
      this.prprtyVideo.ViewForeColor = System.Drawing.Color.White;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.label5.Location = new System.Drawing.Point(12, 319);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(511, 67);
      this.label5.TabIndex = 18;
      this.label5.Text = resources.GetString("label5.Text");
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnlTmix
      // 
      this.pnlTmix.Controls.Add(this.btnTmixReset);
      this.pnlTmix.Controls.Add(this.rdbtnAscending);
      this.pnlTmix.Controls.Add(this.rdbtnEqual);
      this.pnlTmix.Controls.Add(this.rdbtnDescending);
      this.pnlTmix.Controls.Add(this.label6);
      this.pnlTmix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.pnlTmix.Location = new System.Drawing.Point(12, 384);
      this.pnlTmix.Name = "pnlTmix";
      this.pnlTmix.Size = new System.Drawing.Size(508, 181);
      this.pnlTmix.TabIndex = 19;
      // 
      // rdbtnAscending
      // 
      this.rdbtnAscending.AutoSize = true;
      this.rdbtnAscending.Location = new System.Drawing.Point(8, 72);
      this.rdbtnAscending.Name = "rdbtnAscending";
      this.rdbtnAscending.Size = new System.Drawing.Size(75, 17);
      this.rdbtnAscending.TabIndex = 31;
      this.rdbtnAscending.Text = "Ascending";
      this.rdbtnAscending.UseVisualStyleBackColor = true;
      // 
      // rdbtnEqual
      // 
      this.rdbtnEqual.AutoSize = true;
      this.rdbtnEqual.Location = new System.Drawing.Point(8, 49);
      this.rdbtnEqual.Name = "rdbtnEqual";
      this.rdbtnEqual.Size = new System.Drawing.Size(52, 17);
      this.rdbtnEqual.TabIndex = 30;
      this.rdbtnEqual.Text = "Equal";
      this.rdbtnEqual.UseVisualStyleBackColor = true;
      // 
      // rdbtnDescending
      // 
      this.rdbtnDescending.AutoSize = true;
      this.rdbtnDescending.Checked = true;
      this.rdbtnDescending.Location = new System.Drawing.Point(8, 27);
      this.rdbtnDescending.Name = "rdbtnDescending";
      this.rdbtnDescending.Size = new System.Drawing.Size(82, 17);
      this.rdbtnDescending.TabIndex = 29;
      this.rdbtnDescending.TabStop = true;
      this.rdbtnDescending.Text = "Descending";
      this.rdbtnDescending.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(5, 9);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(78, 15);
      this.label6.TabIndex = 0;
      this.label6.Text = "Weight Order";
      // 
      // txtOutputVideo
      // 
      this.txtOutputVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.txtOutputVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtOutputVideo.ForeColor = System.Drawing.Color.White;
      this.txtOutputVideo.Location = new System.Drawing.Point(614, 466);
      this.txtOutputVideo.Name = "txtOutputVideo";
      this.txtOutputVideo.ReadOnly = true;
      this.txtOutputVideo.Size = new System.Drawing.Size(459, 20);
      this.txtOutputVideo.TabIndex = 21;
      this.txtOutputVideo.TextChanged += new System.EventHandler(this.txtOutputVideo_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.label7.Location = new System.Drawing.Point(530, 468);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(78, 15);
      this.label7.TabIndex = 20;
      this.label7.Text = "Output Video";
      // 
      // pnlExportInformations
      // 
      this.pnlExportInformations.Controls.Add(this.pctrbxHideExportInformations);
      this.pnlExportInformations.Controls.Add(this.lblEstimatedTimeLeft);
      this.pnlExportInformations.Controls.Add(this.lblRenderTime);
      this.pnlExportInformations.Controls.Add(this.lblEstimatedFileSize);
      this.pnlExportInformations.Controls.Add(this.lblCurrentFileSize);
      this.pnlExportInformations.Controls.Add(this.prgrsExport);
      this.pnlExportInformations.Location = new System.Drawing.Point(533, 492);
      this.pnlExportInformations.Name = "pnlExportInformations";
      this.pnlExportInformations.Size = new System.Drawing.Size(530, 73);
      this.pnlExportInformations.TabIndex = 28;
      this.pnlExportInformations.Visible = false;
      // 
      // pctrbxHideExportInformations
      // 
      this.pctrbxHideExportInformations.Image = global::osu__Replay_Resampler.Properties.Resources.exit;
      this.pctrbxHideExportInformations.Location = new System.Drawing.Point(515, 29);
      this.pctrbxHideExportInformations.Name = "pctrbxHideExportInformations";
      this.pctrbxHideExportInformations.Size = new System.Drawing.Size(12, 12);
      this.pctrbxHideExportInformations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pctrbxHideExportInformations.TabIndex = 7;
      this.pctrbxHideExportInformations.TabStop = false;
      this.pctrbxHideExportInformations.Click += new System.EventHandler(this.pctrbxHideExportInformations_Click);
      this.pctrbxHideExportInformations.MouseEnter += new System.EventHandler(this.pctrbxHideExportInformations_MouseEnter);
      this.pctrbxHideExportInformations.MouseLeave += new System.EventHandler(this.pctrbxHideExportInformations_MouseLeave);
      // 
      // lblEstimatedTimeLeft
      // 
      this.lblEstimatedTimeLeft.AutoSize = true;
      this.lblEstimatedTimeLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblEstimatedTimeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.lblEstimatedTimeLeft.Location = new System.Drawing.Point(172, 26);
      this.lblEstimatedTimeLeft.Name = "lblEstimatedTimeLeft";
      this.lblEstimatedTimeLeft.Size = new System.Drawing.Size(122, 15);
      this.lblEstimatedTimeLeft.TabIndex = 32;
      this.lblEstimatedTimeLeft.Text = "Estimated Time Left: -";
      // 
      // lblRenderTime
      // 
      this.lblRenderTime.AutoSize = true;
      this.lblRenderTime.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblRenderTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.lblRenderTime.Location = new System.Drawing.Point(210, 9);
      this.lblRenderTime.Name = "lblRenderTime";
      this.lblRenderTime.Size = new System.Drawing.Size(84, 15);
      this.lblRenderTime.TabIndex = 31;
      this.lblRenderTime.Text = "Render Time: -";
      // 
      // lblEstimatedFileSize
      // 
      this.lblEstimatedFileSize.AutoSize = true;
      this.lblEstimatedFileSize.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblEstimatedFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.lblEstimatedFileSize.Location = new System.Drawing.Point(3, 26);
      this.lblEstimatedFileSize.Name = "lblEstimatedFileSize";
      this.lblEstimatedFileSize.Size = new System.Drawing.Size(114, 15);
      this.lblEstimatedFileSize.TabIndex = 30;
      this.lblEstimatedFileSize.Text = "Estimated File Size: -";
      // 
      // lblCurrentFileSize
      // 
      this.lblCurrentFileSize.AutoSize = true;
      this.lblCurrentFileSize.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblCurrentFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.lblCurrentFileSize.Location = new System.Drawing.Point(15, 9);
      this.lblCurrentFileSize.Name = "lblCurrentFileSize";
      this.lblCurrentFileSize.Size = new System.Drawing.Size(102, 15);
      this.lblCurrentFileSize.TabIndex = 29;
      this.lblCurrentFileSize.Text = "Current File Size: -";
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(749, 237);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(200, 30);
      this.label8.TabIndex = 29;
      this.label8.Text = "Not implemented yet.";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlTblend
      // 
      this.pnlTblend.Controls.Add(this.btnTblendReset);
      this.pnlTblend.Controls.Add(this.lblFrameSkip);
      this.pnlTblend.Controls.Add(this.trckBrFrameSkip);
      this.pnlTblend.Controls.Add(this.label10);
      this.pnlTblend.Controls.Add(this.lblOpacity);
      this.pnlTblend.Controls.Add(this.trckBrOpacity);
      this.pnlTblend.Controls.Add(this.lbl);
      this.pnlTblend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.pnlTblend.Location = new System.Drawing.Point(12, 384);
      this.pnlTblend.Name = "pnlTblend";
      this.pnlTblend.Size = new System.Drawing.Size(508, 181);
      this.pnlTblend.TabIndex = 32;
      this.pnlTblend.Visible = false;
      // 
      // lbl
      // 
      this.lbl.AutoSize = true;
      this.lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl.Location = new System.Drawing.Point(5, 9);
      this.lbl.Name = "lbl";
      this.lbl.Size = new System.Drawing.Size(48, 15);
      this.lbl.TabIndex = 0;
      this.lbl.Text = "Opacity";
      // 
      // trckBrOpacity
      // 
      this.trckBrOpacity.Location = new System.Drawing.Point(52, 11);
      this.trckBrOpacity.Maximum = 100;
      this.trckBrOpacity.Minimum = 1;
      this.trckBrOpacity.Name = "trckBrOpacity";
      this.trckBrOpacity.Size = new System.Drawing.Size(453, 45);
      this.trckBrOpacity.TabIndex = 1;
      this.trckBrOpacity.Value = 90;
      this.trckBrOpacity.Scroll += new System.EventHandler(this.trckBrOpacity_Scroll);
      // 
      // lblOpacity
      // 
      this.lblOpacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOpacity.Location = new System.Drawing.Point(8, 28);
      this.lblOpacity.Name = "lblOpacity";
      this.lblOpacity.Size = new System.Drawing.Size(45, 15);
      this.lblOpacity.TabIndex = 2;
      this.lblOpacity.Text = "(90)";
      this.lblOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblFrameSkip
      // 
      this.lblFrameSkip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFrameSkip.Location = new System.Drawing.Point(8, 77);
      this.lblFrameSkip.Name = "lblFrameSkip";
      this.lblFrameSkip.Size = new System.Drawing.Size(45, 15);
      this.lblFrameSkip.TabIndex = 5;
      this.lblFrameSkip.Text = "(2)";
      this.lblFrameSkip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // trckBrFrameSkip
      // 
      this.trckBrFrameSkip.Location = new System.Drawing.Point(76, 60);
      this.trckBrFrameSkip.Minimum = 1;
      this.trckBrFrameSkip.Name = "trckBrFrameSkip";
      this.trckBrFrameSkip.Size = new System.Drawing.Size(429, 45);
      this.trckBrFrameSkip.TabIndex = 4;
      this.trckBrFrameSkip.Value = 2;
      this.trckBrFrameSkip.Scroll += new System.EventHandler(this.trckBrFrameSkip_Scroll);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(5, 58);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(65, 15);
      this.label10.TabIndex = 3;
      this.label10.Text = "Frame Skip";
      // 
      // prgrsExport
      // 
      this.prgrsExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
      this.prgrsExport.ForeColor = System.Drawing.Color.White;
      this.prgrsExport.Location = new System.Drawing.Point(3, 44);
      this.prgrsExport.Name = "prgrsExport";
      this.prgrsExport.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(61)))));
      this.prgrsExport.ShowDoneLabel = true;
      this.prgrsExport.ShowPercentLabel = true;
      this.prgrsExport.Size = new System.Drawing.Size(524, 20);
      this.prgrsExport.TabIndex = 28;
      // 
      // btnExport
      // 
      this.btnExport.Location = new System.Drawing.Point(1066, 529);
      this.btnExport.Name = "btnExport";
      this.btnExport.Selected = false;
      this.btnExport.Size = new System.Drawing.Size(100, 27);
      this.btnExport.TabIndex = 24;
      this.btnExport.Text = "Export";
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // btnBrowseOutput
      // 
      this.btnBrowseOutput.Location = new System.Drawing.Point(1079, 462);
      this.btnBrowseOutput.Name = "btnBrowseOutput";
      this.btnBrowseOutput.Selected = false;
      this.btnBrowseOutput.Size = new System.Drawing.Size(90, 27);
      this.btnBrowseOutput.TabIndex = 22;
      this.btnBrowseOutput.Text = "Browse..";
      this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
      // 
      // btnTblend
      // 
      this.btnTblend.Location = new System.Drawing.Point(283, 288);
      this.btnTblend.Name = "btnTblend";
      this.btnTblend.Selected = false;
      this.btnTblend.Size = new System.Drawing.Size(100, 25);
      this.btnTblend.TabIndex = 17;
      this.btnTblend.Text = "TBLEND";
      this.btnTblend.Click += new System.EventHandler(this.btnTblend_Click);
      // 
      // btnTmix
      // 
      this.btnTmix.Location = new System.Drawing.Point(148, 288);
      this.btnTmix.Name = "btnTmix";
      this.btnTmix.Selected = true;
      this.btnTmix.Size = new System.Drawing.Size(100, 25);
      this.btnTmix.TabIndex = 16;
      this.btnTmix.Text = "TMIX";
      this.btnTmix.Click += new System.EventHandler(this.btnTmix_Click);
      // 
      // title3
      // 
      this.title3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.title3.Location = new System.Drawing.Point(529, 438);
      this.title3.Name = "title3";
      this.title3.Size = new System.Drawing.Size(640, 26);
      this.title3.TabIndex = 14;
      this.title3.Text = "Export";
      // 
      // title2
      // 
      this.title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.title2.Location = new System.Drawing.Point(9, 256);
      this.title2.Name = "title2";
      this.title2.Size = new System.Drawing.Size(511, 26);
      this.title2.TabIndex = 13;
      this.title2.Text = "Resampling";
      // 
      // btnBrowseInput
      // 
      this.btnBrowseInput.Location = new System.Drawing.Point(430, 82);
      this.btnBrowseInput.Name = "btnBrowseInput";
      this.btnBrowseInput.Selected = false;
      this.btnBrowseInput.Size = new System.Drawing.Size(90, 27);
      this.btnBrowseInput.TabIndex = 11;
      this.btnBrowseInput.Text = "Browse..";
      this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
      // 
      // title1
      // 
      this.title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
      this.title1.Location = new System.Drawing.Point(9, 58);
      this.title1.Name = "title1";
      this.title1.Size = new System.Drawing.Size(511, 26);
      this.title1.TabIndex = 6;
      this.title1.Text = "Video Input";
      // 
      // btnTblendReset
      // 
      this.btnTblendReset.Location = new System.Drawing.Point(3, 147);
      this.btnTblendReset.Name = "btnTblendReset";
      this.btnTblendReset.Selected = false;
      this.btnTblendReset.Size = new System.Drawing.Size(108, 25);
      this.btnTblendReset.TabIndex = 33;
      this.btnTblendReset.Text = "Reset to defaults";
      this.btnTblendReset.Click += new System.EventHandler(this.btnTblendReset_Click);
      // 
      // btnTmixReset
      // 
      this.btnTmixReset.Location = new System.Drawing.Point(3, 147);
      this.btnTmixReset.Name = "btnTmixReset";
      this.btnTmixReset.Selected = false;
      this.btnTmixReset.Size = new System.Drawing.Size(108, 25);
      this.btnTmixReset.TabIndex = 34;
      this.btnTmixReset.Text = "Reset to defaults";
      this.btnTmixReset.Click += new System.EventHandler(this.btnTmixReset_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
      this.ClientSize = new System.Drawing.Size(1181, 565);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.pnlExportInformations);
      this.Controls.Add(this.btnExport);
      this.Controls.Add(this.btnBrowseOutput);
      this.Controls.Add(this.txtOutputVideo);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnTblend);
      this.Controls.Add(this.btnTmix);
      this.Controls.Add(this.prprtyVideo);
      this.Controls.Add(this.title3);
      this.Controls.Add(this.title2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnBrowseInput);
      this.Controls.Add(this.txtInputVideo);
      this.Controls.Add(this.videoView);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.title1);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.pnlMenuBar);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.pnlTmix);
      this.Controls.Add(this.pnlTblend);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "osu! Replay Resampler";
      this.pnlMenuBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pctrbxExit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
      this.pnlTmix.ResumeLayout(false);
      this.pnlTmix.PerformLayout();
      this.pnlExportInformations.ResumeLayout(false);
      this.pnlExportInformations.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pctrbxHideExportInformations)).EndInit();
      this.pnlTblend.ResumeLayout(false);
      this.pnlTblend.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trckBrOpacity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trckBrFrameSkip)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel pnlMenuBar;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pctrbxExit;
    private Controls.Title title1;
    private LibVLCSharp.WinForms.VideoView videoView;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtInputVideo;
    private Controls.CustomButton btnBrowseInput;
    private System.Windows.Forms.Label label4;
    private Controls.Title title2;
    private Controls.Title title3;
    private System.Windows.Forms.PropertyGrid prprtyVideo;
    private Controls.CustomButton btnTmix;
    private Controls.CustomButton btnTblend;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel pnlTmix;
    private Controls.CustomButton btnBrowseOutput;
    private System.Windows.Forms.TextBox txtOutputVideo;
    private System.Windows.Forms.Label label7;
    private Controls.CustomButton btnExport;
    private System.Windows.Forms.Panel pnlExportInformations;
    private System.Windows.Forms.Label lblEstimatedFileSize;
    private System.Windows.Forms.Label lblCurrentFileSize;
    private Controls.CustomProgressBar prgrsExport;
    private System.Windows.Forms.Label lblRenderTime;
    private System.Windows.Forms.Label lblEstimatedTimeLeft;
    private System.Windows.Forms.PictureBox pctrbxHideExportInformations;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.RadioButton rdbtnDescending;
    private System.Windows.Forms.RadioButton rdbtnEqual;
    private System.Windows.Forms.RadioButton rdbtnAscending;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Panel pnlTblend;
    private System.Windows.Forms.Label lbl;
    private System.Windows.Forms.TrackBar trckBrOpacity;
    private System.Windows.Forms.Label lblOpacity;
    private System.Windows.Forms.Label lblFrameSkip;
    private System.Windows.Forms.TrackBar trckBrFrameSkip;
    private System.Windows.Forms.Label label10;
    private Controls.CustomButton btnTblendReset;
    private Controls.CustomButton btnTmixReset;
  }
}

