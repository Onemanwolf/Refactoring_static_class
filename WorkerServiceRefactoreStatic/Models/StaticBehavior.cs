using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceRefactoreStatic.Models
{
    public static class StaticBehavior
    {
        public static void Print()
        {
            var message = AnotherStaticClass.GetMessage();
            Console.WriteLine(message);
        }
    }
}
