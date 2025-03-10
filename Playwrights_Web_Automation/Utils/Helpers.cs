using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Utils
{
    class Helpers
    {
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        public static int GetRandomUserID()
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(1111111, 999999999);
            }
        }

    }
}
