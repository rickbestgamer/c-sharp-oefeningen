using System;

namespace consolecalc
{
    internal class consolecalc
    {
        static void Main(string[] args)
        {
            int args1 = 0;
            string operand = null;
            int args3 = 0;
            int sum = 0;

            if (args != null && args.Length >= 3)
            {
                args1 = int.Parse(args[0]);
                operand = args[1];
                args3 = int.Parse(args[2]);

                if (operand == "+")
                {
                    sum = args1 + args3;
                }

                else if (operand == "-")
                {
                    sum = args1 - args3;
                }
                
                else if (operand == "*")
                {
                    sum = args1 * args3;
                }

                else if (operand == "/")
                {
                    sum = args1 / args3;
                }
                else
                {
                    Console.WriteLine("invalid operand");
                }
                Console.WriteLine(sum);
            }
        }
    }
}