using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextRead();
            Console.ReadLine();
        }
        public static async void TextRead()
        {
            using (StreamReader stream = new StreamReader("text.txt"))
            {
                string text = await stream.ReadToEndAsync();
                Console.WriteLine(text);
            }
        } 
    }
}