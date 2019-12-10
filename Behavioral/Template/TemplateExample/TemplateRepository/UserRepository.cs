using System;
using System.Collections.Generic;
using System.Linq;

using TemplateRepository.DataMock;
using TemplateRepository.DTO;

namespace TemplateRepository
{
    public class UserRepository : RepositoryTemplate<UserDto>
    {
        public UserRepository(IDataContext dataContext) : base(dataContext)
        {
        }

        protected override void Delete(UserDto item)
        {
            item.IsActive = false;
        }

        protected override UserDto Get(int id)
        {
            UserDto user = _dataContext.Users.SingleOrDefault(x => x.Id == id);
            if (user != null)
            {
                string description = GetUserDescription(user);
                Console.WriteLine($"User Repository - gets {description} isActive = {user.IsActive}");
            }
            else
            {
                Console.WriteLine($"User Repository - no user with {id} was found.");
            }

            return user;
        }

        protected override IList<UserDto> GetAll()
        {
            return _dataContext.Users.Where(x => x.IsActive).ToList();
        }

        protected override UserDto Insert(UserDto item)
        {
            item.Id = _dataContext.Users.Count + 1;
            item.IsActive = true;
            _dataContext.Users.Add(item);

            string description = GetUserDescription(item);
            Console.WriteLine($"User Repository - inserted {description}");

            return item;
        }

        protected override UserDto Update(UserDto item)
        {
            UserDto matchingItem = _dataContext.Users.First(x => x.Id == item.Id);

            matchingItem.Address = item.Address;
            matchingItem.FirstName = item.FirstName;
            matchingItem.LastName = item.LastName;
            matchingItem.LastUpdateDate = item.LastUpdateDate;
            matchingItem.UserCreated = item.UserCreated;
            matchingItem.UserUpdated = item.UserUpdated;

            string description = GetUserDescription(matchingItem);
            Console.WriteLine($"User Repository - updated {description}");

            return matchingItem;
        }

        public string GetUserDescription(UserDto user)
        {
            return $"{user.Id} {user.FirstName} {user.LastName} {user.Address}";
        }
    }
}