using Albatross.Client.Services.Fakes.RequiredServices;
using Albatross.Client.Services.Interfaces;
using Albatross.Shared;
using System.Linq;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Fakes
{
    public class FakeSearchDataService : ISearchDataService
    {
        private readonly RoomRepo _roomRepo;
        private readonly DormitoryRepo _dormitoryRepo;

        public FakeSearchDataService(RoomRepo roomRepo, DormitoryRepo dormitoryRepo)
        {
            _roomRepo = roomRepo;
            _dormitoryRepo = dormitoryRepo;
        }

        public async Task<SearchData> GetSearchDataAsync()
        {
            var result = new SearchData();

            result.Cities = _dormitoryRepo.Dormitories.Select(dorm => dorm.City).ToList();

            result.MaxBeds = _roomRepo.RoomTypes.Max(rt => rt.Beds);

            result.Types = _roomRepo.RoomTypes.Select(rt => rt.Type).Distinct().ToList();

            result.ReservationTypes = _roomRepo.ReservationTypes.Select(rt => rt.Type).Distinct().ToList();

            await Task.Delay(1000);

            return result;
        }
    }
}
