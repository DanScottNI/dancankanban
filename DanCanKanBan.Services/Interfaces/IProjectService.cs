using System.Collections.Generic;
using DanCanKanBan.DataModel.DataModels;

namespace DanCanKanBan.Services.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<Project> GetAllProjects();
    }
}
