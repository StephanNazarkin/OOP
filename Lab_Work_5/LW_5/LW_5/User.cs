using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW_5
{
    public class User : IComputerInt, IPhoneInt
    {
        private string userName;

        public User()
        {
            userName = "DefaultUser";
        }

        public User(string uName)
        {
            userName = uName;
        }

        ~User()
        {

        }

        public void Program()
        {
            Console.WriteLine(userName + " is doing programming on computer.");
        }

        void IComputerInt.Calculate()
        {
            Console.WriteLine(userName + " is calculating on computer.");
        }

        void IComputerInt.Play()
        {
            Console.WriteLine(userName + " is playing games on computer.");
        }

        public void Call()
        {
            Console.WriteLine(userName + " is making phone call.");
        }

        void IPhoneInt.Calculate()
        {
            Console.WriteLine(userName + " is calculating on phone.");
        }
        void IPhoneInt.Play()
        {
            Console.WriteLine(userName + " is playing games on phone.");
        }
    }
}