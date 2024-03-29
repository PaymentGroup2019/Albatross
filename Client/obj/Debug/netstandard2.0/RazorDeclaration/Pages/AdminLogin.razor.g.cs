#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Pages\AdminLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b1a1bfe5f30d419cc1a8fb407f972cb7a067506"
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
#line 3 "E:\Blazor\Albatross\Albatross\Client\Pages\AdminLogin.razor"
using Albatross.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdminLogin")]
    public class AdminLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 68 "E:\Blazor\Albatross\Albatross\Client\Pages\AdminLogin.razor"
       
    LoginDto _model = new LoginDto();

    bool isLogin = false;

    async Task HandleValidSubmit()
    {
        isLogin = true;

        StateHasChanged();

        var result = await LoginService.AdminLoginAsync(_model);

        if (result.IsSuccessful)
        {
            NavigationManager.NavigateTo("/Admin");

            toastService.ShowSuccess("ورود با موفقیت انجام شد");
        }
        else
        {
            isLogin = false;

            StateHasChanged();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.Interfaces.ILoginService LoginService { get; set; }
    }
}
#pragma warning restore 1591
