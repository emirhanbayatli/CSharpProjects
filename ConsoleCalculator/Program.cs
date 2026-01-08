using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
       static void Main(string[] args)


        {
            decimal result = 0; 

            Console.WriteLine("Birinci sayıyı giriniz : ");
            decimal firstNumber =  decimal.Parse(Console.ReadLine());
            Console.WriteLine("İşlem seçiniz (+ - * /): ");
            Console.WriteLine("1 Toplama");
            Console.WriteLine("2 Çıkartma");
            Console.WriteLine("3 Çarpma");
            Console.WriteLine("4 Bölme");
            decimal operation = decimal.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz : ");
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            if (operation == 4 &&secondNumber == 0)
             {
                Console.WriteLine("Bir sayi 0'a bolunemez.");
                return;
             }





            //if (operation == 1)
            //{
            //    result = firstNumber + secondNumber;
            //}
            //else if (operation == 2)
            //{
            //    result = firstNumber - secondNumber;
            //}
            //else if (operation == 3)
            //{
            //    result = firstNumber * secondNumber;
            //}
            //else if (operation == 4)
            //{
            //    result = firstNumber / secondNumber;
            //}
            //else
            //{
            //    Console.WriteLine("Hatali bir giris denediniz ");
            //}

            //switch (operation)
            //{
            //    case 1:
            //        result = firstNumber + secondNumber;
            //        break;
            //    case 2:
            //        result = firstNumber - secondNumber;
            //        break;
            //    case 3:
            //        result = firstNumber * secondNumber;
            //        break;
            //    case 4:
            //        result = firstNumber / secondNumber;
            //        break;
            //    default:
            //        Console.WriteLine("Hatali bir giris denediniz ");
            //        break;

            //}


            switch (operation)
            {
                case 1:
                    result = Add( firstNumber , secondNumber);
                    break;
                case 2:
                    result = Subtract(firstNumber, secondNumber);
                    break;
                case 3:
                    result = Multiply(firstNumber, secondNumber);
                    break;
                case 4:
                    result = Divide(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Hatali bir giris denediniz ");
                    break;

            }


            Console.WriteLine("Sonuc : " + result);




        }
       static decimal Add(decimal number1 , decimal number2)
       {
        return number1 + number2;
       }
      static decimal Subtract(decimal number1, decimal number2)
      {
            return number1 - number2;
      }
      static decimal Multiply(decimal number1, decimal number2)
      {
            return number1 * number2;
      }
      static decimal Divide(decimal number1, decimal number2)

      {
            if (number2  == 0)
            {
                Console.WriteLine("Hatali bir giris yaptiniz sayi 0`a bolunemez.");
                return 0;
            }

            return number1 / number2;
      }
    }
}
