using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{

    public partial class Form1 : Form
    {
        public string Home_website { get; set; }
        public string Default_search { get; set; }
        public string Default_download_folder { get; set; }

        public Form1()
        {
            InitializeComponent();
            Load_user_settings();
            webBrowser1.Navigate(Home_website);
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
            webBrowser1.Navigate(address_bar_textbos.Text);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }


        private void home_btn_Click(object sender, EventArgs e)
        {

        }

        private void address_bar_textbos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(address_bar_textbos.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_user_settings();
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

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            address_bar_textbos.Text = webBrowser1.Url.ToString();
        }
    }
}
