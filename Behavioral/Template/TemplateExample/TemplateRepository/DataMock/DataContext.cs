using System.Collections.Generic;
using System.Linq;

using TemplateRepository.DTO;

namespace TemplateRepository.DataMock
{
    public class DataContext : IDataContext
    {
        public List<CompanyDto> Companies { get; set; }

        public List<UserDto> Users { get; set; }

        public void Connect()
        {
            if (Companies == null || !Companies.Any())
            {
                Companies = new List<CompanyDto>();
            }

            if (Users == null || !Users.Any())
            {
                Users = new List<UserDto>();
            }
        }
    }
}