using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace today
{
    internal class today
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(today);
        }
    }
}
