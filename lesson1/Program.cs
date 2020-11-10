                                                                            /*Эльвин Мамедов*/

using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getNumSum(3, 5));
        }

        /*1. Написать метод, возвращающий минимальное из трех чисел.*/
        public static int getMin(int x, int y, int z)
        {
            if(x < y && x < z)
            {
                return x;
            }
            else if(y < x && y < z)
            {
                return y;
            }
            else
            {
                return z;
            }
        }

        /*2. Написать метод подсчета количества цифр числа.*/
        public static void numCount(int x)
        {
            int count = 0;

            while(x > 1)
            {
                x = x / 10;
                count++;
            }

            Console.WriteLine(count);
        }

        /*3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
        public static void getSum()
        {
            int result = 0;
           
            Boolean flag = true;

            while(flag)
            {
                Console.WriteLine("Введите число");
                int x = Int32.Parse(Console.ReadLine());

                if(x % 2 == 0 && x > 0)
                {
                    result += x;
                }
                else if(x == 0)
                {
                    flag = false;
                }
            }

            Console.WriteLine(result);


        }

        /*4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
         * (Логин: root, Password: GeekBrains). 
         * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
         * С помощью цикла do while ограничить ввод пароля тремя попытками.*/

        public static void auth()
        {
            string login = "";
            string pass = "";

            int score = 0;

            do
            {
                Console.WriteLine("Login");
                login = Console.ReadLine();

                Console.WriteLine("Password");
                pass = Console.ReadLine();

                score++;

                if(!string.Equals("root", login) || !string.Equals("GeekBrains", pass))
                {
                    Console.WriteLine("Логин или пароль не верный");
                }

           
            }
            while (login != "root" && pass != "GeekBrains" && score < 3);
        }

        /*5. а) Написать программу, которая запрашивает массу и рост человека,
         * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
         * набрать вес или все в норме;*/

        public static void bodyMassIndex(float m, float h)
        {
            float i = m / (h * h);

            if(i <= 16)
            {
                Console.WriteLine("дефицит массы тела");
               
            }
            else if(i > 16 && i <= 18.5)
            {
                Console.WriteLine("Недостаточная (дефицит) масса тела");
            }
            else if (i > 18.5 && i <= 25)
            {
                Console.WriteLine("Норма");
            }
            else if (i > 25 && i <= 30)
            {
                Console.WriteLine("Избыточная масса тела (предожирение)");
            }
            else if (i > 30 && i <= 35)
            {
                Console.WriteLine("Ожирение");
            }
            else if (i > 35 && i <= 40)
            {
                Console.WriteLine("Ожирение резкое");
            }
            else if (i > 40)
            {
                Console.WriteLine("Очень резкое ожирение");
            }
        }

        /*7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);*/

        public static void getNum(int a, int b)
        {
            Console.Write("{0,10} ", a);
            if (a < b) getNum(a + 1, b);
        }


        /*б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/

        public static int getNumSum(int a, int b)
        {
            if (a < b) return (getNumSum(a + 1, b) + a);
            else return a;
        }

    }
}
