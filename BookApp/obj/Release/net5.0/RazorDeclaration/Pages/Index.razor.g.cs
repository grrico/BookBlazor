// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using BrowserInterop.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using BrowserInterop.Geolocation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using BookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using BookApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using BookApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using BookApp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\GitHub\Book\BookBlazor\BookApp\_Imports.razor"
using BookApp.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Index.razor"
      

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            List<BookLatLng> coordinates = new List<BookLatLng>();

            BookLatLng booklatlng = new BookLatLng()
            {
                ID = 1,
                ISBN = 9781292061184,
                Latitud = "6.317980459309707",
                Longitud = "-75.55077105765477",
            };
            coordinates.Add(booklatlng);

            //6.317980459309707, -75.55077105765477
            //6.317263373432214, -75.55338504108262
            //6.317476647167622, -75.55383833440473
            booklatlng = new BookLatLng()
            {
                ID = 1,
                ISBN = 9781292061184,
                Latitud = "6.317263373432214",
                Longitud = "-75.55338504108262",
            };
            coordinates.Add(booklatlng);


            booklatlng = new BookLatLng()
            {
                ID = 1,
                ISBN = 9781292061184,
                Latitud = "6.317476647167622",
                Longitud = "-75.55383833440473",
            };
            coordinates.Add(booklatlng);


            var zoom = 15;
            await JSRuntime.InvokeVoidAsync("initialize", coordinates, booklatlng, zoom);
            StateHasChanged();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
