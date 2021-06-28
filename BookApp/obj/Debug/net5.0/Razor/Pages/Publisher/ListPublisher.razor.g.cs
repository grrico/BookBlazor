#pragma checksum "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f4c912de900f7a918f8a7ada27fc3b0a2af3a54"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Publisher/listPublisher")]
    public partial class ListPublisher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n");
            __builder.AddMarkupContent(1, @"<style>
    .sort-th {
        cursor: pointer;
    }

    .fa {
        float: right;
    }

    .btn-custom {
        color: black;
        float: left;
        padding: 8px 16px;
        text-decoration: none;
        transition: background-color .3s;
        border: 2px solid #000;
        margin: 0px 5px 0px 5px;
    }
</style>
");
            __builder.AddMarkupContent(2, "<a class=\"btn btn-primary\" href=\"/Publisher/addPublisher/0\">\r\n    Add new publisher\r\n</a>");
#nullable restore
#line 26 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
 if (publishers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 29 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row col-md-3 pull-right");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "id", "txtSearch");
            __builder.AddAttribute(9, "placeholder", "Search Names...");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                      SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-bordered table-hover");
            __builder.OpenElement(16, "thead");
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "th");
            __builder.AddAttribute(19, "class", "sort-th");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                                () => SortTable("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n                    Id");
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "class", "fa" + " " + (
#nullable restore
#line 41 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                        SetSortIcon("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "th");
            __builder.AddAttribute(26, "class", "sort-th");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                () => SortTable("Name")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                    Name\r\n                    ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "fa" + " " + (
#nullable restore
#line 46 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                      SetSortIcon("Name")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "th");
            __builder.AddAttribute(33, "class", "sort-th");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                () => SortTable("City")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n                    City\r\n                    ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "fa" + " " + (
#nullable restore
#line 51 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                      SetSortIcon("City")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "th");
            __builder.AddAttribute(40, "class", "sort-th");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                () => SortTable("Country")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n                    Country\r\n                    ");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "class", "fa" + " " + (
#nullable restore
#line 56 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                      SetSortIcon("Country")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<th>Action</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "tbody");
#nullable restore
#line 62 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
             if (publishers == null || publishers.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<tr><td colspan=\"3\">\r\n                        No Records to display\r\n                    </td></tr>");
#nullable restore
#line 69 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
            }
            else
            {
                foreach (var publisher in publishers)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "td");
            __builder.AddMarkupContent(52, "<hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(53, 
#nullable restore
#line 77 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                             publisher.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "td");
            __builder.AddMarkupContent(56, "<hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(57, 
#nullable restore
#line 81 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                             publisher.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddMarkupContent(60, "<hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(61, 
#nullable restore
#line 85 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                             publisher.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddMarkupContent(64, "<hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(65, 
#nullable restore
#line 89 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                             publisher.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "td");
            __builder.AddMarkupContent(68, "<hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.OpenElement(69, "a");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "href", "/Publisher/editPublisher/" + (
#nullable restore
#line 94 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                                               publisher.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "\r\n                                &#8194;Edit&#8194;\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "&#8194;\r\n                            ");
            __builder.OpenElement(74, "a");
            __builder.AddAttribute(75, "class", "btn btn-warning");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                                                 () =>
                        DeletePublisher(publisher.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 101 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "pagination");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "class", "btn btn-custom");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                                  async ()=>
              await NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(84, "\r\n            ◀\r\n        ");
            __builder.CloseElement();
#nullable restore
#line 110 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
         for (int i = startPage; i <= endPage; i++)
        {
            var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "btn" + " btn-custom" + " pagebutton" + "\r\n                 " + (
#nullable restore
#line 114 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                   currentPage==curPage?"btn-info":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                               async () =>
                 await refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, 
#nullable restore
#line 117 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                 currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 119 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "class", "btn btn-custom");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 120 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
                                                  async ()=>
              await NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(92, "\r\n            ▶\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 125 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Publisher\ListPublisher.razor"
       
    private string searchTerm;
    private string SearchTerm
    {
        get { return searchTerm; }
        set { searchTerm = value; FilterRecords(); }
    }
    List<Publisher> publishers;
    #region Pagination
    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    string sortColumnName = "Id";
    string sortDir = "ASC";
    #endregion
    protected override async Task OnInitializedAsync()
    {
        //display total page buttons
        pagerSize = 3;
        pageSize = 5;
        curPage = 1;
        publishers = await publisherService.ListAll((curPage - 1) *
           pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        totalRecords = await publisherService.Count(searchTerm);
        totalPages = (int)Math.Ceiling
                     (totalRecords / (decimal)pageSize);
        SetPagerSize("forward");
    }
    protected async Task DeletePublisher(int id)
    {
        await publisherService.Delete(id);
        publishers = await publisherService.ListAll((curPage - 1) *
           pageSize, pageSize, sortColumnName, sortDir, searchTerm);
    }
    private bool isSortedAscending;
    private string activeSortColumn;
    private async Task<List<Publisher>>
            SortRecords(string columnName, string dir)
    {
        return await publisherService.ListAll((curPage - 1) * pageSize,
           pageSize, columnName, dir, searchTerm);
    }
    private async Task SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            publishers = await SortRecords(columnName, "ASC");
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                publishers = await SortRecords(columnName, "DESC");
            }
            else
            {
                publishers = await SortRecords(columnName, "ASC");
            }
            isSortedAscending = !isSortedAscending;
        }
        sortColumnName = columnName;
        sortDir = isSortedAscending ? "ASC" : "DESC";
    }
    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }
    public async Task refreshRecords(int currentPage)
    {
        publishers = await publisherService.ListAll((currentPage - 1)
           * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        curPage = currentPage;
        this.StateHasChanged();
    }
    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
        else
        {
            startPage = 1;
            endPage = totalPages;
        }
    }
    public async Task NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
            }
        }
        else if (direction == "previous")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
            }
        }
        await refreshRecords(curPage);
    }
    public void FilterRecords()
    {
        endPage = 0;
        this.OnInitializedAsync().Wait();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
    }
}
#pragma warning restore 1591
