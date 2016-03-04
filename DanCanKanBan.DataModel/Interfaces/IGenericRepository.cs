using System.Collections.Generic;

namespace DanCanKanBan.DataModel.Interfaces
{
    /// <summary>
    /// Interface for repository classes to provide a data-store agnostic way of accessing data.
    /// </summary>
    /// <typeparam name="T">Type that represents the base data object.</typeparam>
    /// <typeparam name="T1">Class that represents the search criteria.</typeparam>
    public interface IGenericRepository<T, T1>
        where T : IDataObject
        where T1 : ISearchCriteria
    {
        /// <summary>
        /// Creates a new object in the data store.
        /// </summary>
        /// <param name="obj">The object to create within the data store.</param>
        /// <returns>
        /// The object after it has been created within the data store.
        /// </returns>
        T Create(T obj);

        /// <summary>
        /// Deletes an object from the data store.
        /// </summary>
        /// <param name="obj">The object to delete from the data store.</param>
        void Delete(T obj);

        /// <summary>
        /// Edits an object in the data store.
        /// </summary>
        /// <param name="obj">The object to edit in the data store.</param>
        /// <returns>The edited object from the data store.</returns>
        T Edit(T obj);

        /// <summary>
        /// Gets an object from the data store.
        /// </summary>
        /// <param name="id">The ID of the object to return from the data store.</param>
        /// <returns>The object matching the specified ID from the data store, or null if none exists.</returns>
        T Get(int id);

        /// <summary>
        /// Gets all the objects from the data store.
        /// </summary>
        /// <returns>
        /// An IEnumerable of objects that represent all the objects in the data store.
        /// </returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Searches the data store for objects matching the search criteria.
        /// </summary>
        /// <param name="criteria">The criteria object to use to search the data store.</param>
        /// <returns>
        /// An IEnumerable of objects that represent the objects that match the search criteria in the data store.
        /// </returns>
        IEnumerable<T> Search(T1 criteria);
    }
}
