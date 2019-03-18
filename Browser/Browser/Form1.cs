using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        string file_name = "bookmarks.txt";
        string bookmark_name;

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
            LoadPage(Home_website);
        }

        private void LoadPage(string address)
        {
            var regAdress = new Regex(@".\..");
            if(regAdress.IsMatch(address) && address.Split().Length == 1)
                browser.Load(address);
            else
            {
                if (Default_search == "google.com")
                    address = "https://www.google.com/search?q=" + address;
                else if (Default_search == "bing.com")
                    address = "https://www.bing.com/search?q=" + address;
                else
                    address = "https://search.yahoo.com/search?p=" + address;
                browser.Load(address);
            }

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
            if(this.InvokeRequired)
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
            if(e.CanGoForward)
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



        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(address_bar_textbos.Text);
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
            LoadPage(Home_website);
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        private void address_bar_textbos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadPage(address_bar_textbos.Text);
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
            Home_website = (string)e.Data.GetData(DataFormats.Text);
        }

        private void home_btn_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
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
            if(e.KeyCode == Keys.Enter)
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

        private void Load_bookmarks()
        {
            //delete items
            bookmarksToolStripMenuItem.DropDownItems.Clear();
            //add items
            int id = 0;
            ToolStripMenuItem itemOne = new ToolStripMenuItem("Show bookmarks bar");
            itemOne.Tag = id; id++;
            bookmarksToolStripMenuItem.DropDownItems.Add(itemOne);
            itemOne.Click += ItemOne_Click;
            ToolStripMenuItem itemTwo = new ToolStripMenuItem("Bookmark manager");
            itemTwo.Tag = id; id++;
            bookmarksToolStripMenuItem.DropDownItems.Add(itemTwo);
            itemTwo.Click += ItemTwo_Click;
            bookmarksToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            foreach (var items in Get_items_for_bookmarks())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(items);
                item.Tag = id;
                id++;
                bookmarksToolStripMenuItem.DropDownItems.Add(item);
                item.Click += Item_Click;
                bookmark_name = item.Text;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            using (var sr = new StreamReader(file_name))
            {
                string strline;
                while ((strline = sr.ReadLine()) != null)
                {
                    string[] tab = strline.Split(';');
                    if (sender.ToString() == tab[0])
                    {
                        LoadPage(tab[1]);
                    }
                }
            }
        }

        private void ItemOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void ItemTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private List<String> Get_items_for_bookmarks()
        {
            List<String> bookmarks_item = new List<String>();
            using (var sr = new StreamReader(file_name))
            {
                string strline;
                while ((strline = sr.ReadLine()) != null)
                {
                    string[] tab = strline.Split(';');
                    bookmarks_item.Add(tab[0]);
                }
            }
            return bookmarks_item;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_bookmarks();
        }
    }
}

