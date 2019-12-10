
using System;
using System.Collections.Generic;

using TemplateRepository.DataMock;
using TemplateRepository.DTO;

namespace TemplateRepository
{
    public abstract class RepositoryTemplate<T> where T : IDtoTemplate
    {
        protected readonly IDataContext _dataContext;

        protected RepositoryTemplate(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public T GetItem(int id)
        {
            Connect();
            return Get(id);
        }

        public IList<T> GetItems()
        {
            Connect();
            return GetAll();
        }

        public T Save(T item, string user)
        {
            Connect();
            T result;
            if (item.Id > 0)
            {
                item.LastUpdateDate = DateTime.Now;
                item.UserUpdated = user;
                result = Update(item);
            }
            else
            {
                item.UserCreated = user;
                item.InsertDate = DateTime.Now;
                result = Insert(item);
            }

            return result;
        }

        public void Delete(int itemId)
        {
            Connect();
            T item = Get(itemId);
            if (item != null)
            {
                Delete(item);
            }
        }

        public int Count()
        {
            IList<T> allItems = GetItems();
            return allItems.Count;
        }

        protected virtual void Connect()
        {
            _dataContext.Connect();
        }

        protected abstract void Delete(T item);

        protected abstract T Get(int id);

        protected abstract IList<T> GetAll();

        protected abstract T Insert(T item);

        protected abstract T Update(T item);
    }
}