using System;

namespace BaitapCsharp
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
            int prv = 0, pre = 1, trm, i, n;

            Console.Write("\n");
            Console.Write("In day Fibonacci trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so phan tu can hien thi: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day Fibonacci gom {0} phan tu la: \n", n);
            Console.Write("{0}    {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
