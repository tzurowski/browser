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
            this.back_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.address_bar_textbos = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPrivateWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findOnThisWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.website_panel = new System.Windows.Forms.Panel();
            this.panel_search = new System.Windows.Forms.Panel();
            this.btn_search_close = new System.Windows.Forms.Button();
            this.btn_search_next = new System.Windows.Forms.Button();
            this.btn_search_before = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.website_panel.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(8, 6);
            this.back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(39, 34);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "<-";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(52, 6);
            this.next_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(39, 34);
            this.next_btn.TabIndex = 1;
            this.next_btn.Text = "->";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // address_bar_textbos
            // 
            this.address_bar_textbos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address_bar_textbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.address_bar_textbos.Location = new System.Drawing.Point(295, 7);
            this.address_bar_textbos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_bar_textbos.Name = "address_bar_textbos";
            this.address_bar_textbos.Size = new System.Drawing.Size(384, 29);
            this.address_bar_textbos.TabIndex = 2;
            this.address_bar_textbos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_bar_textbos_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(777, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(78, 820);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.historyToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.newPrivateWindowToolStripMenuItem,
            this.downloadFilesToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.findOnThisWebsiteToolStripMenuItem,
            this.printToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.bookmarksToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.newWindowToolStripMenuItem.Text = "New window";
            // 
            // newPrivateWindowToolStripMenuItem
            // 
            this.newPrivateWindowToolStripMenuItem.Name = "newPrivateWindowToolStripMenuItem";
            this.newPrivateWindowToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.newPrivateWindowToolStripMenuItem.Text = "New private window";
            // 
            // downloadFilesToolStripMenuItem
            // 
            this.downloadFilesToolStripMenuItem.Name = "downloadFilesToolStripMenuItem";
            this.downloadFilesToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.downloadFilesToolStripMenuItem.Text = "Download files";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // findOnThisWebsiteToolStripMenuItem
            // 
            this.findOnThisWebsiteToolStripMenuItem.Name = "findOnThisWebsiteToolStripMenuItem";
            this.findOnThisWebsiteToolStripMenuItem.ShowShortcutKeys = false;
            this.findOnThisWebsiteToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.findOnThisWebsiteToolStripMenuItem.Text = "Find on this website";
            this.findOnThisWebsiteToolStripMenuItem.Click += new System.EventHandler(this.findOnThisWebsiteToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(686, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home_btn
            // 
            this.home_btn.AllowDrop = true;
            this.home_btn.Location = new System.Drawing.Point(98, 7);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(82, 34);
            this.home_btn.TabIndex = 5;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            this.home_btn.DragDrop += new System.Windows.Forms.DragEventHandler(this.home_btn_DragDrop);
            this.home_btn.DragEnter += new System.Windows.Forms.DragEventHandler(this.home_btn_DragEnter);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(188, 7);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(91, 34);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Controls.Add(this.refresh_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 46);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.address_bar_textbos);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 46);
            this.panel3.TabIndex = 9;
            // 
            // website_panel
            // 
            this.website_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.website_panel.Controls.Add(this.panel_search);
            this.website_panel.Location = new System.Drawing.Point(0, 41);
            this.website_panel.Name = "website_panel";
            this.website_panel.Size = new System.Drawing.Size(855, 779);
            this.website_panel.TabIndex = 10;
            // 
            // panel_search
            // 
            this.panel_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_search.Controls.Add(this.btn_search_close);
            this.panel_search.Controls.Add(this.btn_search_next);
            this.panel_search.Controls.Add(this.btn_search_before);
            this.panel_search.Controls.Add(this.textBox_search);
            this.panel_search.Location = new System.Drawing.Point(625, 40);
            this.panel_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(228, 35);
            this.panel_search.TabIndex = 11;
            this.panel_search.Visible = false;
            // 
            // btn_search_close
            // 
            this.btn_search_close.Location = new System.Drawing.Point(204, 2);
            this.btn_search_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_close.Name = "btn_search_close";
            this.btn_search_close.Size = new System.Drawing.Size(23, 30);
            this.btn_search_close.TabIndex = 3;
            this.btn_search_close.Text = "x";
            this.btn_search_close.UseVisualStyleBackColor = true;
            this.btn_search_close.Click += new System.EventHandler(this.btn_search_close_Click);
            // 
            // btn_search_next
            // 
            this.btn_search_next.Location = new System.Drawing.Point(179, 2);
            this.btn_search_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_next.Name = "btn_search_next";
            this.btn_search_next.Size = new System.Drawing.Size(23, 30);
            this.btn_search_next.TabIndex = 2;
            this.btn_search_next.Text = ">";
            this.btn_search_next.UseVisualStyleBackColor = true;
            this.btn_search_next.Click += new System.EventHandler(this.btn_search_next_Click);
            // 
            // btn_search_before
            // 
            this.btn_search_before.Location = new System.Drawing.Point(150, 2);
            this.btn_search_before.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_before.Name = "btn_search_before";
            this.btn_search_before.Size = new System.Drawing.Size(23, 30);
            this.btn_search_before.TabIndex = 1;
            this.btn_search_before.Text = "<";
            this.btn_search_before.UseVisualStyleBackColor = true;
            this.btn_search_before.Click += new System.EventHandler(this.btn_search_before_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(3, 7);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(145, 22);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 820);
            this.Controls.Add(this.website_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.website_panel.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.TextBox address_bar_textbos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPrivateWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findOnThisWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel website_panel;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Button btn_search_close;
        private System.Windows.Forms.Button btn_search_next;
        private System.Windows.Forms.Button btn_search_before;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
    }
}

