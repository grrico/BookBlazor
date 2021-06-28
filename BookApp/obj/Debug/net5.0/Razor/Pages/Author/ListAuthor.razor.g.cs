#pragma checksum "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ba39d374087aa3a88d9a3ac3bd4ed492dbf553"
// <auto-generated/>
#pragma warning disable 1591
namespace BookApp.Pages.Author
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Author/listAuthor")]
    public partial class ListAuthor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n\r\n");
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
            __builder.AddMarkupContent(2, "<a class=\"btn btn-primary\" href=\"/Author/addAuthor/0\">Add new author</a>");
#nullable restore
#line 28 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
 if (authorList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 31 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
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
#line 35 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
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
#line 40 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                () => SortTable("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n                    Id");
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "class", "fa" + " " + (
#nullable restore
#line 41 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
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
#line 44 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                () => SortTable("FName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                    First Name\r\n                    ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "fa" + " " + (
#nullable restore
#line 46 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                      SetSortIcon("FName")

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
#line 49 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                () => SortTable("LName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n                    Last Name\r\n                    ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "fa" + " " + (
#nullable restore
#line 51 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                      SetSortIcon("LName")

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
#line 54 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                () => SortTable("Phone")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n                    Phone\r\n                    ");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "class", "fa" + " " + (
#nullable restore
#line 56 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                      SetSortIcon("Phone")

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
#line 62 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
             if (authorList == null || authorList.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<tr><td colspan=\"3\">\r\n                        No Records to display\r\n                    </td></tr>");
#nullable restore
#line 69 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
            }
            else
            {
                foreach (var _author in authorList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "td");
            __builder.AddMarkupContent(52, "<hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(53, 
#nullable restore
#line 77 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                             _author.Id

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
#line 81 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                             _author.FName

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
#line 85 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                             _author.LName

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
#line 89 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                             _author.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "td");
            __builder.AddMarkupContent(68, "<hr style=\"padding:0px; margin:0px;\">\r\n\r\n                            ");
            __builder.OpenElement(69, "a");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "href", "/Author/editAuthor/" + (
#nullable restore
#line 94 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                                                 _author.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<BookApp.Pages.Tooltip>(72);
            __builder.AddAttribute(73, "Text", "Edit Author!");
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(75, "<span class=\"fa fa-id-card\" aria-hidden=\"true\">Edit</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                            ");
            __builder.OpenElement(77, "a");
            __builder.AddAttribute(78, "class", "btn btn-warning");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                                 () => DeleteAuthor(_author.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<BookApp.Pages.Tooltip>(80);
            __builder.AddAttribute(81, "Text", "Delete Author!");
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(83, "<span class=\"fa fa-eraser\" aria-hidden=\"true\"> Delete</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n                            ");
            __builder.AddMarkupContent(85, "<a href=\"#\" data-toggle=\"popover\" title=\"Introduction\" data-content=\"My name is Farhan Ahmed. I am full-stack developer.\">What is your name?</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"

                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "pagination");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "class", "btn btn-custom");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                  async ()=> await NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(92, "◀");
            __builder.CloseElement();
#nullable restore
#line 114 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
         for (int i = startPage; i <= endPage; i++)
        {
            var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "class", "btn" + " btn-custom" + " pagebutton" + " " + (
#nullable restore
#line 117 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                       currentPage==curPage?"btn-info":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                                                                       async () => await refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(96, 
#nullable restore
#line 117 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                                                                                                                       currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 118 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "class", "btn btn-custom");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 119 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
                                                  async ()=> await NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(100, "▶");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 121 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Author\ListAuthor.razor"
       
    private string searchTerm;

    private string SearchTerm
    {
        get { return searchTerm; }
        set { searchTerm = value; FilterRecords(); }
    }

    List<Author> authorList;
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
        authorList = await authorService.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        totalRecords = await authorService.Count(searchTerm);
        totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);
        SetPagerSize("forward");
    }

    protected async Task DeleteAuthor(int id)
    {
        await authorService.Delete(id);
        authorList = await authorService.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
    }

    private bool isSortedAscending;
    private string activeSortColumn;

    private async Task<List<Author>> SortRecords(string columnName, string dir)
    {
        return await authorService.ListAll((curPage - 1) * pageSize, pageSize, columnName, dir, searchTerm);
    }

    private async Task SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            authorList = await SortRecords(columnName, "ASC");
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                authorList = await SortRecords(columnName, "DESC");
            }
            else
            {
                authorList = await SortRecords(columnName, "ASC");
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
        authorList = await authorService.ListAll((currentPage - 1)
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService authorService { get; set; }
    }
}
#pragma warning restore 1591
