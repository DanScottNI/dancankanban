namespace DanCanKanBan.DataModel.Interfaces
{
    /// <summary>
    /// Interface for data objects.
    /// </summary>
    public interface IDataObject
    {
        /// <summary>
        /// Gets or sets the ID of the data object.
        /// </summary>
        int? Id { get; set; }

        /// <summary>
        /// Gets or sets the version of the data object.
        /// </summary>
        long RowVersion { get; set; }

        /// <summary>
        /// Gets or sets whether or not the object has been marked as deleted.
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
