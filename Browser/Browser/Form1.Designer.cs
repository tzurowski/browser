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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(0, 6);
            this.back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(59, 33);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "<-";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(64, 6);
            this.next_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(59, 33);
            this.next_btn.TabIndex = 1;
            this.next_btn.Text = "->";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // address_bar_textbos
            // 
            this.address_bar_textbos.Location = new System.Drawing.Point(316, 11);
            this.address_bar_textbos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_bar_textbos.Name = "address_bar_textbos";
            this.address_bar_textbos.Size = new System.Drawing.Size(1103, 22);
            this.address_bar_textbos.TabIndex = 2;
            this.address_bar_textbos.TextChanged += new System.EventHandler(this.address_bar_textbos_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 47);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1584, 729);
            this.webBrowser1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1445, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(155, 820);
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
            this.helpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.newWindowToolStripMenuItem.Text = "New window";
            // 
            // newPrivateWindowToolStripMenuItem
            // 
            this.newPrivateWindowToolStripMenuItem.Name = "newPrivateWindowToolStripMenuItem";
            this.newPrivateWindowToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.newPrivateWindowToolStripMenuItem.Text = "New private window";
            // 
            // downloadFilesToolStripMenuItem
            // 
            this.downloadFilesToolStripMenuItem.Name = "downloadFilesToolStripMenuItem";
            this.downloadFilesToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.downloadFilesToolStripMenuItem.Text = "Download files";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // findOnThisWebsiteToolStripMenuItem
            // 
            this.findOnThisWebsiteToolStripMenuItem.Name = "findOnThisWebsiteToolStripMenuItem";
            this.findOnThisWebsiteToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.findOnThisWebsiteToolStripMenuItem.Text = "Find on this website";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1447, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home_btn
            // 
            this.home_btn.AllowDrop = true;
            this.home_btn.Location = new System.Drawing.Point(129, 9);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(81, 32);
            this.home_btn.TabIndex = 5;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.DragDrop += new System.Windows.Forms.DragEventHandler(this.home_btn_DragDrop);
            this.home_btn.DragEnter += new System.Windows.Forms.DragEventHandler(this.home_btn_DragEnter);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(219, 10);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(91, 31);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 820);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.address_bar_textbos);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.TextBox address_bar_textbos;
        private System.Windows.Forms.WebBrowser webBrowser1;
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
    }
}

