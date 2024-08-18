using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classessss
{
    public class Messages
    {
        public string name;
        public int age;

        public Messages()
        {
            name = "no name go call constructor with parameter";

        }
        public Messages(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static void hello()
        {
            Console.WriteLine("hello how are you ");
        }

        
    }
}
