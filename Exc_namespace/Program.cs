using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exc_namespace
{
    public class CreditCard
    {
        public string num { get; }
        public string holder { get; }
        public string cvc { get; }
        public DateTime expDate { get; }

        public CreditCard(string cardNumber, string cardHolder, string cvc, DateTime expirationDate)
        {
           
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16 && !cardNumber.All(char.IsDigit))
                
            {
                throw new ArgumentException("Номер картки повинен містити 16 цифр.");
            }

            
            if (string.IsNullOrWhiteSpace(cardHolder) || cardHolder.Length < 5 || cardHolder.All(char.IsDigit))
            {
                throw new ArgumentException("Некоректне ПІБ власника.");
            }

            
            if (string.IsNullOrWhiteSpace(cvc) || cardNumber.Length != 16 && !cardNumber.All(char.IsDigit))
            {
                throw new ArgumentException("CVC повинен містити 3 цифри.");
            }

           
            if (expirationDate <= DateTime.Now)
            {
                throw new ArgumentOutOfRangeException(nameof(expirationDate),
                    "Термін дії картки вже минув.");
            }

            num = cardNumber;
            holder = cardHolder;
            this.cvc = cvc;
            expDate = expirationDate;
        }

        public override string ToString()
        {
            return $"Картка: **** **** **** {num.Substring(12)}, Власник: {holder}, Дійсна до: {expDate:MM/yyyy}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ex1");
            //try
            //{
            //    int a = 0;
            //    a = int.Parse(Console.ReadLine());
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Console.WriteLine("\nEx2");

            try
            {
                CreditCard card = new CreditCard(
                    "12345678",
                    "Іван Петренко",
                    "123",
                    new DateTime(2028, 12, 31)
                );

                Console.WriteLine(card);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }

            Console.WriteLine("\nEx3");

            try
            {
                Console.Write("Введіть вираз: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Вираз не може бути порожнім.");

                string[] numbers = input.Split('*');

                if (numbers.Length == 0)
                    throw new FormatException("Неправильний формат виразу.");

                int result = 1;

                foreach (string num in numbers)
                {
                    if (!int.TryParse(num, out int value))
                        throw new FormatException("У виразі повинні бути лише цілі числа та оператор *.");

                    result *= value;
                }

                Console.WriteLine("Результат: " + result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Помилка формату: " + ex.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Сталося переповнення числа.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Інша помилка: " + ex.Message);
            }

        }
    }
}
