#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0965299ff7c7d1481acee6a9c2c4e6d3a6bbd1a"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "E:\Blazor\Albatross\Albatross\Client\Shared\LoginLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
    public class LoginLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid px-0");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#line 5 "E:\Blazor\Albatross\Albatross\Client\Shared\LoginLayout.razor"
     Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(6);
            __builder.AddAttribute(7, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#line 8 "E:\Blazor\Albatross\Albatross\Client\Shared\LoginLayout.razor"
                          ToastPosition.BottomLeft

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 9 "E:\Blazor\Albatross\Albatross\Client\Shared\LoginLayout.razor"
                         2

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(10, "SuccessIconClass", "fa fa-thumbs-up");
            __builder.AddAttribute(11, "ErrorIconClass", "fa fa-bug");
            __builder.AddAttribute(12, "WarningIconClass", "fas fa-exclamation-triangle");
            __builder.AddAttribute(13, "InfoIconClass", "fas fa-info");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
