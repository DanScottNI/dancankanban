using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Class that represents a role for projects.
    /// </summary>
    public class ProjectRole : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the name of role.
        /// </summary>
        public string Name { get; set; }
    }
}
