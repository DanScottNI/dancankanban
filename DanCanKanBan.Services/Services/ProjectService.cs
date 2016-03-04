using System.Collections.Generic;
using DanCanKanBan.DataModel.DataModels;
using DanCanKanBan.DataModel.Interfaces;
using DanCanKanBan.Services.Interfaces;

namespace DanCanKanBan.Services.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork UnitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return this.UnitOfWork.Projects.GetAll();
        }
    }
}
