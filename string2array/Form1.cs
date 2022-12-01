using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace string2array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string s;
        public char[] ac;
        public int[] ai;
        public List<object> lista = new List<object>();

        public void string2chararray(string ps, ref char [] pac)
        { 
            ac = new char[ps.Length];
            for (int i = 0; i < ps.Length; i++)
            {
                ac[i] = Convert.ToChar(ps.Substring(i, 1));
            }
        }

        public void string2intarray(string ps, ref int[] pai)
        {
            ai = new int[ps.Length];
            for (int i = 0; i < ps.Length; i++)
            {
                ai[i] = Convert.ToInt16(ps.Substring(i, 1));
            }
        }

        public void printchararray(ref char [] pac, TextBox t)
        {
            resetTextBox(t);
            for (int i = 0; i < pac.Length; i++)
            {
                t.Text += pac[i].ToString() + " ";
            }
        }

        public void printintarray(ref int[] pai, TextBox t)
        {
            resetTextBox(t);
            for (int i = 0; i < pai.Length; i++)
            {
                t.Text += pai[i].ToString() + " ";
            }
        }

        public void resetTextBox(TextBox t)
        {
            t.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;

            string2chararray(s, ref ac);
            printchararray(ref ac, textBox2);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            s = textBox1.Text;

            string2intarray(s, ref ai);
            printintarray(ref ai, textBox2);
        }
    }
}
