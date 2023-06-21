using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListasATP
{
    public static class L6Q01
    {
        public static void Executar()
        {
                Console.WriteLine("Digite uma frase:");
                string frase = Console.ReadLine();

                int Contador = Contar(frase);
                Console.WriteLine("Número de espaços em branco na frase: " + contadorEspacos);

            static int Contar(string frase) //Função que contará o número de espaços em branco presente na frase
            {
                int contador = 0;
                foreach (char caractere in frase)
                {
                    if (caractere == ' ')
                    {
                        contador++;
                    }
                }
                return contador;
            }
        }

    }
}

