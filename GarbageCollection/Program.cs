using System;

namespace GarbageCollection
{
    class User
    {
        public User()
        {
            Console.WriteLine("An Instance of class created");
        }

        // Destructor
        ~User()
        {
            Console.WriteLine("An Instance of class destroyed");
        }
        static void Main(string[] args)
        {
            Details();
            GC.Collect();
            Console.ReadKey();
        }

        public static void Details()
        {
            // Created instance of class
            User user = new User();
        }
    }
}
