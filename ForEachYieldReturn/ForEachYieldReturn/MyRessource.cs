using System;
using System.Collections.Generic;

namespace ForEachYieldReturn
{
    class MyRessource
    {
        public static IEnumerator<int> GetMyItems(bool withError)
        {
            return new List<int>() { 1, 2, 3, 4, 5,6 }.GetEnumerator();
        }

    }
}
