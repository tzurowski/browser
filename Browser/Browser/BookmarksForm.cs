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
        public BookmarksForm()
        {
            InitializeComponent();
        }
        public static void SaveToFile(string fileName, string text)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(text);
            }
        }
    }
}
