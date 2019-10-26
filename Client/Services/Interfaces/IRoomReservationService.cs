using Albatross.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Interfaces
{
    public interface IRoomReservationService
    {
        Task SetRoomReservationData(RoomData roomData);

        Task<RoomData> GetRoomReservationData();
    }
}
