using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Class that represents a team that users are assigned to.
    /// </summary>
    public class Team : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the name of the team.
        /// </summary>
        public string Name { get; set; }
    }
}
