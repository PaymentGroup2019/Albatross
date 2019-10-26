using Albatross.Client.Services.Interfaces;
using Albatross.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Fakes
{
    public class FakeRoomReservationService : IRoomReservationService
    {
        private RoomData requestedData;

        public Task<RoomData> GetRoomReservationData()
        {
            return Task.FromResult(requestedData);
        }

        public Task SetRoomReservationData(RoomData roomData)
        {
            requestedData = roomData;

            return Task.CompletedTask;
        }
    }
}
