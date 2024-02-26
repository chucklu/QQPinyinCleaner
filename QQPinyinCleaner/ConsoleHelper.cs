using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQPinyinCleaner
{
    public class ConsoleHelper
    {
        public static void WriteLine(object obj)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffzzz} {obj}");
        }
    }
}
