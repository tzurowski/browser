﻿using System;
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
        public Form1()
        {
            InitializeComponent();
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
    }
}
