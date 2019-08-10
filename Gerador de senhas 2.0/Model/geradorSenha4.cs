using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_senhas_2._0.Model
{
    public class geradorSenha4
    {
        private letraMaiuscula maiuscula = new letraMaiuscula();
        private letraMinuscula minuscula = new letraMinuscula();
        private CaracterEspecial especial = new CaracterEspecial();
        private Numero numero = new Numero();
        private string novasenha;
        private int x;
        private bool maiusc = false;
        private bool minusc = false;
        private bool espec = false;
        private bool num = false;
        private Random aleatorio = new Random();

        public string todas(int tamanho)
        {
            char[] senha = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                x = aleatorio.Next(0, 4);
                if (x == 0)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
                        maiusc = true;
                    }
                }

                if (x == 1)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
                        minusc = true;
                    }
                }

                if (x == 2)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
                        espec = true;
                    }
                }

                if (x == 3)
                {
                    for (int y = 0; y < 1; y++)
                    {
                        senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
                        num = true;
                    }
                }

                if (i == tamanho - 1)
                {
                    if ((maiusc == true) && (minusc == true) && (espec == true) && (num == true))
                    {
                        break;
                    }

                    else
                    {
                        maiusc = false;
                        minusc = false;
                        espec = false;
                        num = false;
                        i = -1;
                    }
                }
            }

            return novasenha = new string(senha);

        }
    }
}
