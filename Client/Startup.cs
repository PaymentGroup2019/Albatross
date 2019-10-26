using Albatross.Client.Services.Fakes;
using Albatross.Client.Services.Fakes.RequiredServices;
using Albatross.Client.Services.Interfaces;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Albatross.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDormitoryService, FakeDormitoryService>();
            services.AddSingleton<IRoomService, FakeRoomService>();
            services.AddSingleton<ISearchDataService, FakeSearchDataService>();
            services.AddSingleton<ISearchService, FakeSearchService>();
            services.AddSingleton<ILoginService, FakeLoginService>();
            services.AddSingleton<IRoomReservationService, FakeRoomReservationService>();
            services.AddSingleton<DormitoryRepo>();
            services.AddSingleton<RoomRepo>();
            services.AddBlazoredToast();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
