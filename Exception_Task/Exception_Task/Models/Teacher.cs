using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Task.Models
{
    internal class Teacher
    {
        private string _name;

        private void ShowInfo(string name)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Teacher teacher = new Teacher();
            Type type = typeof(Teacher);
            var field = type.GetField("_name", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(teacher, name);
            Console.WriteLine($"Name: {name}");
        }
    }
}
