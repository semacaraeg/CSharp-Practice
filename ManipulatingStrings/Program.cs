using System;
using System.IO;
using System.Text;

namespace ManipulatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder mystr = new StringBuilder();
            for (int i = 0; i < 10000; i++) {
                mystr.Append("X");
            }

            Console.WriteLine(mystr);

            var stringWriter = new StringWriter();


        }
    }
}
