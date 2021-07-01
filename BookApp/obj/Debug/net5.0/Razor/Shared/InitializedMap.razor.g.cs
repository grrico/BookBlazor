#pragma checksum "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd14b1ea514ec2ccdd95a89dca1fff4cf88b16f"
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
#nullable restore
#line 5 "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class InitializedMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Initialized Map</h3>");
#nullable restore
#line 9 "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor"
 if (bookLatLngs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<img src=\"https://media.giphy.com/media/y1ZBcOGOOtlpC/giphy.gif\">");
            __builder.AddContent(2, "Cargando ...");
#nullable restore
#line 12 "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor"
                             
}
else if (bookLatLngs.Count() == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "No hay registros a mostrar.");
#nullable restore
#line 16 "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor"
                                            
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, "Parametro: ");
            __builder.AddContent(6, 
#nullable restore
#line 20 "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor"
                    searchTerm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<div class=\"input-group-append\"><div id=\"map\" style=\"height:500px;width:100%;\"></div></div>");
#nullable restore
#line 24 "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Git\BookApp\BookApp\BookApp\Shared\InitializedMap.razor"
       

    [Parameter] public string searchTerm { get; set; }


    int curPage;
    int pagerSize;
    int pageSize;
    string sortColumnName = "ID";
    string sortDir = "DESC";


    List<BookLatLng> bookLatLngs;
    List<PolygonCoordinates> polygonCoordinates;

    protected override async Task OnInitializedAsync()
    {

        //await Task.Delay(300);

        pagerSize = 3;
        pageSize = 8;
        curPage = 1;
        if (searchTerm == "")
        {
            searchTerm = "9781292061184";
        }
        bookLatLngs = await bookLatLngService.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);

        searchTerm = "1";
        pageSize = 1000;
        polygonCoordinates = await polygonCoordinatesService.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (bookLatLngs == null)
        {
            pagerSize = 3;
            pageSize = 8;
            curPage = 1;
            bookLatLngs = await bookLatLngService.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        }

        if (firstRender)
        {

            List<LatLng> lLatLngs = new List<LatLng>();
            LatLng lLatLng;
            foreach (PolygonCoordinates coodenada in polygonCoordinates)
            {
                lLatLng = new LatLng{
                    lat = coodenada.Latitude.Value,
                    lng = coodenada.Longitude.Value
                };
                lLatLngs.Add(lLatLng);
            }

            //Creating a JavaScriptSerializer Object

            string serializedString = System.Text.Json.JsonSerializer.Serialize(lLatLngs);


            var zoom = 26;
            BookLatLng booklatlng = bookLatLngs.FirstOrDefault();
            await JSRuntime.InvokeVoidAsync("initialize", bookLatLngs, booklatlng, zoom, serializedString);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPolygonCoordinatesService polygonCoordinatesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookLatLngService bookLatLngService { get; set; }
    }
}
#pragma warning restore 1591
