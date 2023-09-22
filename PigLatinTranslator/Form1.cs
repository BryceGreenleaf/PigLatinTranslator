﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnglish.Text = "";
            txtPigLatin.Text = "";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string english = txtEnglish.Text.Trim();
            if (!String.IsNullOrEmpty(txtEnglish.Text))
            {
                string[] words = english.Split(' ');
                string piglatin = "";
                foreach (string word in words)
                {
                    piglatin += TranslateWord(word) + " ";
                }
                txtPigLatin.Text = piglatin;
            }
            else
            {
                MessageBox.Show("You must enter some text to translate", "HEY YOU HEFFER ENTER TEXT");
                txtEnglish.Focus();
            }
        }

        private string TranslateWord(string word)
        {
            return word;
        }
    }
}
