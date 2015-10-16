using DanCanKanBan.DataModel.Criteria;
using DanCanKanBan.DataModel.DataModels;

namespace DanCanKanBan.DataModel.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User, UserSearchCriteria> Users { get; }
    }
}
