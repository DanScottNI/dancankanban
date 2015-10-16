using System;
using DanCanKanBan.DataModel.Interfaces;

namespace DanCanKanBan.DataModel.Common
{
    /// <summary>
    /// Class that represents the basic data object in the system.
    /// </summary>
    public class BaseDataObject : IDataObject
    {
        /// <summary>
        /// Gets or sets the ID of the object.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the GUID for the object.
        /// </summary>
        public Guid UniqueIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the version of the row.
        /// </summary>
        public long RowVersion { get; set; }

        /// <summary>
        /// Gets or sets whether or not the object has been marked as been deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
