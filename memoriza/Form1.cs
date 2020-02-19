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

namespace memoriza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RTFFile MeuTexto = new RTFFile();

        public string path = Application.StartupPath + "\\Resources\\Texto.txt";
        private void Button1_Click(object sender, EventArgs e)
        {
            MeuTexto.Texto = richTextBox1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MeuTexto.Texto = richTextBox1.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MeuTexto.Salvar();
        }
    }
}
