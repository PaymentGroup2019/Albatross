using Albatross.Client.Services.Interfaces;
using Albatross.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Albatross.Client.Services.Fakes.RequiredServices;

namespace Albatross.Client.Services.Fakes
{
    public class FakeRoomService : IRoomService
    {
        readonly DormitoryRepo _dormitoryRepo;
        private readonly RoomRepo _roomRepo;
        public FakeRoomService(DormitoryRepo dormitoryRepo, RoomRepo roomRepo)
        {
            _dormitoryRepo = dormitoryRepo;
            _roomRepo = roomRepo;
        }

        public async Task<List<RoomType>> GetAllRoomsAsync()
        {
            return await Task.FromResult(_roomRepo.RoomTypes);
        }

        public async Task<List<DormitoryData>> GetDormitoryDatasAsync()
        {
            await Task.Delay(1000);

            return _dormitoryRepo
                .Dormitories
                .Select(dorm => new DormitoryData { Id = dorm.Id, Name = dorm.Name }).ToList();
        }

        public async Task RegisterRoomAsync(RoomTypeRegistrationViewModel model)
        {
            var dormName = _dormitoryRepo.Dormitories.Single(dorm => dorm.Id == model.DormitoryId).Name;

            var room = new RoomType
            {
                Capacity = model.Capacity,
                Beds = model.Beds,
                Dormitory = dormName,
                DormitoryId = model.DormitoryId,
                Type = model.Type,
            };

            _roomRepo.RoomTypes.Add(room);

            await Task.CompletedTask;
        }
    }
}
