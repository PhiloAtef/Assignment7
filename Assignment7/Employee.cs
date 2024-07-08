using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public enum Gender
    {
        M,
        F
    }

    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }

    public class Employee
    {
        public int id;
        private string name;
        private double salary;
        private HiringDate hireDate;
        private Gender gender;
        private SecurityLevel securityLevel;

        public int ID
        {
            get => id;
            set
            {
                if (value <= 0)
                {
                    id = -1;
                }
                    
                id = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    name = "Null Name";
                }
                    
                name = value;
            }
        }

        public Gender Gender
        {
            get => gender;
            set
            {
                if (IsValidGender(value))
                {
                    gender = value;
                }
                else
                {
                    gender = Gender.M; //default value
                }
            }
        }

        public double Salary
        {
            get => salary;
            set
            {
                if (value < 0) { salary = 0; }
                salary = value;
            }
        }

        public HiringDate HireDate
        {
            get => hireDate;
            set => hireDate = value ?? new HiringDate(0,0,0);
        }

        public SecurityLevel SecurityLevel
        {
            get => securityLevel;
            set => securityLevel = value;
        }

        public static bool IsValidGender(Gender gender)
        {
            return Enum.IsDefined(typeof(Gender), gender);
        }

        public Employee(int id, string name, Gender gender, SecurityLevel securityLevel, double salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityLevel}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
        }



    }
}
