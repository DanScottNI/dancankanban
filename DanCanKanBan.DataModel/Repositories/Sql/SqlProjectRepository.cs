using System;
using System.Collections.Generic;
using DanCanKanBan.DataModel.Criteria;
using DanCanKanBan.DataModel.DataModels;
using DanCanKanBan.DataModel.Interfaces;

namespace DanCanKanBan.DataModel.Repositories.Sql
{
    public class SqlProjectRepository : IGenericRepository<Project, ProjectSearchCriteria>
    {
        public Project Create(Project obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Project obj)
        {
            throw new NotImplementedException();
        }

        public Project Edit(Project obj)
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> Search(ProjectSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }
    }
}
