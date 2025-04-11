using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask
{
    class User
    {
            private string id;
            private string name;
            private string surname;
            private static string age;
            public User()
            {

            }
            public void GetFullName()
            {
                Console.WriteLine($"{name} {surname}");
            }
            public static void ChangeAge(string newage)
            {
                age = newage;
            }     
    }
}
