using System;

namespace TemplateRepository.DTO
{
    public class UserDto : IDtoTemplate
    {
        public string Address { get; set; }

        public string FirstName { get; set; }

        public int Id { get; set; }

        public DateTime InsertDate { get; set; }

        public string LastName { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string UserCreated { get; set; }

        public string UserUpdated { get; set; }

        internal bool IsActive { get; set; }
    }
}