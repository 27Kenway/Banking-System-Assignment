using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class TimePeriod
    {
        private int seconds;

        
        public double Hours
        {
            get { return seconds / 3600.0; }  // Convert seconds to hours
            set { seconds = (int)(value * 3600); }  // Convert hours to seconds
        }

        
        public TimePeriod(int seconds)
        {
            this.seconds = seconds;
        }
    }
}
