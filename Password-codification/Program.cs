using System;

namespace ConsoleApp1
{
    class Program
    {
        /*
        
        Autor: Ismael Ribeiro Moura
        Data: 18/10/2021

        Senha de exemplo a ser invertida:
        dImensao-C137@2021
        Output:
        oasnemId-731C@1202
        */

        static string senha = "dImensao-C137@2021";
        static string senhaConvertida = "";
        static string aux = "";
        static int index = 0;

        #region Inverter
        private static void Inverter(string texto, int posFin, bool end = false)
        {
            for (int j = (texto.Length - 1); j >= 0; j--)
            {
                senhaConvertida += texto.Substring(j, 1);
            }
            if (end == false)
            {
                senhaConvertida += senha.Substring(posFin, 1);
            }
            index = (posFin + 1);
            aux = "";
        }
        #endregion Inverter

        #region Main
        static void Main(string[] args)
        {
            char[] teste = senha.ToCharArray();
            for (int i = index; i < senha.Length; i++)
            {
                if (Char.IsLetterOrDigit(teste[i]))
                {
                    aux += teste[i];
                }
                else
                {
                    Inverter(aux, i);
                }
            }
            Inverter(aux, index, true);
            Console.WriteLine(senha);
            Console.WriteLine(senhaConvertida);
        }
        #endregion Main
    }
}
