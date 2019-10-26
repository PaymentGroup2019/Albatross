using Albatross.Shared;
using System;
using System.Collections.Generic;

namespace Albatross.Client.Services.Fakes.RequiredServices
{
    public class RoomRepo
    {
        public List<RoomType> RoomTypes { get; set; } = new List<RoomType>
            {
                new RoomType{DormitoryId=Guid.Parse("e21d4a40-999a-495f-88a4-99cecd981a3d"), Beds=6, Capacity=4, Dormitory="نجف آباد", Type="عادی"},
                new RoomType{DormitoryId=Guid.Parse("59cbcdc2-db09-492b-b46f-f200c8840bcf"), Beds=4, Capacity=2, Dormitory="خمینی شهر", Type="عادی"},
                new RoomType{DormitoryId=Guid.Parse("31dfa163-7550-463d-a04f-5dbab32eead2"), Beds=2, Capacity=3, Dormitory="اصفهان", Type="ویژه"},
            };

        public List<ReservationType> ReservationTypes { get; set; } = new List<ReservationType>
            {
                new ReservationType{Id=Guid.Parse("e21d4a40-999a-495f-88a4-99cecd980a1f"), Type="رزرو دربست"},
                new ReservationType{Id=Guid.Parse("59cbcdc2-db09-492b-b46f-f200c884edce"),  Type="تخت"}
            };
    }
}
