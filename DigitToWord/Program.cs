using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitToWord dtw = new DigitToWord();
            Console.WriteLine(dtw.digitToWord(7));
            Console.WriteLine(dtw.digitToWord(356));
            Console.WriteLine(dtw.digitToWord(999));
            Console.WriteLine(dtw.digitToWord(3781));
            Console.WriteLine(dtw.digitToWord(9999));

            Console.ReadKey();
        }
    }
}
