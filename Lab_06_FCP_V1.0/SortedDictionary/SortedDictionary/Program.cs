using System;
using System.Collections.Generic;  // need this for Sorted Dictionary
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // sorted dictionaries are key value pairs (need to learn what that means)

            SortedDictionary<uint,string> sd = new SortedDictionary<uint,string>(); // sorts everything on the key which is a paramater, this is basically a sorted array
                // this is the name of the class, uint is the index or emp number.  string is the name

            sd.Add(999, "first value");  // add "first value" to the key 999, initializing the object
            sd.Add(1000, "second value"); //
            sd.Add(1, "last value"); // added the values and will be sorted by thte key

            bool ckey /* contiains key */ =  sd.ContainsKey(999);  // this asks if it contains this key before, tyring to add it. 
            bool cvalue /* contains value */ = sd.ContainsValue(null); //this is the reference to object, not the values in the object
            int count = sd.Count;  // gives us the number of entries

            var /* learn var */ akey = sd.Keys; // this returns a collection of keys from the sorted dictionary.  

            
            //The difference between this and dictionary is that these will be sorted, rather than just placed

            bool removed = sd.Remove(999); // tells us if it is removed or not. 

            string tempStg = null;
            bool cgetvalue = sd.TryGetValue(999, out tempStg ); // similar to try parse.  we give it a key and an out parameter, which then gets the "value" for that key if it can and puts it in the
            // the paramter.

            var values = sd.Values; // returns a collection of values in sorted key order
            
            // be careful cause these are references to the objects, not the actual values. 

            string svalue = sd[1000]; // an overloaded opperator that looks like an indexer into that array, this function goes to the array and returns the value
            sd[1000] = "stuff";  // if the key exits it will input "stuff"  but the key must exist

            // you can use an initializer lists

            foreach(var value in akey)
            {
                Console.WriteLine("Key = {0}", value);
                
            }
            
            sd.Clear();   // has extention methods which are noted by <> by using the . opperator, others are regular methods

            Console.ReadLine();

        }
    }
}
