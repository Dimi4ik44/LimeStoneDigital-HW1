using System;
namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("------------------Задача 1---------------------");
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+name);

            //2
            Console.WriteLine("------------------Задача 2---------------------");
            double a;
            double b;
            double c;
            double x1;
            double x2;
            double discriminant;

            Console.WriteLine("Введите 'a' коэффициент");
            bool SuccesA = double.TryParse(Console.ReadLine(), out a);
            if (SuccesA && a != 0)
            {
                Console.WriteLine("Введите 'b' коэффициент");
                bool SuccesB = double.TryParse(Console.ReadLine(), out b);
                if (!SuccesB)
                {
                    Console.WriteLine("Коеффициент 'b' введен не коректно! Он будет установлен как отсутсвующий!");
                }

                Console.WriteLine("Введите 'c' коэффициент");
                bool SuccesC = double.TryParse(Console.ReadLine(), out c);
                if (!SuccesC)
                {
                    Console.WriteLine("Коеффициент 'c' введен не коректно! Он будет установлен как отсутсвующий!");
                }

                Console.WriteLine("Вы ввели " + a + "x^2+" + b + "x+" + c + "=0");

                
                if (a != 0 && b == 0 && c == 0)
                {
                    Console.WriteLine("Имеет 1 корень х1=0");
                }
                else
                {

                    discriminant = Math.Pow(b, 2) - 4 * a * c;
                    if (discriminant < 0)
                    {
                        Console.WriteLine("Не имеет корней");
                    }
                    else
                    {
                        if (discriminant == 0)
                        {
                            x1 = -b / (2 * a);
                            x2 = x1;
                            Console.WriteLine("Имеет 1 корень х1=" + x1);
                        }
                        else
                        {
                            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                            Console.WriteLine("Имеет 2 корня x1 = " + x1 + " x2 = " + x2);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Коеффициент 'a' введен не коректно или же равен 0!");
            }

            //3
            Console.WriteLine("------------------Задача 3---------------------");
            double hypotenuse;
            double Cathetus1;
            double Cathetus2;

            Console.WriteLine("Введите катет 1");
            bool SuccesСathetus1 = double.TryParse(Console.ReadLine(), out Cathetus1);
            if(!SuccesСathetus1)
            {
                Console.WriteLine("Не корректно введены данные катета 1. Значение установлено 0");
            }

            Console.WriteLine("Введите катет 2");
            bool SuccesСathetus2 = double.TryParse(Console.ReadLine(), out Cathetus2);
            if (!SuccesСathetus2)
            {
                Console.WriteLine("Не корректно введены данные катета 2. Значение установлено 0");
            }

            hypotenuse = Math.Sqrt((Math.Pow(Cathetus1, 2d) + Math.Pow(Cathetus2, 2d)));
            Console.WriteLine("Hypotenuse = " + hypotenuse);
            //4
            Console.WriteLine("------------------Задача 4---------------------");
            double angle1 = 90;
            double angle2;
            double angle3;

            angle2 = Math.Atan2(Cathetus1, Cathetus2) * 180 / Math.PI;
            angle3 = Math.Atan2(Cathetus2, Cathetus1) * 180 / Math.PI;
            Console.WriteLine("Angle1: " + angle1 + " Angle2: " + angle2 + " Angle3: " + angle3);
            Console.WriteLine(angle1 + angle2 + angle3);
            //5
            Console.WriteLine("------------------Задача 5---------------------");
            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }


}

