using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("User");
            u.Program();
            ((IComputerInt)u).Calculate();
            ((IComputerInt)u).Play();
            u.Call();
            ((IPhoneInt)u).Calculate();
            ((IPhoneInt)u).Play();
            Console.ReadKey();
        }
    }
}
