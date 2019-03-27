namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtAddresBar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewPrivateWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.miDownloadFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.miFindOnThisWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_search = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_search_close = new System.Windows.Forms.Button();
            this.btn_search_next = new System.Windows.Forms.Button();
            this.btn_search_before = new System.Windows.Forms.Button();
            this.tcControlTab = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 27);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(39, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 27);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // txtAddresBar
            // 
            this.txtAddresBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddresBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddresBar.Location = new System.Drawing.Point(221, 6);
            this.txtAddresBar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAddresBar.Name = "txtAddresBar";
            this.txtAddresBar.Size = new System.Drawing.Size(289, 24);
            this.txtAddresBar.TabIndex = 2;
            this.txtAddresBar.TextChanged += new System.EventHandler(this.txtAddresBar_TextChanged);
            this.txtAddresBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_bar_textbos_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(576, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(65, 549);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msMainMenu
            // 
            this.msMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.miHistory,
            this.miNewWindow,
            this.miNewPrivateWindow,
            this.miDownloadFiles,
            this.miOptions,
            this.miFindOnThisWebsite,
            this.miPrint,
            this.miHelp});
            this.msMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(58, 25);
            this.msMainMenu.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // miHistory
            // 
            this.miHistory.Name = "miHistory";
            this.miHistory.Size = new System.Drawing.Size(223, 26);
            this.miHistory.Text = "History";
            // 
            // miNewWindow
            // 
            this.miNewWindow.Name = "miNewWindow";
            this.miNewWindow.Size = new System.Drawing.Size(223, 26);
            this.miNewWindow.Text = "New window";
            // 
            // miNewPrivateWindow
            // 
            this.miNewPrivateWindow.Name = "miNewPrivateWindow";
            this.miNewPrivateWindow.Size = new System.Drawing.Size(223, 26);
            this.miNewPrivateWindow.Text = "New private window";
            // 
            // miDownloadFiles
            // 
            this.miDownloadFiles.Name = "miDownloadFiles";
            this.miDownloadFiles.Size = new System.Drawing.Size(223, 26);
            this.miDownloadFiles.Text = "Download files";
            // 
            // miOptions
            // 
            this.miOptions.Name = "miOptions";
            this.miOptions.Size = new System.Drawing.Size(223, 26);
            this.miOptions.Text = "Options";
            this.miOptions.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // miFindOnThisWebsite
            // 
            this.miFindOnThisWebsite.Name = "miFindOnThisWebsite";
            this.miFindOnThisWebsite.ShowShortcutKeys = false;
            this.miFindOnThisWebsite.Size = new System.Drawing.Size(223, 26);
            this.miFindOnThisWebsite.Text = "Find on this website";
            this.miFindOnThisWebsite.Click += new System.EventHandler(this.findOnThisWebsiteToolStripMenuItem_Click);
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.Size = new System.Drawing.Size(223, 26);
            this.miPrint.Text = "Print";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(223, 26);
            this.miHelp.Text = "Help";
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(515, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(57, 26);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = ">>";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.AllowDrop = true;
            this.btnHome.Location = new System.Drawing.Point(73, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(61, 27);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.home_btn_Click);
            this.btnHome.DragDrop += new System.Windows.Forms.DragEventHandler(this.home_btn_DragDrop);
            this.btnHome.DragEnter += new System.Windows.Forms.DragEventHandler(this.home_btn_DragEnter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(141, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 38);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.txtAddresBar);
            this.panel3.Controls.Add(this.btnEnter);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 38);
            this.panel3.TabIndex = 9;
            // 
            // panel_search
            // 
            this.panel_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_search.Controls.Add(this.textBox_search);
            this.panel_search.Controls.Add(this.btn_search_close);
            this.panel_search.Controls.Add(this.btn_search_next);
            this.panel_search.Controls.Add(this.btn_search_before);
            this.panel_search.Location = new System.Drawing.Point(459, 90);
            this.panel_search.Margin = new System.Windows.Forms.Padding(2);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(171, 29);
            this.panel_search.TabIndex = 12;
            this.panel_search.Visible = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(2, 5);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(110, 20);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // btn_search_close
            // 
            this.btn_search_close.Location = new System.Drawing.Point(153, 2);
            this.btn_search_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search_close.Name = "btn_search_close";
            this.btn_search_close.Size = new System.Drawing.Size(17, 25);
            this.btn_search_close.TabIndex = 3;
            this.btn_search_close.Text = "x";
            this.btn_search_close.UseVisualStyleBackColor = true;
            this.btn_search_close.Click += new System.EventHandler(this.btn_search_close_Click);
            // 
            // btn_search_next
            // 
            this.btn_search_next.Location = new System.Drawing.Point(134, 2);
            this.btn_search_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search_next.Name = "btn_search_next";
            this.btn_search_next.Size = new System.Drawing.Size(17, 25);
            this.btn_search_next.TabIndex = 2;
            this.btn_search_next.Text = ">";
            this.btn_search_next.UseVisualStyleBackColor = true;
            this.btn_search_next.Click += new System.EventHandler(this.btn_search_next_Click);
            // 
            // btn_search_before
            // 
            this.btn_search_before.Location = new System.Drawing.Point(113, 2);
            this.btn_search_before.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search_before.Name = "btn_search_before";
            this.btn_search_before.Size = new System.Drawing.Size(17, 25);
            this.btn_search_before.TabIndex = 1;
            this.btn_search_before.Text = "<";
            this.btn_search_before.UseVisualStyleBackColor = true;
            this.btn_search_before.Click += new System.EventHandler(this.btn_search_before_Click);
            // 
            // tcControlTab
            // 
            this.tcControlTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcControlTab.Location = new System.Drawing.Point(0, 34);
            this.tcControlTab.Name = "tcControlTab";
            this.tcControlTab.SelectedIndex = 0;
            this.tcControlTab.Size = new System.Drawing.Size(641, 515);
            this.tcControlTab.TabIndex = 13;
            this.tcControlTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcControlTab_DrawItem);
            this.tcControlTab.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tcControlTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcControlTab_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 549);
            this.Controls.Add(this.panel_search);
            this.Controls.Add(this.tcControlTab);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAddresBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msMainMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miHistory;
        private System.Windows.Forms.ToolStripMenuItem miNewWindow;
        private System.Windows.Forms.ToolStripMenuItem miNewPrivateWindow;
        private System.Windows.Forms.ToolStripMenuItem miDownloadFiles;
        private System.Windows.Forms.ToolStripMenuItem miOptions;
        private System.Windows.Forms.ToolStripMenuItem miFindOnThisWebsite;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Button btn_search_close;
        private System.Windows.Forms.Button btn_search_next;
        private System.Windows.Forms.Button btn_search_before;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.TabControl tcControlTab;
    }
}

