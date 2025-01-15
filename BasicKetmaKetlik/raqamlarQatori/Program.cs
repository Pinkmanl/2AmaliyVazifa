using System;
namespace raqamlarQatori
{
    class raqamlarQatori
    {
        static void Main()
        {
            int add = 0;
            Console.WriteLine("bu N gacha bo'gan hamma sonni qo'shadigan dastur");
            Console.WriteLine("sonni kiriting");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                add += i;
            }
            System.Console.WriteLine("Natija = " + add);
        }
    }
}
