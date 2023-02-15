using eTickets.Data.Base;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    //public interface IActorsService:IEntityBaseRepository<Actor>
    {
        //Moved the code to a common repository
        ////IEnumerable<Actor> GetAll();
        //Task<IEnumerable<Actor>> GetAll();

        //Task<Actor> GetByIdAsync(int id);

        //Task AddAsync(Actor actor);

        //Task<Actor> UpdateAsync(int id, Actor newActor);

        //Task DeleteAsync(int id);
    }
}
