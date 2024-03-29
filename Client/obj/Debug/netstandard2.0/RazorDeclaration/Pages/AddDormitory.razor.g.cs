#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Pages\AddDormitory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9109449f869aa28ec7d6a22940837548ae08006c"
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
#line 3 "E:\Blazor\Albatross\Albatross\Client\Pages\AddDormitory.razor"
using Albatross.Shared;

#line default
#line hidden
#line 4 "E:\Blazor\Albatross\Albatross\Client\Pages\AddDormitory.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Dormitories/Register")]
    public class AddDormitory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 56 "E:\Blazor\Albatross\Albatross\Client\Pages\AddDormitory.razor"
       
    DormitoryRegistrationViewModel _model = new DormitoryRegistrationViewModel();

    void BackToDormitories()
    {
        NavigationManager.NavigateTo("/Admin/Dormitories");
    }

    async Task HandleValidSubmit()
    {
        await DormitoryService.RegisterDormitory(_model);

        toastService.ShowSuccess("Dormitory added successfully");

        NavigationManager.NavigateTo("/Admin/Dormitories");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.Interfaces.IDormitoryService DormitoryService { get; set; }
    }
}
#pragma warning restore 1591
