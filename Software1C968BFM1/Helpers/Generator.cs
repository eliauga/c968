using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1C968BFM1.Helpers
{
    public static class Generator
    {
        private const int MIN = 100;
        private const int MAX = 1000;
 
        public static int CreateNewId()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            return rand.Next(MIN, MAX);
        }
    }
}
