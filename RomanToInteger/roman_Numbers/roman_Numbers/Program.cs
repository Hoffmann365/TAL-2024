using System;

namespace roman_Numbers
{
  internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o número a ser convertido:");
                string answer = Console.ReadLine();
                romanToInt(answer);
                Console.WriteLine("Aperte enter para continuar convertendo ou 1 para sair");
                string exit = Console.ReadLine();
                if (exit == "1")
                {
                    break;
                }
            }
        }

        public static void romanToInt(string s)
        {
            char[] sToArray = s.ToCharArray();
            int length = sToArray.Length;
            int update = 0;
            char fContent;
            for (int i = 0; i < sToArray.Length; i++)
            {
                
                char content = sToArray[i];
                if (i < (sToArray.Length - 1))
                {
                    fContent = sToArray[i+1];
                }
                else
                {
                    fContent = sToArray[i];
                }
                
                if (content == 'I' && fContent == 'V')
                {
                    update += 4;
                    i++;
                }
                if (content == 'I' && fContent == 'X')
                {
                    update += 9;
                    i++;
                }
                if (content == 'I' && fContent != 'V' && fContent != 'X')
                {
                    update += 1;
                }
                if (content ==  'X' && fContent == 'L')
                {
                    update += 40;
                    i++;
                }
                if (content ==  'X' && fContent == 'C')
                {
                    update += 90;
                    i++;
                }
                if (content == 'X' && fContent != 'L' && fContent != 'C')
                {
                    update += 10;
                }
                if (content == 'C' && fContent == 'D')
                {
                    update += 400;
                    i++;
                }
                if (content == 'C' && fContent == 'M')
                {
                    update += 900;
                    i++;
                }
                if (content == 'C' && fContent != 'D' && fContent != 'M')
                {
                    update += 100;
                }
                if (content == 'V')
                {
                    update += 5;
                }
                if (content == 'L')
                {
                    update += 50;
                }
                if (content == 'D')
                {
                    update += 500;
                }
                if (content == 'M')
                {
                    update += 1000;
                }
            }
            Console.WriteLine($"O número convertido é: " + update);
        }
    }
}