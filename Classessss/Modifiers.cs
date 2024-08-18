using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classessss
{
    internal class Modifiers
    {
        public void add(params int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public void ChangeValue( out int value)
        {
            value = 10;
        }
    }
}
