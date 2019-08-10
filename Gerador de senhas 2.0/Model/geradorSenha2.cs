using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_senhas_2._0.Model
{
    public class geradorSenha2
    {
        private int x;
        private string novaSenha;
        private Random aleatorio = new Random();
        private letraMaiuscula maiuscula = new letraMaiuscula();
        private letraMinuscula minuscula = new letraMinuscula();
        private CaracterEspecial especial = new CaracterEspecial();
        private Numero numero = new Numero();

        public string sorteioMaiuscMinus(int tamanho)
        {
            bool maius = false;
            bool minus = false;
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 2);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
                    }
                    maius = true;
                }
                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
                    }
                    minus = true;
                }
                if (i == tamanho -1)
                {
                    if ((maius == true) && (minus == true))
                    {
                        break;
                    }
                    else
                    {
                        i = -1;
                        maius = false;
                        minus = false;
                    }
                }
            }
            return novaSenha = new string(senha);
        }

        public string sorteioMaiuscEspec(int tamanho)
        {
            bool maius = false;
            bool espec = false;
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 2);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
                    }
                    maius = true;
                }
                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
                    }
                    espec = true;
                }

                if (i == tamanho -1)
                {
                    if ((maius == true) && (espec == true))
                    {
                        break;
                    }
                    else
                    {
                        i = -1;
                        maius = false;
                        espec = false;
                    }
                }
            }
            return novaSenha = new string(senha);
        }

        public string sorteioMaiuscNum(int tamanho)
        {
            bool maius = false;
            bool num = false;
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 2);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
                    }
                    maius = true;
                }
                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
                    }
                    num = true;
                }

                if (i == tamanho -1)
                {
                    if ((maius == true) && (num == true))
                    {
                        break;
                    }
                    else
                    {
                        i = -1;
                        maius = false;
                        num = false;
                    }
                }
            }
            return novaSenha = new string(senha);
        }

        public string sorteioMinusEspec(int tamanho)
        {
            bool espec = false;
            bool minus = false;
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 2);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
                    }
                    espec = true;
                }
                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
                    }
                    minus = true;
                }

                if (i == tamanho -1)
                {
                    if ((espec == true) && (minus == true))
                    {
                        break;
                    }
                    else
                    {
                        i = -1;
                        espec = false;
                        minus = false;
                    }
                }
            }
            return novaSenha = new string(senha);
        }

        public string sorteioMinusNum(int tamanho)
        {
            bool num = false;
            bool minus = false;
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 2);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
                    }
                    num = true;
                }
                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
                    }
                    minus = true;
                }

                if (i == tamanho -1)
                {
                    if ((num == true) && (minus == true))
                    {
                        break;
                    }
                    else
                    {
                        i = -1;
                        num = false;
                        minus = false;
                    }
                }
            }
            return novaSenha = new string(senha);
        }

        public string sorteioEspecNum(int tamanho)
        {
            bool espec = false;
            bool num = false;
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 2);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
                    }
                    espec = true;
                }
                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
                    }
                    num = true;
                }

                if (i == tamanho -1)
                {
                    if ((espec == true) && (num == true))
                    {
                        break;
                    }
                    else
                    {
                        i = -1;
                        espec = false;
                        num = false;
                    }
                }
            }
            return novaSenha = new string(senha);
        }
    }
}
