using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    public class Project : BaseDataObject
    {
        public string Name { get; set; }

        public ProjectVisibility Visibility { get; set; }
    }
}
