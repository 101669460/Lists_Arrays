using System;

namespace Lists_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] names = new string[5];

            for(int i = 0; i < names.Length; i++){
                string name=Console.ReadLine();
                names[i] = name;
            }

            Console.WriteLine("================================");

            for(int i = 0; i < names.Length; i++){
                Console.WriteLine("Hello " + names[i]);
            }

        }
    }
}
