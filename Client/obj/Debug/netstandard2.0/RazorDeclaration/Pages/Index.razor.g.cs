#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24aaaeff14958f9bbe6315a2024a91542aa7861"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Albatross.Client.Pages
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
#line 2 "E:\Blazor\Albatross\Albatross\Client\Pages\Index.razor"
using Albatross.Shared;

#line default
#line hidden
#line 3 "E:\Blazor\Albatross\Albatross\Client\Pages\Index.razor"
using Albatross.Client.Pages.RoomInfo;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 29 "E:\Blazor\Albatross\Albatross\Client\Pages\Index.razor"
       
    SearchResult result;

    async Task OnRoomSearched(RoomSearch roomSearch)
    {
        await result.ShowResultAsync(roomSearch);
    }

    protected override void OnInitialized()
    {
        //if (!LoginService.IsLoggedIn)
        //{
        //    NavigationManager.NavigateTo("/AdminLogin");
        //}
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.Interfaces.ILoginService LoginService { get; set; }
    }
}
#pragma warning restore 1591
