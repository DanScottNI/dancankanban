using System;
using DanCanKanBan.DataModel.Criteria;
using DanCanKanBan.DataModel.DataModels;
using DanCanKanBan.DataModel.Interfaces;
using DanCanKanBan.DataModel.Repositories.Sql;

namespace DanCanKanBan.DataModel.UnitOfWork
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private SqlProjectRepository projectRepository;
        private SqlUserRepository userRepository;

        public IGenericRepository<Project, ProjectSearchCriteria> Projects
        {
            get
            {
                if (this.projectRepository == null)
                {
                    this.projectRepository = new SqlProjectRepository();
                }

                return this.projectRepository;
            }
        }

        public IGenericRepository<User, UserSearchCriteria> Users
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new SqlUserRepository();
                }

                return this.userRepository;
            }
        }
    }
}
