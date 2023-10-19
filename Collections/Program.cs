using System;
using System.Collections; // Arrays
using System.Collections.Generic; // Dictionaries

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Region allows us to collapse parts of code
            #region ArrayList Code 

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Bob");
            arrayList.Add(1);

            Console.WriteLine("Count: {0}", arrayList.Count);

            #endregion
        }
    }
}
