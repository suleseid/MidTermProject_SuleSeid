using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_SuleSeid
{
    public class Program
    { 
        // Declare the global linked list
        static LinkedList<string> StoreDirectory;
        static void Main(string[] args)
        {
            //Preload();

            Console.WriteLine("Contains");
            Console.WriteLine(StoreDirectory.Contains("Aqua Adventures").ToString()); // True
            Console.WriteLine(StoreDirectory.Contains("Zara").ToString()); // False
            Console.WriteLine("Print");
            //PrintStoreNames(); // print the store names
            // Create a new node with the store name
            var newNode = new LinkedListNode<string>("New Store Name");
            StoreDirectory.AddLast(newNode);// print the store names
        }
      
    }
    
}
