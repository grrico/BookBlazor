#pragma checksum "C:\Git\BookApp\BookApp\BookApp\Pages\Publisher\AddPublisher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f844c663e4e90a23acd7b413b71394f71d1012"
// <auto-generated/>
#pragma warning disable 1591
namespace BookApp.Pages.Publisher
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using BrowserInterop.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using BrowserInterop.Geolocation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using BookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using BookApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using BookApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using BookApp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Git\BookApp\BookApp\BookApp\_Imports.razor"
using BookApp.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Publisher/addPublisher/{isbnDummy:long}")]
    public partial class AddPublisher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>\r\n    Add Publisher\r\n</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "width", "100%");
            __builder.AddAttribute(4, "cellpadding", "0");
            __builder.AddAttribute(5, "cellspacing", "0");
            __builder.AddAttribute(6, "border", "0");
            __builder.OpenElement(7, "tbody");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "<td><label for=\"Name\" class=\"control-label\">Name</label></td>\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "for", "Name");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Git\BookApp\BookApp\BookApp\Pages\Publisher\AddPublisher.razor"
                                   publisher.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => publisher.Name = __value, publisher.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<td><label for=\"City\" class=\"control-label\">City</label></td>\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "for", "City");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Git\BookApp\BookApp\BookApp\Pages\Publisher\AddPublisher.razor"
                                   publisher.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => publisher.City = __value, publisher.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<td><label for=\"Country\" class=\"control-label\">\r\n                        Country\r\n                    </label></td>\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "for", "Country");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Git\BookApp\BookApp\BookApp\Pages\Publisher\AddPublisher.razor"
                                   publisher.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => publisher.Country = __value, publisher.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "<td></td>\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "<br>\r\n                    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Git\BookApp\BookApp\BookApp\Pages\Publisher\AddPublisher.razor"
                                      () => CreatePublisher()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "\r\n                        &#8195;Save&#8195;\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "&#8194;\r\n                    ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-warning");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Git\BookApp\BookApp\BookApp\Pages\Publisher\AddPublisher.razor"
                                      () => Cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "\r\n                        &#8194;&#8201;Cancel&#8201;&#8194;\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Git\BookApp\BookApp\BookApp\Pages\Publisher\AddPublisher.razor"
       
    [Parameter]
    public long isbnDummy { get; set; }
    Publisher publisher = new Publisher();
    protected async Task CreatePublisher()
    {
        await publisherService.Create(publisher);
        Cancel();
    }
    void Cancel()
    {
        if (isbnDummy > 0)
            navigationManager.NavigateTo("/Book/editBook/" + isbnDummy);
        else
            navigationManager.NavigateTo("/Publisher/listPublisher");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
    }
}
#pragma warning restore 1591