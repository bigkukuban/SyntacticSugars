using System;

namespace ForEachYieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {

            var foundItems = MyYieldedRessource.GetMyItems(true);

            #region foreach syntactic sugar
            /*
             * Ienumrator<int> rator = MyList.GetEnumrator();
               try
               {
                  while(rator.MoveNext())
                  {
                      int i = rator.Current; 
                      Console.WriteLine(i); 
                  }
               }
               finally
               {
                   rator.Dispose()
               }
             * 
            */
            #endregion

            foreach (var element in foundItems)
            {
                Console.WriteLine("Noch Element:  "+element);
            }

        }
    }
}
