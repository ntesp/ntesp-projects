
namespace ntesp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuItemz = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemViewStill = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpViewReadme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ntespBackground = new System.ComponentModel.BackgroundWorker();
            this.ntespErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.ntespHelpProvider = new System.Windows.Forms.HelpProvider();
            this.ntespProcess = new System.Diagnostics.Process();
            this.StatusItem = new System.Windows.Forms.StatusStrip();
            this.StatusItemProcessBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusItemProcessText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ntespNotifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuItemHelpAboutVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.viewREADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEADMEtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEADMEmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntespErrorHandler)).BeginInit();
            this.StatusItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemz
            // 
            this.MenuItemz.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.MenuItemView,
            this.MenuItemHelp});
            resources.ApplyResources(this.MenuItemz, "MenuItemz");
            this.MenuItemz.Name = "MenuItemz";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.toolStripSeparator2,
            this.MenuItemFileOpen,
            this.MenuItemFileSaveAs,
            this.toolStripSeparator1,
            this.MenuItemFileExit});
            this.MenuItemFile.Name = "MenuItemFile";
            resources.ApplyResources(this.MenuItemFile, "MenuItemFile");
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            resources.ApplyResources(this.MenuItemFileNew, "MenuItemFileNew");
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            resources.ApplyResources(this.MenuItemFileOpen, "MenuItemFileOpen");
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            resources.ApplyResources(this.MenuItemFileSaveAs, "MenuItemFileSaveAs");
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            resources.ApplyResources(this.MenuItemFileExit, "MenuItemFileExit");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditUndo,
            this.MenuItemEditRedo,
            this.toolStripSeparator3,
            this.MenuItemEditCut,
            this.MenuItemEditCopy,
            this.MenuItemEditPaste,
            this.toolStripSeparator4,
            this.MenuItemEditSelectAll});
            this.MenuItemEdit.Name = "MenuItemEdit";
            resources.ApplyResources(this.MenuItemEdit, "MenuItemEdit");
            // 
            // MenuItemEditUndo
            // 
            this.MenuItemEditUndo.Name = "MenuItemEditUndo";
            resources.ApplyResources(this.MenuItemEditUndo, "MenuItemEditUndo");
            // 
            // MenuItemEditRedo
            // 
            this.MenuItemEditRedo.Name = "MenuItemEditRedo";
            resources.ApplyResources(this.MenuItemEditRedo, "MenuItemEditRedo");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // MenuItemEditCut
            // 
            this.MenuItemEditCut.Name = "MenuItemEditCut";
            resources.ApplyResources(this.MenuItemEditCut, "MenuItemEditCut");
            // 
            // MenuItemEditCopy
            // 
            this.MenuItemEditCopy.Name = "MenuItemEditCopy";
            resources.ApplyResources(this.MenuItemEditCopy, "MenuItemEditCopy");
            // 
            // MenuItemEditPaste
            // 
            this.MenuItemEditPaste.Name = "MenuItemEditPaste";
            resources.ApplyResources(this.MenuItemEditPaste, "MenuItemEditPaste");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // MenuItemEditSelectAll
            // 
            this.MenuItemEditSelectAll.Name = "MenuItemEditSelectAll";
            resources.ApplyResources(this.MenuItemEditSelectAll, "MenuItemEditSelectAll");
            // 
            // MenuItemView
            // 
            this.MenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemViewStill});
            this.MenuItemView.Name = "MenuItemView";
            resources.ApplyResources(this.MenuItemView, "MenuItemView");
            // 
            // MenuItemViewStill
            // 
            resources.ApplyResources(this.MenuItemViewStill, "MenuItemViewStill");
            this.MenuItemViewStill.Name = "MenuItemViewStill";
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelpViewReadme,
            this.MenuItemHelpAbout,
            this.viewREADMEToolStripMenuItem});
            this.MenuItemHelp.Name = "MenuItemHelp";
            resources.ApplyResources(this.MenuItemHelp, "MenuItemHelp");
            // 
            // MenuItemHelpViewReadme
            // 
            this.MenuItemHelpViewReadme.Name = "MenuItemHelpViewReadme";
            resources.ApplyResources(this.MenuItemHelpViewReadme, "MenuItemHelpViewReadme");
            this.MenuItemHelpViewReadme.Click += new System.EventHandler(this.MenuItemHelpViewReadme_Click);
            // 
            // MenuItemHelpAbout
            // 
            this.MenuItemHelpAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelpAboutVersion});
            this.MenuItemHelpAbout.Name = "MenuItemHelpAbout";
            resources.ApplyResources(this.MenuItemHelpAbout, "MenuItemHelpAbout");
            this.MenuItemHelpAbout.Click += new System.EventHandler(this.MenuItemHelpAbout_Click);
            // 
            // ntespErrorHandler
            // 
            this.ntespErrorHandler.ContainerControl = this;
            // 
            // ntespHelpProvider
            // 
            resources.ApplyResources(this.ntespHelpProvider, "ntespHelpProvider");
            // 
            // ntespProcess
            // 
            this.ntespProcess.StartInfo.Domain = "";
            this.ntespProcess.StartInfo.ErrorDialog = true;
            this.ntespProcess.StartInfo.LoadUserProfile = false;
            this.ntespProcess.StartInfo.Password = null;
            this.ntespProcess.StartInfo.StandardErrorEncoding = null;
            this.ntespProcess.StartInfo.StandardOutputEncoding = null;
            this.ntespProcess.StartInfo.UserName = "";
            this.ntespProcess.SynchronizingObject = this;
            // 
            // StatusItem
            // 
            this.ntespHelpProvider.SetHelpKeyword(this.StatusItem, resources.GetString("StatusItem.HelpKeyword"));
            this.ntespHelpProvider.SetHelpString(this.StatusItem, resources.GetString("StatusItem.HelpString"));
            this.StatusItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusItemProcessText,
            this.StatusItemProcessBar});
            resources.ApplyResources(this.StatusItem, "StatusItem");
            this.StatusItem.Name = "StatusItem";
            this.ntespHelpProvider.SetShowHelp(this.StatusItem, ((bool)(resources.GetObject("StatusItem.ShowHelp"))));
            // 
            // StatusItemProcessBar
            // 
            this.StatusItemProcessBar.Name = "StatusItemProcessBar";
            resources.ApplyResources(this.StatusItemProcessBar, "StatusItemProcessBar");
            this.StatusItemProcessBar.Step = 4;
            this.StatusItemProcessBar.Value = 50;
            // 
            // StatusItemProcessText
            // 
            this.StatusItemProcessText.Name = "StatusItemProcessText";
            resources.ApplyResources(this.StatusItemProcessText, "StatusItemProcessText");
            // 
            // ntespNotifier
            // 
            this.ntespNotifier.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.ntespNotifier, "ntespNotifier");
            // 
            // MenuItemHelpAboutVersion
            // 
            this.MenuItemHelpAboutVersion.Name = "MenuItemHelpAboutVersion";
            resources.ApplyResources(this.MenuItemHelpAboutVersion, "MenuItemHelpAboutVersion");
            this.MenuItemHelpAboutVersion.Click += new System.EventHandler(this.MenuItemHelpAboutVersion_Click);
            // 
            // viewREADMEToolStripMenuItem
            // 
            this.viewREADMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEADMEtxtToolStripMenuItem,
            this.rEADMEmdToolStripMenuItem});
            this.viewREADMEToolStripMenuItem.Name = "viewREADMEToolStripMenuItem";
            resources.ApplyResources(this.viewREADMEToolStripMenuItem, "viewREADMEToolStripMenuItem");
            // 
            // rEADMEtxtToolStripMenuItem
            // 
            this.rEADMEtxtToolStripMenuItem.Name = "rEADMEtxtToolStripMenuItem";
            resources.ApplyResources(this.rEADMEtxtToolStripMenuItem, "rEADMEtxtToolStripMenuItem");
            // 
            // rEADMEmdToolStripMenuItem
            // 
            this.rEADMEmdToolStripMenuItem.Name = "rEADMEmdToolStripMenuItem";
            resources.ApplyResources(this.rEADMEmdToolStripMenuItem, "rEADMEmdToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusItem);
            this.Controls.Add(this.MenuItemz);
            this.MainMenuStrip = this.MenuItemz;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuItemz.ResumeLayout(false);
            this.MenuItemz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntespErrorHandler)).EndInit();
            this.StatusItem.ResumeLayout(false);
            this.StatusItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItemz;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem MenuItemView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemViewStill;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpViewReadme;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpAbout;
        private System.ComponentModel.BackgroundWorker ntespBackground;
        private System.Windows.Forms.ErrorProvider ntespErrorHandler;
        private System.Windows.Forms.StatusStrip StatusItem;
        private System.Windows.Forms.HelpProvider ntespHelpProvider;
        private System.Windows.Forms.ToolStripStatusLabel StatusItemProcessText;
        private System.Windows.Forms.ToolStripProgressBar StatusItemProcessBar;
        private System.Diagnostics.Process ntespProcess;
        private System.Windows.Forms.NotifyIcon ntespNotifier;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpAboutVersion;
        private System.Windows.Forms.ToolStripMenuItem viewREADMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEADMEtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEADMEmdToolStripMenuItem;
    }
}

