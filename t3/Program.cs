using System;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катет 1");
            double Cathetus1;
            bool SuccesСathetus1 = double.TryParse(Console.ReadLine(), out Cathetus1);
            Console.WriteLine("Введите катет 2");
            double Cathetus2;
            bool SuccesСathetus2 = double.TryParse(Console.ReadLine(), out Cathetus2);
            double hypotenuse;
            hypotenuse = Math.Sqrt((Math.Pow(Cathetus1, 2d) + Math.Pow(Cathetus2, 2d)));
            Console.WriteLine("Hypotenuse = " + hypotenuse);
            //4
            double angle1 = 90;
            double angle2;
            double angle3;

            angle2 = Math.Atan2(Cathetus1 , Cathetus2) * 180 / Math.PI;
            angle3 = Math.Atan2(Cathetus2, Cathetus1) * 180 / Math.PI;
            Console.WriteLine("Angle1: " + angle1 + "Angle2: " + angle2 + "Angle3: " + angle3);
            Console.WriteLine(angle1+angle2+angle3);
            //5
            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
