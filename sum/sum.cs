using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class sum
    {
        static void Main(string[] args)
        {
            if(args != null && args.Length >= 2)
            {
                int args1 = int.Parse(args[0]);
                int args2 = int.Parse(args[1]);
                int sum = args1 + args2;
                Console.WriteLine($"Oplossing: {args1} + {args2} = {sum}");
            }

        }
    }
}
