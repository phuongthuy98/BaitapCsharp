using System;

namespace BaitapCsharp
{
    public class Sinhvien
    {
        public String name;
        public int age;
        public int mark;

        public void NhapThongTin()
        {
            Console.WriteLine("Nhap ten:");
            name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi:");
            age = Console.Read();
            Console.WriteLine("Nhap diem thi:");
            mark = Console.Read();
        }

        public void InThongTin()
        {
            Console.WriteLine("Ten: "+ name);
            Console.WriteLine("Tuoi:"+ age);
            Console.WriteLine("Diem thi : "+ mark);
        }

        public void BaoKetQua()
        {
            if (mark >= 4)
            {
                Console.WriteLine("Sinh vien da qua mon");
                return;
            }
            Console.WriteLine("Sinh vien khong qua mon");
               
        }
    }
}