using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArgsInput
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter parameter values.");
                Console.Read();
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i] + Environment.NewLine);
                }
                Console.Read();
            }
        }
    }
}
