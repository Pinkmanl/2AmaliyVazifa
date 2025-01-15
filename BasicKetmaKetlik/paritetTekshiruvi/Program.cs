using System;
namespace paritetTekshiruvi
{
    class paritetTekshiruvi
    {
        static void Main()
        {
            Console.WriteLine("bu dastur sonlarni juft yoki toqlikga tekshiradi");
            System.Console.WriteLine("Input =");
            int namber = Convert.ToInt32(Console.ReadLine());
            string juftToq;
            if(namber % 2 == 0)
            {
                juftToq="juft";
            }else
            {
                juftToq="toq";
            }
            Console.WriteLine("Output ="+ juftToq);
        }
    }
}