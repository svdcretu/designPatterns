using System;
using System.Collections.Generic;
using System.Linq;

using TemplateRepository.DataMock;
using TemplateRepository.DTO;

namespace TemplateRepository
{
    public class CompanyRepository : RepositoryTemplate<CompanyDto>
    {
        public CompanyRepository(IDataContext dataContext) : base(dataContext)
        {
        }

        protected override void Delete(CompanyDto item)
        {
            _dataContext.Companies.Remove(item);
            string description = GetDescription(item);
            Console.WriteLine($"Company Repository - Deleted {description}");
        }

        protected override CompanyDto Get(int id)
        {
            CompanyDto item = _dataContext.Companies.SingleOrDefault(x => x.Id == id);

            if (item != null)
            {
                string description = GetDescription(item);
                Console.WriteLine($"Company Repository - Gets {description}");
            }
            else
            {
                Console.WriteLine($"Company Repository - No company with Id = {id}");
            }

            return item;
        }

        protected override IList<CompanyDto> GetAll()
        {
            return _dataContext.Companies;
        }

        protected override CompanyDto Insert(CompanyDto item)
        {
            item.Id = _dataContext.Companies.Count + 1;
            _dataContext.Companies.Add(item);

            string description = GetDescription(item);
            Console.WriteLine($"Company Repository - Inserted {description}");
            return item;
        }

        protected override CompanyDto Update(CompanyDto item)
        {
            CompanyDto matchingItem = _dataContext.Companies.First(x => x.Id == item.Id);
            _dataContext.Companies.Remove(matchingItem);

            _dataContext.Companies.Add(item);

            string description = GetDescription(item);
            Console.WriteLine($"Company Repository - Updated {description}");

            return item;
        }

        public string GetDescription(CompanyDto item)
        {
            return $"{item.Id} - {item.Name} - {item.Address} has {item.NumberOfEmployees} employees.";
        }
    }
}