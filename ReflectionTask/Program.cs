using System.Reflection;

namespace ReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            Type userType = typeof(User);

            User user1 = (User)Activator.CreateInstance(userType);


            FieldInfo fieldId = userType.GetField("id", BindingFlags.NonPublic | BindingFlags.Instance);
            fieldId.SetValue(user1, "");

            FieldInfo fieldName = userType.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
            fieldName.SetValue(user1, "Nezrin");

            FieldInfo fieldSurname = userType.GetField("soyad", BindingFlags.NonPublic | BindingFlags.Instance);
            fieldSurname.SetValue(user1, "Alifova");

            FieldInfo fieldAge = userType.GetField("age", BindingFlags.NonPublic | BindingFlags.Static);
            fieldAge.SetValue(null, 21);


            Console.WriteLine("ID: " + fieldId.GetValue(user1));
            Console.WriteLine("Ad: " + fieldName.GetValue(user1));
            Console.WriteLine("Soyad: " + fieldSurname.GetValue(user1));
            Console.WriteLine("Yaş: " + fieldAge.GetValue(null));
            //problemi tapanmiram((


            MethodInfo method1 = userType.GetMethod("GetFullName", BindingFlags.Public | BindingFlags.Instance);
            method1.Invoke(user1, null);
        }
    }
}
