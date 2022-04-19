using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork.Models
{
    class Company
    {
        private string _name;

        public string Name 
        {
            get => _name;
            set
            {
                while (true)
                {
                    bool checkSimvol = true;

                    if (char.IsUpper(value[0]))
                    {
                        foreach (char item in value)
                        {
                            if (!char.IsLetter(item) && !char.IsDigit(item) && !char.IsWhiteSpace(item))
                            {
                                Console.WriteLine("Herf Reqem Ve Bosluqdan Hec Bir Simvol Ola Bilmez");
                                Console.WriteLine("Yeniden Daxil Et");
                                value = Console.ReadLine();
                                checkSimvol = false;
                                break;
                            }
                        }

                        if (checkSimvol)
                        {
                            _name = value;
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ilk Herif Boyuk Olmalidir #");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        public int Limit;
        private Employee[] _employees;

        public Company()
        {
            _employees = new Employee[0];
        }

        public void AddEmoployee(Employee employee)
        {
            if (Limit > _employees.Length)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
                return;
            }
            Console.WriteLine("Elaqe Saxliyaciq In Sha Allah");
        }

        public Employee[] GetEmployees() => _employees;
    }
}
