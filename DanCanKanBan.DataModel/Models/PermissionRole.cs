using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Class that represents the permissions that have been assigned to various roles.
    /// </summary>
    public class PermissionRole : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the permission that is assigned to the role.
        /// </summary>
        public Permission Permission { get; set; }

        /// <summary>
        /// Gets or sets the role that is to receive the permission.
        /// </summary>
        public ProjectRole Role { get; set; }
    }
}
