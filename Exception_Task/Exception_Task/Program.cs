using Exception_Task.Exceptions;
using Exception_Task.Models;
using System.Reflection;

namespace Exception_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            #region Exception_Test
            //try 
            //{
            //    Console.WriteLine("Insert student name:");
            //    string name=Console.ReadLine();

            //    Console.WriteLine("Insert student surname:");
            //    string surname=Console.ReadLine();

            //    Student student=new Student(name,surname);

            //    Console.WriteLine("Insert student name:");
            //    string name2 = Console.ReadLine();

            //    Console.WriteLine("Insert student surname:");
            //    string surname2 = Console.ReadLine();

            //    Student student2 = new Student(name2, surname2);
            //    student.ShowInfo();
            //    student2.ShowInfo();
            //}
            //catch (SetNameException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (SetSurnameException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Reflection_Test
            //foreach (Type type in assembly.GetTypes())
            //{
            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //    Console.WriteLine(" ");
            //    Console.WriteLine("\t Type:");
            //    Console.WriteLine(type.Name);
            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //    Console.WriteLine("\t Methods:");
            //    foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            //    {
            //        Console.WriteLine(method.Name);
            //    }

            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //    Console.WriteLine("\t Fields:");
            //    foreach(FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            //    {
            //        Console.WriteLine(field.Name);
            //    }

            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //    Console.WriteLine("\t Properties:");
            //    foreach(PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            //    {
            //        Console.WriteLine(property.Name);
            //    }
            //} 
            #endregion

        }
    }
}