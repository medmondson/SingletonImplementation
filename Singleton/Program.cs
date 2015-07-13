using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton firstthing = Singleton.Instance;
            Console.WriteLine(firstthing._timeCreated);

            Thread.Sleep(100);

            Singleton secondthing = Singleton.Instance;
            Console.WriteLine(secondthing._timeCreated);

            Thread.Sleep(800);

            Singleton thirdthing = Singleton.Instance;
            Console.WriteLine(thirdthing._timeCreated);

            Thread.Sleep(300);

            Singleton fourththing = Singleton.Instance;
            Console.WriteLine(fourththing._timeCreated);

            Thread.Sleep(1000);

            Singleton fifththing = Singleton.Instance;
            Console.WriteLine(fifththing._timeCreated);

            Console.ReadLine();
        }
    }
}
