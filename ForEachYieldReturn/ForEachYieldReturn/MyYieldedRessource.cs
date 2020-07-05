using System;
using System.Collections.Generic;

namespace ForEachYieldReturn
{

    class MyYieldedRessource
    {
        public static IEnumerable<int> GetMyItems(bool withError)
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;

            if(withError)
            {
                throw new Exception("Exception");
            }

            yield break;
            
        }

    }
}
