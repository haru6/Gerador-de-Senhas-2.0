using Gerador_de_senhas_2._0.Model;
using System;

namespace Gerador_de_senhas_2._0.Controler
{
    public class geradorSenha1
    {
        private string novasenha;
        private Random aleatorio = new Random();
        private letraMaiuscula maiuscula = new letraMaiuscula();
        private letraMinuscula minuscula = new letraMinuscula();
        private CaracterEspecial especial = new CaracterEspecial();
        private Numero numero = new Numero();

        public string sorteioMaiuscula(int tamanho)
        {
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                senha[i] = maiuscula.getMaiuscula()[aleatorio.Next(0, maiuscula.getMaiuscula().Length)];
            }
            return  novasenha = new string(senha);
        }

        public string sorteioMinuscula(int tamanho)
        {
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                senha[i] = minuscula.getMinuscula()[aleatorio.Next(0, minuscula.getMinuscula().Length)];
            }
            return novasenha = new string(senha);
        }

        public string sorteioCaracterEspecial(int tamanho)
        {
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                senha[i] = especial.getEspecial()[aleatorio.Next(0, especial.getEspecial().Length)];
            }
            return novasenha = new string(senha);
        }

        public string sorteioNumero(int tamanho)
        {
            char[] senha = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                senha[i] = numero.getNum()[aleatorio.Next(0, numero.getNum().Length)];
            }
            return novasenha = new string(senha);
            
        }
    }
}
