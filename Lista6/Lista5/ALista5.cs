using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasATP
{
    public static class Lista6
    {
        public static void Executar()
        {
            int List5;
            char r;
            Console.WriteLine("A Lista 6 possui questões de 1 a 10, qual questão deseja executar?\n ");
            List5 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            {
                switch (List5)
                {
                    case 1:
                        L6Q01.Executar();
                        break;
                    case 2:
                        L6Q02.Executar();
                        break;
                    case 3:
                        L6Q03.Executar();
                        break;
                    case 4:
                        L6Q04.Executar();
                        break;
                    case 5:
                        L6Q05.Executar();
                        break;
                    case 6:
                        L6Q06.Executar();
                        break;
                    case 7:
                        L6Q07.Executar();
                        break;
                    case 8:
                        L6Q08.Executar();
                        break;
                    case 9:
                        L6Q09.Executar();
                        break;
                    case 10:
                        L6Q10.Executar();
                        break;
                    default:
                        Console.WriteLine("Questão inválida. ");
                        Lista5.Executar();
                        break;
                }
                Console.WriteLine("\n\nVocê deseja ver mais alguma questão?\nResponda 's' para sim e 'n' para não ");
                r = char.Parse(Console.ReadLine());
                if (r == 's' || r == 'S')
                    Lista6.Executar();
                else
                    Console.WriteLine("\nObrigado e até a proxima.");
            }
        }
    }
}
