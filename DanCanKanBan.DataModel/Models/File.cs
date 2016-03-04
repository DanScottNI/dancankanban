using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Class that represents a file that has been attached either to a project or a task.
    /// </summary>
    public class File : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the display name of the file.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the filename of the filename.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Gets or sets the MIME type for the file.
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the owner of the file.
        /// </summary>
        public User Owner { get; set; }

        /// <summary>
        /// Gets or sets the project to which the file is attached to.
        /// </summary>
        /// <remarks>This is not mandatory, but the file should either be attached to a project or a file.</remarks>
        public Project Project { get; set; }

        /// <summary>
        /// Gets or sets the task to which the file is attached to.
        /// </summary>
        /// <remarks>This is not mandatory, but the file should either be attached to a project or a file.</remarks>
        public Task Task { get; set; }
    }
}
