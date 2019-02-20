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
            url_txtb.Text = main_site.page_address;
        }
        public void SaveToFile(string name, string text)
        {
            using (StreamWriter sw = new StreamWriter(file_name))
            {
                sw.Write(name);
                sw.Write(";");
                sw.WriteLine(text);
            }
            
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveToFile(name_txtb.Text, url_txtb.Text);
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
