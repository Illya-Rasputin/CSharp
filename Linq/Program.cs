using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Company
    { 
        public string Name { get; set; }
        public DateTime Founded { get; set; } = DateTime.Now;
        public string Industry { get; set; }
        public Worker[] Employees { get; set; }
        public string Location { get; set; }
        public string Founder { get; set; }

        public override string ToString()
        {
            return $"Company: {Name}, Founded: {Founded.ToShortDateString()}, Industry: {Industry}, Location: {Location}, Founder: {Founder}, Employees: {Employees.Length}";
        }

    }
    public class Worker
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public string Company { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new List<Company>
            {new Company
                {
                    Name = "FoodMarket",
                    Founded = DateTime.Now.AddYears(-5),
                    Industry = "Marketing",
                    Location = "London",
                    Founder = "John White",
                    Employees = new Worker[150]
                },

                new Company
                {
                    Name = "Tech Solutions",
                    Founded = DateTime.Now.AddYears(-1),
                    Industry = "IT",
                    Location = "Kyiv",
                    Founder = "Ivan Black",
                    Employees = new Worker[90]
                },

                new Company
                {
                    Name = "White Food Company",
                    Founded = DateTime.Now.AddYears(-3),
                    Industry = "Food",
                    Location = "London",
                    Founder = "Emma Black",
                    Employees = new Worker[250]
                },

                new Company
                {
                    Name = "Global Marketing",
                    Founded = DateTime.Now.AddMonths(-4),
                    Industry = "Marketing",
                    Location = "Paris",
                    Founder = "Olivia Green",
                    Employees = new Worker[320]
                },

                new Company
                {
                    Name = "Food & IT Group",
                    Founded = DateTime.Now.AddDays(-123),
                    Industry = "IT",
                    Location = "Berlin",
                    Founder = "Michael White",
                    Employees = new Worker[110]
                },

                new Company
                {
                    Name = "White Tech",
                    Founded = DateTime.Now.AddYears(-10),
                    Industry = "IT",
                    Location = "London",
                    Founder = "Daniel Black",
                    Employees = new Worker[500]
                }
            };
            var workers = new List<Worker>
            {
                new Worker
                    {
                        Name = "Lionel",
                        Number = "231111",
                        Email = "di.lionel@gmail.com",
                        Position = "Manager",
                        Salary = 5000,
                        Company = "FoodMarket"
                    },

                    new Worker
                    {
                        Name = "Anna",
                        Number = "451234",
                        Email = "anna@gmail.com",
                        Position = "Developer",
                        Salary = 3500,
                        Company = "Tech Solutions"
                    },

                    new Worker
                    {
                        Name = "David",
                        Number = "239999",
                        Email = "dimon@yahoo.com",
                        Position = "Manager",
                        Salary = 6200,
                        Company = "White Tech"
                    },

                    new Worker
                    {
                        Name = "Sophia",
                        Number = "771245",
                        Email = "di.sophia@gmail.com",
                        Position = "Designer",
                        Salary = 2800,
                        Company = "Global Marketing"
                    },

                    new Worker
                    {
                        Name = "Michael",
                        Number = "234567",
                        Email = "mike@gmail.com",
                        Position = "Manager",
                        Salary = 7000,
                        Company = "Food & IT Group"
                    },

                    new Worker
                    {
                        Name = "Lionel",
                        Number = "888888",
                        Email = "lionel@gmail.com",
                        Position = "Tester",
                        Salary = 3100,
                        Company = "FoodMarket"
                    },

                    new Worker
                    {
                        Name = "Diana",
                        Number = "230045",
                        Email = "diana@gmail.com",
                        Position = "HR",
                        Salary = 4200,
                        Company = "FoodMarket"
                    },

                    new Worker
                    {
                        Name = "Chris",
                        Number = "987654",
                        Email = "di.chris@gmail.com",
                        Position = "Manager",
                        Salary = 8100,
                        Company = "White Food Company"
                    },

                    new Worker
                    {
                        Name = "Olivia",
                        Number = "235500",
                        Email = "olivia@yahoo.com",
                        Position = "Accountant",
                        Salary = 3900,
                        Company = "Global Marketing"
                    },

                    new Worker
                    {
                        Name = "Daniel",
                        Number = "120034",
                        Email = "daniel@gmail.com",
                        Position = "Developer",
                        Salary = 5400,
                        Company = "Tech Solutions"
                    },

                    new Worker
                    {
                        Name = "Emily",
                        Number = "236666",
                        Email = "di.emily@gmail.com",
                        Position = "Manager",
                        Salary = 9100,
                        Company = "White Tech"
                    },

                    new Worker
                    {
                        Name = "Mark",
                        Number = "555123",
                        Email = "mark@gmail.com",
                        Position = "Engineer",
                        Salary = 4700,
                        Company = "Food & IT Group"
                    },

                    new Worker
                    {
                        Name = "Lionel",
                        Number = "237777",
                        Email = "di.lionel2@gmail.com",
                        Position = "Manager",
                        Salary = 6600,
                        Company = "White Food Company"
                    },

                    new Worker
                    {
                        Name = "Victoria",
                        Number = "332211",
                        Email = "victoria@gmail.com",
                        Position = "Designer",
                        Salary = 3000,
                        Company = "Global Marketing"
                    },

                    new Worker
                    {
                        Name = "Andrew",
                        Number = "238888",
                        Email = "di.andrew@gmail.com",
                        Position = "Support",
                        Salary = 2700,
                        Company = "Tech Solutions"
                    }
            };

            var cmps = companies;

            Console.WriteLine("All companies:");
            foreach (var company in cmps)
            {
                Console.WriteLine(company.Name);
            }
            var food = companies
                .Where(c => c.Name.Contains("Food"));

            Console.WriteLine("\nCompanies with 'Food' in name:");
            foreach (var company in food)
            {
                Console.WriteLine(company.Name);
            }
            var marketingCompanies = companies
                .Where(c => c.Industry == "Marketing");

            Console.WriteLine("\nMarketing companies:");
            foreach (var company in marketingCompanies)
            {
                Console.WriteLine(company.Name);
            }


            
            var marketingOrIT = companies
                .Where(c => c.Industry == "Marketing" || c.Industry == "IT");

            Console.WriteLine("\nMarketing or IT companies:");
            foreach (var company in marketingOrIT)
            {
                Console.WriteLine(company.Name);
            }


            
            var moreThan100 = companies
                .Where(c => c.Employees.Length > 100);

            Console.WriteLine("\nCompanies with more than 100 employees:");
            foreach (var company in moreThan100)
            {
                Console.WriteLine(company.Name);
            }


            
            var between100and300 = companies
                .Where(c => c.Employees.Length >= 100 &&
                            c.Employees.Length <= 300);

            Console.WriteLine("\nCompanies with employees between 100 and 300:");
            foreach (var company in between100and300)
            {
                Console.WriteLine(company.Name);
            }


            
            var london = companies
                .Where(c => c.Location == "London");

            Console.WriteLine("\nLondon companies:");
            foreach (var company in london)
            {
                Console.WriteLine(company.Name);
            }


            
            var founderWhite = companies
                .Where(c => c.Founder.Contains("White"));

            Console.WriteLine("\nCompanies with founder White:");
            foreach (var company in founderWhite)
            {
                Console.WriteLine(company.Name);
            }


            
            var older2 = companies
                .Where(c => (DateTime.Now - c.Founded).TotalDays > 365 * 2);

            Console.WriteLine("\nCompanies founded more than 2 years ago:");
            foreach (var company in older2)
            {
                Console.WriteLine(company.Name);
            }


            
            var f123Days = companies
                .Where(c => (DateTime.Now - c.Founded).Days == 123);

            Console.WriteLine("\nCompanies founded 123 days ago:");
            foreach (var company in f123Days)
            {
                Console.WriteLine(company.Name);
            }


            
            var blackFounderWhiteName = companies
                .Where(c => c.Founder.Contains("Black") &&
                            c.Name.Contains("White"));

            Console.WriteLine("\nFounder Black and company name contains 'White':");
            foreach (var company in blackFounderWhiteName)
            {
                Console.WriteLine(company.Name);
            }

            var companyWorkers = workers
    .Where(w => w.Company == "FoodMarket");

            Console.WriteLine("Workers from FoodMarket:");
            foreach (var worker in companyWorkers)
            {
                Console.WriteLine(worker.Name);
            }


            // 2. Працівники певної фірми із зарплатою більшою заданої
            var highSalaryWorkers = workers
                .Where(w => w.Company == "White Tech" &&
                            w.Salary > 6000);

            Console.WriteLine("\nWorkers from White Tech with salary > 6000:");
            foreach (var worker in highSalaryWorkers)
            {
                Console.WriteLine($"{worker.Name} - {worker.Salary}");
            }


            // 3. Працівники всіх фірм з посадою "Manager"
            var managers = workers
                .Where(w => w.Position == "Manager");

            Console.WriteLine("\nManagers:");
            foreach (var worker in managers)
            {
                Console.WriteLine($"{worker.Name} - {worker.Company}");
            }


            // 4. Працівники, в яких телефон починається з "23"
            var phone23 = workers
                .Where(w => w.Number.StartsWith("23"));

            Console.WriteLine("\nWorkers with phone starting with 23:");
            foreach (var worker in phone23)
            {
                Console.WriteLine($"{worker.Name} - {worker.Number}");
            }


            // 5. Працівники, в яких Email починається з "di"
            var emailDi = workers
                .Where(w => w.Email.StartsWith("di"));

            Console.WriteLine("\nWorkers with email starting with 'di':");
            foreach (var worker in emailDi)
            {
                Console.WriteLine($"{worker.Name} - {worker.Email}");
            }


            // 6. Працівники з ім'ям Lionel
            var lionels = workers
                .Where(w => w.Name == "Lionel");

            Console.WriteLine("\nWorkers with name Lionel:");
            foreach (var worker in lionels)
            {
                Console.WriteLine($"{worker.Name} - {worker.Company}");
            }
        }
    }
}
