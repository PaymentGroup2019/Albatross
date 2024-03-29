#pragma checksum "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f1799fc24a105d9c61991424b9a2901e1f8db6"
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
#line 1 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
using Albatross.Shared;

#line default
#line hidden
    public class SearchBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card my-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "room");
            __builder.AddAttribute(5, "style", "margin:10px");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#line 9 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                   ImageSource

#line default
#line hidden
            );
            __builder.AddAttribute(9, "style", "border-radius: 10px");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "city_overlay");
            __builder.AddAttribute(13, "style", "border-radius: 10px");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", 
#line 11 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                      Link

#line default
#line hidden
            );
            __builder.AddAttribute(17, "class", "d-flex flex-column align-items-center justify-content-center");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "city_title");
            __builder.AddContent(21, 
#line 12 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                                         RoomData.DormitoryName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "city_subtitle");
            __builder.AddContent(25, 
#line 13 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                                            RoomData.City

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card-body pt-0");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.AddAttribute(35, "style", "background: linear-gradient(to right, #487fee, #32fa95);border-radius: 16px;");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-12 col-lg-3 d-flex justify-content-center pt-1");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.AddMarkupContent(40, "<span class=\"text-dark\" style=\"font-size: 11px\">نام:</span>\r\n                ");
            __builder.AddMarkupContent(41, "<span class=\"text-white\" style=\"font-size: 11px\">&nbsp;</span>\r\n                ");
            __builder.OpenElement(42, "span");
            __builder.AddAttribute(43, "class", "text-white");
            __builder.AddAttribute(44, "style", "font-size: 11px");
            __builder.AddContent(45, 
#line 22 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                                                                  RoomData.DormitoryName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-12 col-lg-3 d-flex justify-content-center pt-1");
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.AddMarkupContent(51, "<span class=\"text-dark\" style=\"font-size: 11px\">شهر:</span>\r\n                ");
            __builder.AddMarkupContent(52, "<span class=\"text-white\" style=\"font-size: 11px\">&nbsp;</span>\r\n                ");
            __builder.OpenElement(53, "span");
            __builder.AddAttribute(54, "class", "text-white");
            __builder.AddAttribute(55, "style", "font-size: 10px");
            __builder.AddContent(56, 
#line 27 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                                                                  RoomData.City

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-12 col-lg-3 d-flex justify-content-center pt-1");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<span class=\"text-dark\" style=\"font-size: 11px\">تعداد اتاق:</span>\r\n                ");
            __builder.AddMarkupContent(63, "<span class=\"text-white\" style=\"font-size: 11px\">&nbsp;</span>\r\n                ");
            __builder.OpenElement(64, "span");
            __builder.AddAttribute(65, "class", "text-white");
            __builder.AddAttribute(66, "style", "font-size: 11px");
            __builder.AddContent(67, 
#line 32 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                                                                  RoomData.Beds

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-12 col-lg-3 d-flex justify-content-center pt-1");
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.AddMarkupContent(73, "<span class=\"text-dark\" style=\"font-size: 11px\">قیمت:</span>\r\n                ");
            __builder.AddMarkupContent(74, "<span class=\"text-white\" style=\"font-size: 11px\">&nbsp;</span>\r\n                ");
            __builder.OpenElement(75, "span");
            __builder.AddAttribute(76, "class", "text-white");
            __builder.AddAttribute(77, "style", "font-size: 11px");
            __builder.AddContent(78, 
#line 37 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                                                                  RoomData.Price

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.AddMarkupContent(82, "<p class=\"card-text text-right mt-2\">توضیحات خوابگاه دانشگاه آزاد واحد نجف آباد</p>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "card-footer");
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.OpenElement(87, "button");
            __builder.AddAttribute(88, "class", "btn btn-success");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "E:\Blazor\Albatross\Albatross\Client\Shared\SearchBox.razor"
                                                  ReserveAsync

#line default
#line hidden
            ));
            __builder.AddMarkupContent(90, "رزرو اتاق");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
            __builder.CloseElement();
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
