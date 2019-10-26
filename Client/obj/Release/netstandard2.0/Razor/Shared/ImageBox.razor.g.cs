#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Shared\ImageBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d51d1078ea02148a5b0b16695acb7b876a83c26"
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
    public class ImageBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "city");
            __builder.AddAttribute(2, "style", "margin:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#line 2 "E:\Blazor\Albatross\Albatross\Client\Shared\ImageBox.razor"
               ImageSource

#line default
#line hidden
            );
            __builder.AddAttribute(6, "style", "border-radius: 10px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "city_overlay");
            __builder.AddAttribute(10, "style", "border-radius: 10px");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", 
#line 4 "E:\Blazor\Albatross\Albatross\Client\Shared\ImageBox.razor"
                  Link

#line default
#line hidden
            );
            __builder.AddAttribute(14, "class", "d-flex flex-column align-items-center justify-content-center");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "city_title");
            __builder.AddContent(18, 
#line 5 "E:\Blazor\Albatross\Albatross\Client\Shared\ImageBox.razor"
                                     Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "city_subtitle");
            __builder.AddContent(22, 
#line 6 "E:\Blazor\Albatross\Albatross\Client\Shared\ImageBox.razor"
                                        PresentationText

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "E:\Blazor\Albatross\Albatross\Client\Shared\ImageBox.razor"
       
    [Parameter] public string ImageSource { get; set; }
    [Parameter] public string Title { get; set; }
    [Parameter] public string PresentationText { get; set; }
    [Parameter] public string Link { get; set; } = "/#";

#line default
#line hidden
    }
}
#pragma warning restore 1591
