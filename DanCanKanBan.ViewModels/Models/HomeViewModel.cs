using System.Collections.ObjectModel;

namespace DanCanKanBan.ViewModels.Models
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel() : base()
        {
            this.Projects = new Collection<ProjectGridRowModel>();
        }

        public Collection<ProjectGridRowModel> Projects { get; private set; }
    }
}
