#pragma checksum "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "249fac495088a44075199b5ba3d9971f548e4fc4"
// <auto-generated/>
#pragma warning disable 1591
namespace BookApp.Shared
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
    public partial class BookComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "td");
            __builder.AddMarkupContent(1, "<hr style=\"padding:0px; margin:0px;\">\r\n    ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
     Book.ISBN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "td");
            __builder.AddMarkupContent(5, "<hr style=\"padding:0px; margin:0px;\">\r\n    ");
            __builder.AddContent(6, 
#nullable restore
#line 7 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
     Book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "td");
            __builder.AddMarkupContent(9, "<hr style=\"padding:0px; margin:0px;\">\r\n    ");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
     Book.AuthorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "td");
            __builder.AddMarkupContent(13, "<hr style=\"padding:0px; margin:0px;\">\r\n    ");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
     Book.PubYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "td");
            __builder.AddMarkupContent(17, "<hr style=\"padding:0px;  margin:0px;\">\r\n    ");
            __builder.AddContent(18, 
#nullable restore
#line 19 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
     Book.PurchDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "<hr style=\"padding:0px; margin:0px;\">\r\n    ");
            __builder.AddContent(22, 
#nullable restore
#line 23 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
     Book.PubName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "div");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
                        () => InsertBook.InvokeAsync(Book)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Insert");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Git\BookApp\BookApp\BookApp\Shared\BookComponent.razor"
      

    [Parameter] public BookAuPub Book { get; set; }
    [Parameter] public EventCallback<BookAuPub> InsertBook { get; set; }

   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
