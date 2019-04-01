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
        Image CloseImage;

        public class Tab
        {
            public ChromiumWebBrowser browser;
            public string address;
            public bool canGoBack, canGoForward;
        }
        private List<Tab> tabs = new List<Tab>();
        private int currentTabIndex = 0;

        public Tab currentTab { get { return tabs[currentTabIndex]; } set { tabs[currentTabIndex] = value; } }
        public ChromiumWebBrowser currentBrowser { get { return currentTab.browser; } set { currentTab.browser = value; } }
        public string currentAdress { get { return currentTab.address; } set { currentTab.address = value; } }

        public string Home_website { get; set; }
        public string Default_search { get; set; }
        public string Default_download_folder { get; set; }
        //public string page_address { get { return address_bar_textbos.Text; } }
        public string page_name { get { return this.Text; } }
        string file_name = "bookmarks.txt";
        string bookmark_name;

        public Form1()
        {
            InitializeComponent();
            Load_user_settings();
        }

        #region Tabs&Browsers

        private void Form1_Load(object sender, EventArgs e)
        {
            tcControlTab.DrawMode = TabDrawMode.OwnerDrawFixed;
            tcControlTab.DrawItem += tcControlTab_DrawItem;
            CloseImage = Browser.Properties.Resources.closeR;
            tcControlTab.Padding = new Point(10, 3);

            tcControlTab.TabPages.Add("   +");
            tcControlTab.SelectTab(0);
            tcControlTab.SelectedTab.Name = "newTabPage";
            tcControlTab.SelectTab(0);

            tcControlTab.DrawMode = TabDrawMode.OwnerDrawFixed;
            AddNewTab(Home_website);
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

        private void AddNewTab(string address)
        {
            tabs.Add(new Tab());

            currentTabIndex = tcControlTab.TabPages.Count - 1;
            currentAdress = address;
            currentBrowser = new ChromiumWebBrowser(address)
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
            LoadPage(address);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcControlTab.SelectedTab.Name == "newTabPage")
            {
                AddNewTab(Home_website);
            }
            else
            {
                currentTabIndex = tcControlTab.SelectedIndex;
                btnBack.Enabled = currentTab.canGoBack;
                btnNext.Enabled = currentTab.canGoForward;
                txtAddresBar.Text = currentAdress;
            }
        }

        public static Rectangle GetRTLCoordinates(Rectangle container, Rectangle drawRectangle)
        {
            return new Rectangle(
                container.Width - drawRectangle.Width - drawRectangle.X,
                drawRectangle.Y,
                drawRectangle.Width,
                drawRectangle.Height);
        }

        private void tcControlTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabRect = this.tcControlTab.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);

                var sf = new StringFormat(StringFormat.GenericDefault);
                if (this.tcControlTab.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                    this.tcControlTab.RightToLeftLayout == true)
                {
                    tabRect = GetRTLCoordinates(this.tcControlTab.ClientRectangle, tabRect);
                    imageRect = GetRTLCoordinates(this.tcControlTab.ClientRectangle, imageRect);
                    sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                }

                e.Graphics.DrawString(this.tcControlTab.TabPages[e.Index].Text, this.Font, Brushes.Black, tabRect, sf);
                if (e.Index != tcControlTab.TabCount - 1) 
                    e.Graphics.DrawImage(CloseImage, imageRect.Location);
            }
            catch (Exception) { }
        }

        private void tcControlTab_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tcControlTab.TabPages.Count-1; i++)
            {
                var tabRect = this.tcControlTab.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    if(tabs.Count==1)
                        Environment.Exit(0);

                    tabs[i].browser.Dispose();
                    tcControlTab.TabPages.RemoveAt(i);
                    tabs.RemoveAt(i);
                    break;
                }
            }
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

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => txtAddresBar.Text = args.Address);
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (e.CanGoBack)
                this.InvokeOnUiThreadIfRequired(() => btnBack.Enabled = currentTab.canGoBack = true);
            else
                this.InvokeOnUiThreadIfRequired(() => btnBack.Enabled = currentTab.canGoBack = false);
            if (e.CanGoForward)
                this.InvokeOnUiThreadIfRequired(() => btnNext.Enabled = currentTab.canGoForward = true);
            else
                this.InvokeOnUiThreadIfRequired(() => btnNext.Enabled = currentTab.canGoForward = false);
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            InvokeIfNeeded(() => {
                string title = e.Title;
                SetFormTitle(title);
                if (title.Length > 20)
                    title = title.Substring(0, 17) + "...";
                tcControlTab.SelectedTab.Text = title;
            });
        }

        #endregion

        #region userSettings
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
        #endregion

        #region Bookmarks
        private void Load_bookmarks()
        {
            //delete items
            bookmarksToolStripMenuItem1.DropDownItems.Clear();
            //add items
            int id = 0;
            ToolStripMenuItem itemOne = new ToolStripMenuItem("Show bookmarks bar");
            itemOne.Tag = id; id++;
            bookmarksToolStripMenuItem1.DropDownItems.Add(itemOne);
            itemOne.Click += ItemOne_Click;
            ToolStripMenuItem itemTwo = new ToolStripMenuItem("Bookmark manager");
            itemTwo.Tag = id; id++;
            bookmarksToolStripMenuItem1.DropDownItems.Add(itemTwo);
            itemTwo.Click += ItemTwo_Click;
            bookmarksToolStripMenuItem1.DropDownItems.Add(new ToolStripSeparator());
            foreach (var items in Get_items_for_bookmarks())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(items);
                item.Tag = id;
                id++;
                bookmarksToolStripMenuItem1.DropDownItems.Add(item);
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
                sr.Close();
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
                sr.Close();
            }
            return bookmarks_item;
        }
        #endregion

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

        private void findOnThisWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_search.Visible = true;

        }

        private void txtAddresBar_TextChanged(object sender, EventArgs e)
        {
            currentAdress = txtAddresBar.Text;
        }

        private void btn_search_next_Click(object sender, EventArgs e)
        {
            currentBrowser.Find(0, textBox_search.Text, true, false, false);
        }

        private void btn_search_before_Click(object sender, EventArgs e)
        {
            currentBrowser.Find(0, textBox_search.Text, false, false, false);
        }

        

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_bookmarks();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_user_settings();
            Cef.Shutdown();
        }
    }
}

