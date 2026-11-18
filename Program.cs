using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema2
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        private double Dev(double a, double b)
        {
            return a / b;
        }
        public class user
        {     
        
            public int Id { get; set; }

            public string Login { get; set; } = string.Empty;

            public string Email { get; set; } = string.Empty;

            public string PasswordHash { get; set; } = string.Empty;

            public string FullName { get; set; } = string.Empty;

            public string Phone { get; set; }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                int aint = Convert.ToInt32(a);
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                int bint = Convert.ToInt32(b);
                Calculator calculator = new Calculator();
                Console.WriteLine($"Сложение {aint} + {bint} = {calculator.Add(aint, bint)}");
                if (b == 0)
                {
                    Console.WriteLine("Делить на ноль нельзя!");
                }
                else
                {
                    Console.WriteLine($"Частное {a} / {b} = {calculator.Dev(a, b)}");
                }
                user user = new user();
                
                    user.Id = 1;
                    Console.WriteLine("Введите ваш логин");
                    user.Login = Console.ReadLine();
                    Console.WriteLine("Введите ваш Е-майл");
                    user.Email = Console.ReadLine();
                    Console.WriteLine("Введите ваш пароль");
                    user.PasswordHash = Console.ReadLine();
                    Console.WriteLine("Введите ФИО");
                    user.FullName = Console.ReadLine();
                    Console.WriteLine("Введите ваш номер телефона");
                    user.Phone = Console.ReadLine();
      
                Console.WriteLine();
                Console.WriteLine("Пользователь:");
                Console.WriteLine($"Id: {user.Id}");
                Console.WriteLine($"Login: {user.Login}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"FullName: {user.FullName}");
                Console.WriteLine($"Phone: {user.Phone}");
            }

           
        }
    }
}
