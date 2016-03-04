using System;
using System.Collections.Generic;
using DanCanKanBan.DataModel.Criteria;
using DanCanKanBan.DataModel.DataModels;
using DanCanKanBan.DataModel.Interfaces;

namespace DanCanKanBan.DataModel.Repositories.Sql
{
    public class SqlUserRepository : IGenericRepository<User, UserSearchCriteria>
    {
        public User Create(User obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public User Edit(User obj)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Search(UserSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }
    }
}
