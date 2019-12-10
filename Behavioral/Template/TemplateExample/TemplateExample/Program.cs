using System;
using System.Runtime.InteropServices.ComTypes;

using TemplateRepository;
using TemplateRepository.DataMock;
using TemplateRepository.DTO;

namespace TemplateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Design Patterns Template Method ******");
            IDataContext dataContext = new DataContext();

            var userRepository = new UserRepository(dataContext);
            Console.WriteLine();

            Console.WriteLine($"User Repository initial has {userRepository.Count()} records.");
            InsertUsers(userRepository);
            UserDto user = userRepository.GetItem(2);
            user.Address = "Cluj";
            userRepository.Save(user, "test2");

            userRepository.Delete(3);
            userRepository.GetItem(3);

            Console.WriteLine($"User Repository finally has {userRepository.Count()} records.");
            Console.WriteLine("******************** End UserRepository ****************");
            Console.WriteLine();

            var companyRepository = new CompanyRepository(dataContext);
            Console.WriteLine($"Company Repository initially has {companyRepository.Count()} records.");
            InsertCompanies(companyRepository);
            CompanyDto company = companyRepository.GetItem(1);
            company.NumberOfEmployees += 1712;
            companyRepository.Save(company,"andrei");
            companyRepository.GetItem(1);
            companyRepository.Delete(2);
            companyRepository.GetItem(2);
            Console.WriteLine($"Company Repository finally has {companyRepository.Count()} records.");
            



            Console.ReadLine();
        }

        static void InsertCompanies(CompanyRepository companyRepository)
        {
            companyRepository.Save(new CompanyDto
            {
                Address = "Cluj",
                Name = "Softvision",
                NumberOfEmployees = 1500
            }, "andrei");

            companyRepository.Save(new CompanyDto
            {
                Address = "Bucuresti",
                Name = "Endava",
                NumberOfEmployees = 1200
            }, "andrei");

            companyRepository.Save(new CompanyDto
            {
                Address = "Iasi",
                Name = "Ness",
                NumberOfEmployees = 1000
            }, "andrei");
        }

        static void InsertUsers(UserRepository userRepository)
        {
            var dragosUser = new UserDto
            {
                Address = "Iasi",
                FirstName = "Dragos",
                LastName = "Cretu"
            };

            userRepository.Save(dragosUser, "test");
            
            var andreiUser = new UserDto
            {
                Address = "Iasi",
                FirstName = "Andrei",
                LastName = "Andrei"
            };
            userRepository.Save(andreiUser, "test");

            var userDeleted = new UserDto
            {
                Address = "Adresa",
                FirstName = "Nume",
                LastName = "Prenume"
            };
            userRepository.Save(userDeleted, "test");
        }
    }
}
