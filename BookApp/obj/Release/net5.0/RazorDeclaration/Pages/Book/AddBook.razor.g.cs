// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookApp.Pages.Book
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Book/addBook")]
    public partial class AddBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "C:\GitHub\Book\BookBlazor\BookApp\Pages\Book\AddBook.razor"
       
    Book book = new Book();
    BookAuthorName bookAuthorName = new BookAuthorName();
    List<Publisher> publishers = new List<Publisher>();
    List<BookAuthorName> bookAuthorNames = new List<BookAuthorName>();
    List<Book> books = new List<Book>();
    bool hasAdded = false;
    protected override async Task OnInitializedAsync()
    {
        //book.PubYear = (short)DateTime.Now.Year;
        book.PurchDate = DateTime.Now;
        publishers = await publisherService.FetchAll();
    }
    protected async Task CreateBook()
    {
        if (hasAdded)
        {
            navigationManager.NavigateTo("/Book/listBook");
        }
        else
        {
            await bookService.Create(book);
            bookAuthorNames = await bookAuthorService.FetchAll(0);
            hasAdded = !hasAdded;
        }
    }
    protected async Task CheckChanged(BookAuthorName bookAuthorName,
                                      object checkValue)
    {
        long isbn = 0;
        if (book.ISBN > isbn)
        {
            isbn = (long)book.ISBN;
            bookAuthorNames = await bookAuthorService.FetchAll(isbn);
            if ((bool)checkValue)
            {
                // insert
                bookAuthorName.ISBN = isbn;
                await bookAuthorService.Create(bookAuthorName);
            }
            else
            {
                //delete
                bookAuthorName.AuthorOrd = 0;
                await bookAuthorService.Delete
                      (isbn, bookAuthorName.AuthorId);
            }
            bookAuthorNames = await bookAuthorService.FetchAll(isbn);
        }
    }
    void Cancel()
    {
        navigationManager.NavigateTo("/Book/listBook");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookAuthorService bookAuthorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService bookService { get; set; }
    }
}
#pragma warning restore 1591
