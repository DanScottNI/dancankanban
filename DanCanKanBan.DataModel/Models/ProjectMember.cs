using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Class that represents a member of a project be that a team or a single user.
    /// </summary>
    public class ProjectMember : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the project that the team/user is a member of.
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Gets or sets the user that is the member of the project.
        /// </summary>
        /// <remarks>This is not mandatory, but it is required that either the User or Team property are specified.</remarks>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the team that is the member of the project.
        /// </summary>
        /// <remarks>This is not mandatory, but it is required that either the User or Team property are specified.</remarks>
        public Team Team { get; set; }

        /// <summary>
        /// Gets or sets the role assigned to the team/user.
        /// </summary>
        public ProjectRole Role { get; set; }
    }
}
