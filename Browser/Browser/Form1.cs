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
        class Tab
        {
            public ChromiumWebBrowser browser;
            public string address;
        }
        private List<Tab> tabs = new List<Tab>();
        private int currentTabIndex = 0;

        public ChromiumWebBrowser currentBrowser { get { return tabs[currentTabIndex].browser; } }
        public string currentAdress { get { return tabs[currentTabIndex].address; } set { tabs[currentTabIndex].address = value; } }

        public string Home_website { get; set; }
        public string Default_search { get; set; }
        public string Default_download_folder { get; set; }
        //public string page_address { get { return address_bar_textbos.Text; } }
        public string page_name { get { return this.Text; } }

        public Form1()
        {
            InitializeComponent();
            Load_user_settings();

            tabs.Add(new Tab());

            tabs[currentTabIndex].address = Home_website;
            tabs[currentTabIndex].browser = new ChromiumWebBrowser(Home_website)
            {
                Dock = DockStyle.Fill,
            };

            currentBrowser.AddressChanged += OnBrowserAddressChanged;
            currentBrowser.LoadingStateChanged += Browser_LoadingStateChanged;
            currentBrowser.DownloadHandler = new DownloadHandler();
            currentBrowser.TitleChanged += Browser_TitleChanged;

            LoadPage(Home_website);
            tcControlTab.TabPages.Add(Home_website);
            tcControlTab.SelectTab(currentTabIndex);
            tcControlTab.SelectedTab.Controls.Add(currentBrowser);

            tcControlTab.TabPages.Add("   +");
            tcControlTab.SelectTab(1);
            tcControlTab.SelectedTab.Name = "newTabPage";
            tcControlTab.SelectTab(0);

        }

        private void AddTab(string address)
        {

            tabs.Add(new Tab());

            currentTabIndex = tcControlTab.TabPages.Count - 1;
            tabs[currentTabIndex].address = address;
            tabs[currentTabIndex].browser = new ChromiumWebBrowser(address)
            {
                Dock = DockStyle.Fill,
            };

            currentBrowser.AddressChanged += OnBrowserAddressChanged;
            currentBrowser.LoadingStateChanged += Browser_LoadingStateChanged;
            currentBrowser.DownloadHandler = new DownloadHandler();
            currentBrowser.TitleChanged += Browser_TitleChanged;


            tcControlTab.TabPages.Insert(tcControlTab.TabPages.Count - 1, "New Tab");
            tcControlTab.SelectTab(tcControlTab.TabPages.Count - 2);
            tcControlTab.SelectedTab.Controls.Add(currentBrowser);
            LoadPage("");
        }

        private void LoadPage(string address)
        {
            currentAdress = address;
            var regAdress = new Regex(@".\..");
            if (regAdress.IsMatch(address) && address.Split().Length == 1)
                currentBrowser.Load(address);
            else
            {
                if (Default_search == "google.com")
                    address = "https://www.google.com/search?q=" + address;
                else if (Default_search == "bing.com")
                    address = "https://www.bing.com/search?q=" + address;
                else
                    address = "https://search.yahoo.com/search?p=" + address;
                currentBrowser.Load(address);
            }
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            InvokeIfNeeded(() => {
                //ChromiumWebBrowser browser = (ChromiumWebBrowser)sender;
                tcControlTab.SelectedTab.Text = e.Title;
                //SetFormTitle(e.Title);
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
            if (e.CanGoBack)
                this.InvokeOnUiThreadIfRequired(() => btnBack.Enabled = true);
            else
                this.InvokeOnUiThreadIfRequired(() => btnBack.Enabled = false);
            if (e.CanGoForward)
                this.InvokeOnUiThreadIfRequired(() => btnNext.Enabled = true);
            else
                this.InvokeOnUiThreadIfRequired(() => btnNext.Enabled = false);
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
            LoadPage(txtAddresBar.Text);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            currentBrowser.Back();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            currentBrowser.Forward();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            LoadPage(Home_website);
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            currentBrowser.Reload();
        }

        private void address_bar_textbos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPage(txtAddresBar.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
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
            this.InvokeOnUiThreadIfRequired(() => txtAddresBar.Text = args.Address);
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
                    currentBrowser.StopFinding(true);
                }
                else
                {
                    currentBrowser.Find(0, textBox_search.Text, true, false, false);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btn_search_next_Click(object sender, EventArgs e)
        {
            currentBrowser.Find(0, textBox_search.Text, true, false, false);
        }

        private void btn_search_before_Click(object sender, EventArgs e)
        {
            currentBrowser.Find(0, textBox_search.Text, false, false, false);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcControlTab.SelectedTab.Name == "newTabPage")
            {
                AddTab(null);
            }
            else
            {
                currentTabIndex = tcControlTab.SelectedIndex;
                txtAddresBar.Text = currentAdress;
            }
        }

        private void txtAddresBar_TextChanged(object sender, EventArgs e)
        {
            currentAdress = txtAddresBar.Text;
        }
    }
}
