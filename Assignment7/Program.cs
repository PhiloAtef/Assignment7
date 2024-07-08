namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "philo", Gender.M, SecurityLevel.DBA, 85000, new HiringDate(21, 12, 2025));
            EmpArr[1] = new Employee(2, "mahmoud", Gender.M, SecurityLevel.Guest, 45000, new HiringDate(20, 7, 2018));
            EmpArr[2] = new Employee(3, "doha", Gender.F, SecurityLevel.SecurityOfficer, 95000, new HiringDate(10, 12, 2020));
        }
    }
}
