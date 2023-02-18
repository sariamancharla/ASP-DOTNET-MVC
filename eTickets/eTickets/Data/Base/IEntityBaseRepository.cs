using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class,IEntityBase,new()
    {

        //IEnumerable<Actor> GetAll();
        Task<IEnumerable<T>> GetAll();
        //As part of movie table we need to fetch the cinema name 
        //as movie.cinemaid=cinema.id so we need to add include to do equi join of both tables
        Task<IEnumerable<T>> GetAll(params Expression<Func<T,Object>>[] includeProperties);

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
