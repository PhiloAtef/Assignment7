namespace Assignment7
{
    internal class Program
    {
        private static bool EarlierThan(HiringDate date1, HiringDate date2)
        {
            if (date1.Year > date2.Year)
            {
                return true;
            }
            if (date1.Year == date2.Year)
            {
                if (date1.Month > date2.Month)
                {
                    return true;
                }
                else if (date1.Month == date2.Month)
                {
                    if (date1.Day > date2.Day)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "philo", Gender.M, SecurityLevel.DBA, 85000, new HiringDate(21, 12, 2025));
            EmpArr[1] = new Employee(2, "mahmoud", Gender.M, SecurityLevel.Guest, 45000, new HiringDate(20, 7, 2018));
            EmpArr[2] = new Employee(3, "doha", Gender.F, SecurityLevel.SecurityOfficer, 95000, new HiringDate(10, 12, 2020));

            Console.WriteLine("before sort:");

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

            for (int i = 0; i < EmpArr.Length - 1; i++)
            {
                for (int j = 0; j < EmpArr.Length - 1 - i; j++)
                {
                    if (EarlierThan(EmpArr[j].HireDate, EmpArr[j + 1].HireDate))
                    {
                        Employee temp = EmpArr[j];
                        EmpArr[j] = EmpArr[j + 1];
                        EmpArr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("after sort:");

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }


        }
    }
}
