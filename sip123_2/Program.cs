using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sip123_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = GenerateString();
            char g;
            bool h;
            int trying = 0;
            Console.WriteLine(result);
            foreach (var c in result)
            {
                do
                {
                    
                    g = Console.ReadKey().KeyChar;
                    if (g == c)
                        h = false;
                    else
                    {
                        h = true;
                        Console.Write("\b");
                        trying++;
                        System.Media.SystemSounds.Beep.Play();
                    }
                        
                } while (h);
            }
            Console.WriteLine($"\nВерно!\nОшибок сделано: {trying}.");
            Console.ReadKey();
        }
        static public string GenerateString()
        {
            Random rnd = new Random();
            string pool = "qwertyuiop[]asdfghjkl;'zxcvbnm,.";
            string c = "";
            for (int i=0;i<10;i++)
            {
                c+=pool[rnd.Next(pool.Length)];
            }
            return c;
        }
    }
}
