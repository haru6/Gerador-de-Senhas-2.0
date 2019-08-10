using Gerador_de_senhas_2._0.Controler;
using Gerador_de_senhas_2._0.Model;
using System;
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
            if (MaiusRadio.Checked)
            {
                var senha = new geradorSenha1();
                senhaTxt.Text = senha.sorteioMaiuscula(int.Parse(tamanho.Value.ToString()));
            }
            else if (MinuscRadio.Checked)
            {
                var senha = new geradorSenha1();
                senhaTxt.Text = senha.sorteioMinuscula(int.Parse(tamanho.Value.ToString()));
            }
            else if (EspecRadio.Checked)
            {
                var senha = new geradorSenha1();
                senhaTxt.Text = senha.sorteioCaracterEspecial(int.Parse(tamanho.Value.ToString()));
            }
            else if (NumRadio.Checked)
            {
                var senha = new geradorSenha1();
                senhaTxt.Text = senha.sorteioNumero(int.Parse(tamanho.Value.ToString()));
            }

            else if (MaiusMinusRadio.Checked)
            {
                var senha = new geradorSenha2();
                senhaTxt.Text = senha.sorteioMaiuscMinus(int.Parse(tamanho.Value.ToString()));
            }

            else if (MaiusEspecRadio.Checked)
            {
                var senha = new geradorSenha2();
                senhaTxt.Text = senha.sorteioMaiuscEspec(int.Parse(tamanho.Value.ToString()));
            }

            else if (MaiuNumRadio.Checked)
            {
                var senha = new geradorSenha2();
                senhaTxt.Text = senha.sorteioMaiuscNum(int.Parse(tamanho.Value.ToString()));
            }

            else if (MinusEspecRadio.Checked)
            {
                var senha = new geradorSenha2();
                senhaTxt.Text = senha.sorteioMinusEspec(int.Parse(tamanho.Value.ToString()));
            }

            else if (MinusNumRadio.Checked)
            {
                var senha = new geradorSenha2();
                senhaTxt.Text = senha.sorteioMinusNum(int.Parse(tamanho.Value.ToString()));
            }

            else if (EspecNumRadio.Checked)
            {
                var senha = new geradorSenha2();
                senhaTxt.Text = senha.sorteioEspecNum(int.Parse(tamanho.Value.ToString()));
            }

            else if (MaiusMinusEspecRadio.Checked)
            {
                var senha = new geradorSenha3();
                senhaTxt.Text = senha.sorteioMaiuscMinuscEspec(int.Parse(tamanho.Value.ToString()));
            }

            else if (MaiusMinusNumRadio.Checked)
            {
                var senha = new geradorSenha3();
                senhaTxt.Text = senha.sorteioMaiuscMinuscNum(int.Parse(tamanho.Value.ToString()));
            }

            else if (MaiusEspecNumRadio.Checked)
            {
                var senha = new geradorSenha3();
                senhaTxt.Text = senha.sorteioMaiuscEspecNum(int.Parse(tamanho.Value.ToString()));
            }

            else if (MinusEspecNumRadio.Checked)
            {
                var senha = new geradorSenha3();
                senhaTxt.Text = senha.sorteioMinuscEspecNum(int.Parse(tamanho.Value.ToString()));
            }
            
            else if (TodosRadio.Checked)
            {
                var senha = new geradorSenha4();
                senhaTxt.Text = senha.todas(int.Parse(tamanho.Value.ToString()));
            }

            else
            {
                MessageBox.Show("Você precisa selecioanr uma opção","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

    }
}
