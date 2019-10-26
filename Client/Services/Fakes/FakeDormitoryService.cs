using Albatross.Client.Services.Fakes.RequiredServices;
using Albatross.Client.Services.Interfaces;
using Albatross.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Fakes
{
    public class FakeDormitoryService : IDormitoryService
    {
        private readonly DormitoryRepo _dormitoryRepo;

        public FakeDormitoryService(DormitoryRepo dormitoryRepo)
        {
            _dormitoryRepo = dormitoryRepo;
        }

        public async Task<List<Dormitory>> GetAllDormitoriesAsync()
        {
            return await Task.FromResult(_dormitoryRepo.Dormitories);
        }

        public async Task RegisterDormitory(DormitoryRegistrationViewModel model)
        {
            var dormitory = new Dormitory
            {
                Area = "NA",
                City = model.City,
                Name = model.Name,
                State = model.State,
                University = model.University,
            };

            _dormitoryRepo.Dormitories.Add(dormitory);

            await Task.Delay(100);
        }
    }
}
