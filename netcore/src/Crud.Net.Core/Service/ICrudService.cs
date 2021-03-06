using System.Threading.Tasks;

namespace Crud.Net.Core.Service
{
    /// <summary>
    /// Generic application-level interface for CRUD operations
    /// </summary>
    public interface ICrudService<TEntity, TDto> 
    {
        /// <summary>
        /// Gets the business object by id
        /// </summary>
        /// <param name="id">The id of the entity</param>
        /// <returns>The dto</returns>
        Task<TDto> GetByIdAsync(long id);
        
        /// <summary>
        /// Adds the business object to the data store
        /// </summary>
        /// <param name="dto">The business object to add</param>
        /// <returns>The new business object</returns>
        Task<TDto> AddAsync(TDto dto);
        
        /// <summary>
        /// Updates the business object
        /// </summary>
        /// <param name="dto">The business object to modify</param>
        /// <returns>The modified business object</returns>
        Task<TDto> UpdateAsync(TDto dto);
        
        /// <summary>
        /// Deletes the business object by id
        /// </summary>
        /// <param name="id">The id of the business object</param>
        Task<bool> DeleteAsync(long id);
    }
}
