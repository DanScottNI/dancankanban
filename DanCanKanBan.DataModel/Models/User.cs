using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Class that represents a user.
    /// </summary>
    public class User : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}
