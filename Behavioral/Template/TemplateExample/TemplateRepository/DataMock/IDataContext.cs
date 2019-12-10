using System.Collections.Generic;

using TemplateRepository.DTO;

namespace TemplateRepository.DataMock
{
    public interface IDataContext
    {
        List<CompanyDto> Companies { get; set; }

        List<UserDto> Users { get; set; }

        void Connect();
    }
}