using Albatross.Client.Services.Fakes.RequiredServices;
using Albatross.Client.Services.Interfaces;
using Albatross.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Fakes
{
    public class FakeSearchService : ISearchService
    {
        private readonly DormitoryRepo _dormRepo;
        private readonly RoomRepo _roomRepo;

        public FakeSearchService(DormitoryRepo dormRepo, RoomRepo roomRepo)
        {
            _dormRepo = dormRepo;
            _roomRepo = roomRepo;
        }

        public async Task<List<RoomData>> SearchRoomAsync(RoomSearch query)
        {
            await Task.Delay(2000);

            var roomDataQuery =
                    from rt in _roomRepo.RoomTypes
                    join dorm in _dormRepo.Dormitories
                    on rt.DormitoryId equals dorm.Id
                    //where rt.Beds == query.Beds && rt.Type == query.Type
                    select new RoomData
                    {
                        City = dorm.City,
                        Beds = rt.Beds,
                        DormitoryName = dorm.Name,
                        Price = rt.Price,
                        Id = rt.Id,
                        FromDate = query.CheckInTime,
                        ToDate = query.CheckOutTime,
                    };

            return roomDataQuery.ToList();
        }
    }
}
