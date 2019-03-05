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
    public partial class Form2 : Form
    {
        Form1 mainform;
        string[] searchs = { "google.com", "yahoo.com", "bing.com"};
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainform = form;
            foreach(string search in searchs)
                default_search_comboBox.Items.Add(search);
            default_search_comboBox.Text = mainform.Default_search;
            default_foldertextBoxt.Text = mainform.Default_download_folder;
            homeWebsite_textBox.Text = mainform.Home_website;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            mainform.Default_download_folder = default_foldertextBoxt.Text;
            mainform.Default_search = default_search_comboBox.Text;
            mainform.Home_website = homeWebsite_textBox.Text;
        }


    }
}
