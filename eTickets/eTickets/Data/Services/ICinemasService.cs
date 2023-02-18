using eTickets.Data.Base;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface ICinemasService: IEntityBaseRepository<Cinema>
    //public interface IProducerService
    {
    //    Task<IEnumerable<Producer>> GetAll();

    //    Task<Producer> GetByIdAsync(int id);

    //    Task AddAsync(Producer producer);

    //    Task<Producer> UpdateAsync(int id, Producer newProducer);

    //    Task DeleteAsync(int id);
    }
}