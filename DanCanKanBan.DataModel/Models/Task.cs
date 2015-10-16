using DanCanKanBan.DataModel.Common;

namespace DanCanKanBan.DataModel.DataModels
{
    /// <summary>
    /// Class that represents a task in a particular task board.
    /// </summary>
    public class Task : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the Task Board that the task belongs to.
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Gets or sets the title of the task.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the user who the task is assigned to.
        /// </summary>
        public User AssignedTo { get; set; }
    }
}
