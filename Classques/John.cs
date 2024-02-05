using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class John
    {
        private int functionCallCount = 0;

        public void CountFunction(int number)
        {
            
            functionCallCount++;
            int result = number * number;

            Console.WriteLine("Function is called. Total calls: " + functionCallCount);

            
        }
    }
}
