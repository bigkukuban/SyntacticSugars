using System;

namespace ForEachYieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {

            var element = MyRessource.GetMyItems(true);
            while (element.MoveNext())
            {
                Console.WriteLine("Noch Element:  "+element.Current);
            }

        }
    }
}
