using Albatross.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Interfaces
{
    public interface IDormitoryService
    {
        Task<List<Dormitory>> GetAllDormitoriesAsync();

        Task RegisterDormitory(DormitoryRegistrationViewModel model);
    }
}
