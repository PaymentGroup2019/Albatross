using Albatross.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Interfaces
{
    public interface IRoomService
    {
        Task<List<RoomType>> GetAllRoomsAsync();

        Task<List<DormitoryData>> GetDormitoryDatasAsync();

        Task RegisterRoomAsync(RoomTypeRegistrationViewModel model);
    }
}
