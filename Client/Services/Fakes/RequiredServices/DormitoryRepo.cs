using Albatross.Shared;
using System;
using System.Collections.Generic;

namespace Albatross.Client.Services.Fakes.RequiredServices
{
    public class DormitoryRepo
    {
        public List<Dormitory> Dormitories { get; set; } = new List<Dormitory>
            {
                new Dormitory{Id=Guid.Parse("e21d4a40-999a-495f-88a4-99cecd981a3d"), Area="120", City="خمینی شهر", Name="سده", State="اصفهان", University="آزاد خمینی شهر"},
                new Dormitory{Id=Guid.Parse("59cbcdc2-db09-492b-b46f-f200c8840bcf"), Area="220", City="اصفهان", Name="تخت فولاد", State="اصفهان", University="آزاد اصفهان"},
                new Dormitory{Id=Guid.Parse("31dfa163-7550-463d-a04f-5dbab32eead2"), Area="230", City="شاهین شهر", Name="فردوسی", State="اصفهان", University="آزاد شاهین شهر"}
            };
    }
}
