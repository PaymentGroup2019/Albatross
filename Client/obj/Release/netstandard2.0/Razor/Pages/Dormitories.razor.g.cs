#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf612b3d4da2f37d3e05f95ddd7747299d653f07"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
using Albatross.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/dormitories")]
    public class Dormitories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-striped");
            __builder.AddAttribute(2, "style", "margin-top:150px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<thead class=""thead-light"">
        <tr>
            <th scope=""col"" class=""rounded-left"">ردیف</th>
            <th scope=""col"">دانشگاه</th>
            <th scope=""col"">خوابگاه</th>
            <th scope=""col"">شهر</th>
            <th scope=""col"">متراژ</th>
            <th scope=""col"" class=""rounded-right"">عملیات</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#line 17 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
          var Counter = 1;

#line default
#line hidden
#line 18 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
         foreach (var item in DormitoriyItems)
        {

#line default
#line hidden
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "th");
            __builder.AddAttribute(11, "scope", "row");
            __builder.AddContent(12, 
#line 21 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
                                 Counter.ToString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#line 22 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
                     item.University

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#line 23 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
                     item.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#line 24 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
                     item.City

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#line 25 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
                     item.Area

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, @"<td>
                    <a href>
                        <i class=""fa fa-info-circle text-info""></i>
                    </a>
                    <a href>
                        <i class=""fa fa-edit text-warning""></i>
                    </a>
                    <a href>
                        <i class=""fa fa-trash-o text-danger""></i>
                    </a>
                </td>
            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#line 38 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
            Counter++;
        }

#line default
#line hidden
            __builder.AddContent(28, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 43 "E:\Blazor\Albatross\Albatross\Client\Pages\Dormitories.razor"
      
    [Parameter]
    public IEnumerable<Dormitory> DormitoriyItems { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
