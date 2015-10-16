namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Enumerated type that represents the project's visibility.
    /// </summary>
    public enum ProjectVisibility
    {
        /// <summary>
        /// The project is publically available to all logged in users.
        /// </summary>
        Public = 0,

        /// <summary>
        /// The project is only available to members of the project.
        /// </summary>
        Private = 1
    }
}