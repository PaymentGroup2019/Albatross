using Albatross.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Interfaces
{
    public interface ISearchService
    {
        Task<List<RoomData>> SearchRoomAsync(RoomSearch query);
    }
}
