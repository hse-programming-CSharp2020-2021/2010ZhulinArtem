using System;
using System.Linq;

namespace Task_3
{
    class TestOverride
    {
        public class Employee
        {
            public string name;

            // Basepay is defined as protected, so that it may be
            // accessed only by this class and derived classes.
            protected decimal basepay;

            // Constructor to set the name and basepay values.
            public Employee(string name, decimal basepay)
            {
                this.name = name;
                this.basepay = basepay;
            }

            // Declared virtual so it can be overridden.
            public virtual decimal CalculatePay()
            {
                return basepay;
            }

            public override string ToString()
            {
                return $"Employee: {name} earned: {CalculatePay()}";
            }
        }

        // Derive a new class from Employee.
        public class SalesEmployee : Employee
        {
            // New field that will affect the base pay.
            private decimal salesbonus;

            // The constructor calls the base-class version, and
            // initializes the salesbonus field.
            public SalesEmployee(string name, decimal basepay,
                decimal salesbonus) : base(name, basepay)
            {
                this.salesbonus = salesbonus;
            }

            // Override the CalculatePay method
            // to take bonus into account.
            public override decimal CalculatePay()
            {
                return basepay + salesbonus;
            }
        }

        public class PartTimeEmployee : Employee
        {
            private int workingDays;

            public PartTimeEmployee(string name, decimal basepay, int workingDays) : base(name, basepay)
            {
                this.workingDays = workingDays;
            }

            public override decimal CalculatePay()
            {
                return basepay * workingDays / 25;
            }
        }
        private static readonly Random Random = new Random();
        private static string[] names = {"David", "Garry", "Sandra", "Tom", "Andrew", "Jon", "Anna", "Bob"};
        private static void Main()
        {
            var employees = GenerateEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("Changed array:");
            employees = employees.OrderBy(employee => employee.CalculatePay()).ToArray();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static Employee[] GenerateEmployees()
        {
            var employees = new Employee[Random.Next(2,11)];
            for (var i = 0; i < employees.Length; i++)
            {
                employees[i] = Random.Next(0, 2) != 0
                    ? (Employee) new SalesEmployee(names[Random.Next(0, names.Length)], Random.Next(0, 10000000),
                        Random.Next(0, 10000000))
                    : new PartTimeEmployee(names[Random.Next(0, names.Length)], Random.Next(0, 10000000),
                        Random.Next(0, 32));
            }

            return employees;

        }
    }
}
