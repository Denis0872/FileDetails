using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;

namespace StringArgs_Task2._1
{
    class FileDetails
    {
            static void Summarize(char[] contents)
            {
                int vowels = 0;
                int consonants = 0;
                int lines = 0;
                int OutofDate= -1;
                foreach (char current in contents)
                {
                    if (Char.IsLetter(current))
                    {
                        if ("AEIOUaeiou".IndexOf(current) != OutofDate)
                        {
                            vowels++;
                        }
                        else
                        {
                            consonants++;
                        }
                    }
                    else if (current == '\n')
                    {
                        lines++;
                    }
                }
                Console.WriteLine("Всего знаков: {0}", contents.Length);
                Console.WriteLine("Всего согласных : {0}", vowels);
                Console.WriteLine("Всего гласных: {0}", consonants);
                Console.WriteLine("Всего строк : {0}", lines);
            }

            static void Main(string[] args)
        {
            //string fileName;
            //fileName = args[0];
            FileStream stream = new FileStream(@"C:\Users\Пользователь\Desktop\ITMO\dyatel.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            reader.Close();
            Summarize(contents);
            Console.Beep();
            Console.ReadLine();
        }
    }
}
