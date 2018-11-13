using System;

namespace Gerador_de_senhas_2._0
{
    public class gerar
    {
        private string letraMinus = "abcdefgijklmnopqrstuvxwyz";
        private string letraMaius = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
        private string numero = "0123456789";
        private string especial = "@#$%&*";
        private int sorteio;
        private int tam = 0;
        private string senha;
        private bool maius = false;
        private bool minus = false;
        private bool num = false;
        private bool espec = false;

        public string gerarSenha(int tamanho)
        {
            char[] caracterSenha = new char[tamanho];
            Random aleatorio = new Random();
            for (int i = 0; i < tamanho; i++)
            {
                sorteio = aleatorio.Next(0, 4);
                if (sorteio == 0)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        caracterSenha[tam] = letraMinus[aleatorio.Next(0, letraMinus.Length)];
                        tam++;
                        maius = true;
                    }
                }
                else if (sorteio == 1)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        caracterSenha[tam] = letraMaius[aleatorio.Next(0, letraMaius.Length)];
                        tam++;
                        minus = true;
                    }
                }
                else if (sorteio == 2)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        caracterSenha[tam] = numero[aleatorio.Next(0, numero.Length)];
                        tam++;
                        num = true;
                    }
                }
                else if (sorteio == 3)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        caracterSenha[tam] = especial[aleatorio.Next(0, especial.Length)];
                        tam++;
                        espec = true;
                    }
                }
                if (tam == tamanho)
                {
                    if ((maius == true) && (minus == true) && (num == true) && (espec == true))
                    {
                        break;
                    }
                    else
                    {
                        i = -1;
                        tam = 0;
                        maius = false;
                        minus = false;
                        num = false;
                        espec = false;
                    }
                }
            }
            senha = new string(caracterSenha);
            return senha;
        }
    }
}
