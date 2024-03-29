#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f1799fc24a105d9c61991424b9a2901e1f8db6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Albatross.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Albatross.Client;

#line default
#line hidden
#line 7 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Albatross.Client.Shared;

#line default
#line hidden
#line 8 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#line 9 "E:\Blazor\Albatross\Albatross\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#line 1 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
using Albatross.Shared;

#line default
#line hidden
    public class SearchBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 47 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
       
    [Parameter] public string ImageSource { get; set; } = "/images/city_2.jpg";
    [Parameter] public string Title { get; set; } = "مدیریت اتاق ها";
    [Parameter] public string PresentationText { get; set; } = "مدیریت اتاق ها";
    [Parameter] public string Link { get; set; } = "Admin/Rooms";
    [Parameter] public RoomData RoomData { get; set; }

    async Task ReserveAsync()
    {
        await RoomReservationService.SetRoomReservationData(RoomData);

        NavigationManager.NavigateTo($"/RoomReservation");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.Interfaces.IRoomReservationService RoomReservationService { get; set; }
    }
}
#pragma warning restore 1591
