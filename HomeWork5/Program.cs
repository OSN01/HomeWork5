using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любое предложение: ");
            string slova = Console.ReadLine();

            //Задание 1.
            WordsOnLine(slova);

            //Задание 2
            ReversWords(slova);

            Console.ReadKey();
        }
        /// <summary>
        /// метод вывода каждого слова из предложения в строку
        /// </summary>
        /// <param name="value"></param>
        static void WordsOnLine(string value)
        {
            String[] words = value.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
        /// <summary>
        /// Метод написания предложения в обратном порядке
        /// </summary>
        /// <param name="slova"></param>
        static void ReversWords(string value)
        {
            String[] arr = CutTheWords(value);
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        /// <summary>
        /// разделение на слова и возврат массива слов
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string[] CutTheWords(string value)
        {
            String[] words = value.Split(' ');
            return words;
        }
    }
}
