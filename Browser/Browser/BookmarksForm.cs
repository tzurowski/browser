using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class BookmarksForm : Form
    {

        string file_name = "bookmarks.txt";
        Form1 main_site = new Form1();
        public BookmarksForm(Form1 form1)
        {
            InitializeComponent();
            main_site = form1;
            url_txtb.Text = main_site.currentAdress;
            name_txtb.Text = main_site.page_name;
            if (!File.Exists(file_name)) File.Create(file_name).Dispose();
        }
        public void SaveToFile(string name, string text)
        {
            using (StreamWriter sw = new StreamWriter(file_name, true))
            {
                sw.Write(name);
                sw.Write(";");
                sw.WriteLine(text);
            }
            
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            Protection();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Protection()
        {
            bool none_exist = true;
            using (var sr = new StreamReader(file_name))
            {
                string strline;
                while ((strline = sr.ReadLine()) != null)
                {
                    string[] tab = strline.Split(';');
                    
                    if (name_txtb.Text.ToLower().Equals(tab[0].ToLower()))
                    {
                        MessageBox.Show("The bookmark name is currently in use.");
                        name_txtb.Text = "";
                        none_exist = false;
                    }
                }
                
            }
            if (none_exist)
            {
                if (name_txtb.Text != "")
                {
                    SaveToFile(name_txtb.Text, url_txtb.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Give the bookmark a name");
                    none_exist = false;
                }
            }
        }

        private void name_txtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Protection();
        }

        private void url_txtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Protection();
        }
    }
}
