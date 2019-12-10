
using System;

namespace TemplateRepository.DTO
{
    public interface IDtoTemplate
    {
        int Id { get; set; }

        DateTime InsertDate { get; set; }

        DateTime LastUpdateDate { get; set; }

        string UserCreated { get; set; }

        string UserUpdated { get; set; }
    }
}