using Exception_Task.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Task.Models
{
    internal class Student
    {
		private string _name;

		public string Name
		{
			get 
			{ 
				return _name; 
			}
			set 
			{ 
				if(value.Length >= 3)
				{
					_name = value;
				} 
				else
				{
					throw new SetNameException("Incorrect name length");
				}
			}
		}

		private string _surname;

		public string Surname
		{
			get 
			{ 
				return _surname; 
			}
			set 
			{ 
				if( value.Length >= 6)
				{
					_surname = value;
				} 
				else
				{
					throw new SetSurnameException("Incorrect surname length");
				}
			}
		}

		private static int _counter;
        public int Id { get; }

        public Student(string name, string surname)
        {
            Name = name;
			Surname = surname;
			_counter++;
			Id = _counter;
        }

		public void ShowInfo()
		{
			Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}");
		}
    }
}
