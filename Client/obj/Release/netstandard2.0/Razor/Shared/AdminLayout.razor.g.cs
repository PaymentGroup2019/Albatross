#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Shared\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9a9b57a70cdd1ce4fd49509933f370fa13cd96a"
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
    public class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<Albatross.Client.Shared.Header>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Albatross.Client.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddMarkupContent(10, "<div class=\"row\">\r\n        <div class=\"col\">\r\n        </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddContent(17, 
#line 14 "E:\Blazor\Albatross\Albatross\Client\Shared\AdminLayout.razor"
             Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
