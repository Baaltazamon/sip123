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
<<<<<<<<< Temporary merge branch 1
            
            
            Console.ReadKey();
        }
=========
            string result = GenerateString();
            Console.WriteLine(result);
            string answer = Console.ReadLine();
            if (result == answer)
                Console.WriteLine("Все верно");
            else
                Console.WriteLine("Вы ошиблись");
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
