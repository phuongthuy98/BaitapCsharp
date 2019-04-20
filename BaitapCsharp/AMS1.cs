using System;

namespace BaitapCsharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num, i,dem, nhapvao;

            Console.Write("\n\n");
            Console.Write("Tim so nguyen to\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");
            
            Console.Write("Nhap so: ");
            nhapvao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac so nguyen to nho hon {0} la: \n", nhapvao);

            for (num = 2; num <= nhapvao; num++)
            {
                dem = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        dem++;
                        break;
                    }
                }

                if (dem == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");  

            Console.ReadKey();
            
        }
        
    }
 
}