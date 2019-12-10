using System;

namespace TemplateRepository.DTO
{
    public class CompanyDto : IDtoTemplate
    {
        public string Address { get; set; }

        public int Id { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string Name { get; set; }

        public int NumberOfEmployees { get; set; }

        public string UserCreated { get; set; }

        public string UserUpdated { get; set; }
    }
}