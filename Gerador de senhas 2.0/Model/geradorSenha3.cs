using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_senhas_2._0.Model
{
    public class geradorSenha3
    {
        private int x;
        private string novaSenha;
        private Random aleatorio = new Random();
        private letraMaiuscula maiuscula = new letraMaiuscula();
        private letraMinuscula minuscula = new letraMinuscula();
        private CaracterEspecial especial = new CaracterEspecial();
        private Numero numero = new Numero();
        public string sorteioMaiuscMinuscEspec(int tamanho)
        {
            bool maiusc = false;
            bool minusc = false;
            bool espec = false;
            char[] senha = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 3);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
                    }
                    maiusc = true;
                }
                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
                    }
                    minusc = true;
                }
                else if (x == 2)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
                    }
                    espec = true;
                }
                if (i == tamanho - 1)
                {
                    if ((maiusc == true) && (minusc == true) && (espec == true))
                    {
                        break;
                    }
                    else
                    {
                        maiusc = false;
                        minusc = false;
                        espec = false;
                        i = -1;
                    }
                }
            }
            return novaSenha = new string(senha);

        }

        public string sorteioMaiuscMinuscNum(int tamanho)
        {
            bool maiusc = false;
            bool minusc = false;
            bool num = false;
            char[] senha = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 3);

                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
                    }
                    maiusc = true;
                }

                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
                    }
                    minusc = true;
                }

                else if (x == 2)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
                    }
                    num = true;
                }

                if (i == tamanho - 1)
                {
                    if ((maiusc == true) && (minusc == true) && (num == true))
                    {
                        break;
                    }
                    else
                    {
                        maiusc = false;
                        minusc = false;
                        num = false;
                        i = -1;
                    }
                }
            }

            return novaSenha = new string(senha);

        }


        public string sorteioMaiuscEspecNum(int tamanho)
        {
            bool maiusc = false;
            bool espec = false;
            bool num = false;
            char[] senha = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 3);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
                        maiusc = true;
                    }
                }

                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
                        espec = true;
                    }
                }

                else if (x == 2)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
                        num = true;
                    }
                }

                if (i == tamanho - 1)
                {
                    if ((maiusc == true) && (espec == true) && (num == true))
                    {
                        break;
                    }

                    else
                    {
                        maiusc = false;
                        espec = false;
                        num = false;
                        i = -1;
                    }
                }
            }

            return novaSenha = new string(senha);

        }

        public string sorteioMinuscEspecNum(int tamanho)
        {
            bool minusc = false;
            bool espec = false;
            bool num = false;
            char[] senha = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 3);

                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
                        minusc = true;
                    }
                }

                else if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
                        espec = true;
                    }
                }

                else if (x == 2)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
                        num = true;
                    }
                }

                if (i == tamanho - 1)
                {
                    if ((minusc == true) && (espec == true) && (num == true))
                    {
                        break;
                    }
                    else
                    {
                        minusc = false;
                        espec = false;
                        num = false;
                        i = -1;
                    }
                }

            }

            return novaSenha = new string(senha);
        }
    }
}
