using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_senhas_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerarSenhaBtn_Click(object sender, EventArgs e)
        {
            var gerar = new gerar();
            senhaTxt.Text = gerar.gerarSenha(int.Parse(tamanho.Value.ToString()));
        }
    }
}
