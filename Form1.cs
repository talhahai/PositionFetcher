using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PositionFetcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Cursor.Position.X.ToString();
            textBox2.Text = Cursor.Position.Y.ToString();
        }
    }
}
