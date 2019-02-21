using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using CefSharp.Example;
using CefSharp.Example.Handlers;
using System.IO;

namespace Browser
{

    public partial class Form1 : Form
    {
        private readonly ChromiumWebBrowser browser;
        public string Home_website { get; set; }
        public string Default_search { get; set; }
        public string Default_download_folder { get; set; }
        public string page_address { get { return address_bar_textbos.Text; } }
        public string page_name { get { return this.Text; } }

        public Form1()
        {
            InitializeComponent();
            Load_user_settings();
            browser = new ChromiumWebBrowser(Home_website)
            {
                Dock = DockStyle.Fill,
            };
            website_panel.Controls.Add(browser);
            browser.AddressChanged += OnBrowserAddressChanged;
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.DownloadHandler = new DownloadHandler();
            browser.TitleChanged += Browser_TitleChanged;
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            InvokeIfNeeded(() => {
                //ChromiumWebBrowser browser = (ChromiumWebBrowser)sender;
                SetFormTitle(e.Title);
            });

        }
        private void SetFormTitle(string tabName)
        {
            this.Text = tabName;
        }

        public void InvokeIfNeeded(Action action)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }
        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if(e.CanGoBack)
                this.InvokeOnUiThreadIfRequired(() => back_btn.Enabled = true);
            else
                this.InvokeOnUiThreadIfRequired(() => back_btn.Enabled = false);
            if (e.CanGoForward)
                this.InvokeOnUiThreadIfRequired(() => next_btn.Enabled = true);
            else
                this.InvokeOnUiThreadIfRequired(() => next_btn.Enabled = false);
        }

        private void Load_user_settings()
        {
            Home_website = Properties.Settings.Default.Home_website;
            Default_search = Properties.Settings.Default.Default_search;
            Default_download_folder = Properties.Settings.Default.Default_download_folder;
        }

        private void Save_user_settings()
        {
            Properties.Settings.Default.Home_website = Home_website;
            Properties.Settings.Default.Default_search = Default_search;
            Properties.Settings.Default.Default_download_folder = Default_download_folder;
            Properties.Settings.Default.Save();
        }

        private void address_bar_textbos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Load(address_bar_textbos.Text);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }


        private void home_btn_Click(object sender, EventArgs e)
        {

        }

        private void address_bar_textbos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Load(address_bar_textbos.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                BookmarksForm bookmarks = new BookmarksForm(this);
                bookmarks.ShowDialog();
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_user_settings();
            Cef.Shutdown();
        }

        private void home_btn_DragDrop(object sender, DragEventArgs e)
        {
            Home_website=(string)e.Data.GetData(DataFormats.Text);
        }

        private void home_btn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form2(this);
            form.ShowDialog();
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => address_bar_textbos.Text = args.Address);
        }

        private void findOnThisWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_search.Visible = true;
            
        }

        private void btn_search_close_Click(object sender, EventArgs e)
        {
            panel_search.Visible = false;
            
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_search.Text.Length <= 0)
                {
                    browser.StopFinding(true);
                }
                else
                {
                    browser.Find(0, textBox_search.Text, true, false, false);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btn_search_next_Click(object sender, EventArgs e)
        {
            browser.Find(0, textBox_search.Text, true, false, false);
        }

        private void btn_search_before_Click(object sender, EventArgs e)
        {
            browser.Find(0, textBox_search.Text, false, false, false);
        }

    }
}
