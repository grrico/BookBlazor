#pragma checksum "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815db61d7130623d87c05deea550cda78513c484"
// <auto-generated/>
#pragma warning disable 1591
namespace BookApp.Pages.Book
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Book/addBook")]
    public partial class AddBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>\r\n    Add Book\r\n</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "width", "100%");
            __builder.AddAttribute(4, "cellpadding", "0");
            __builder.AddAttribute(5, "cellspacing", "0");
            __builder.AddAttribute(6, "border", "0");
            __builder.OpenElement(7, "tbody");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "<td><label for=\"ISBN\" class=\"control-label\">ISBN</label></td>\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "for", "ISBN");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                   book.ISBN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.ISBN = __value, book.ISBN));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<td><label for=\"Title\" class=\"control-label\">\r\n                        Title\r\n                    </label></td>\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "for", "Title");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                   book.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Title = __value, book.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
             if (@hasAdded)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "<td><label for=\"Authors\" class=\"control-label\">\r\n                            Authors\r\n                        </label></td>\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "<label style=\"width: 95px;\"><u><i><b>Sequence</b></i></u></label>\r\n                        ");
            __builder.AddMarkupContent(29, "<label><u><i><b>Full Name</b></i></u></label><br>");
#nullable restore
#line 45 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                         foreach (var bookAuthorName in bookAuthorNames)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "number");
            __builder.AddAttribute(32, "style", "width: 75px;");
            __builder.AddAttribute(33, "min", "0");
            __builder.AddAttribute(34, "max", "5");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                           bookAuthorName.AuthorOrd

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(36, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => bookAuthorName.AuthorOrd = __value, bookAuthorName.AuthorOrd, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                             if (@bookAuthorName.ISBN > 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "name", "AreChecked");
            __builder.AddAttribute(39, "type", "checkbox");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 54 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                               bookAuthorName.AuthorId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "checked");
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                                                                           eventArgs => { CheckChanged (bookAuthorName, eventArgs.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "name", "AreChecked");
            __builder.AddAttribute(45, "type", "checkbox");
            __builder.AddAttribute(46, "value", 
#nullable restore
#line 59 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                               bookAuthorName.AuthorId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                                                                   eventArgs => { CheckChanged (bookAuthorName, eventArgs.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "label");
            __builder.AddAttribute(49, "for", "AuthorName");
            __builder.AddAttribute(50, "style", "width: 150px;");
            __builder.AddContent(51, 
#nullable restore
#line 62 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                 bookAuthorName.AuthorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "<br>");
#nullable restore
#line 64 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddMarkupContent(55, "\r\n                        &#8194;\r\n                        ");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddAttribute(58, "href", "/Author/addAuthor/" + (
#nullable restore
#line 69 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                                    book.ISBN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "\r\n                            &#8194;Add author&#8194;\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "<br>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "tr");
            __builder.AddMarkupContent(62, "<td><label for=\"PubYear\" class=\"control-label\">\r\n                        Publication Year\r\n                    </label></td>\r\n                ");
            __builder.OpenElement(63, "td");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "for", "PubYear");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                   book.PubYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PubYear = __value, book.PubYear));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "tr");
            __builder.AddMarkupContent(71, "<td><label for=\"PurchDate\" class=\"control-label\">\r\n                        Purchase Date\r\n                    </label></td>\r\n                ");
            __builder.OpenElement(72, "td");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "date");
            __builder.AddAttribute(75, "class", "form-control");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                   book.PurchDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PurchDate = __value, book.PurchDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "<td><label for=\"Publisher\" class=\"control-label\">\r\n                        Publisher\r\n                    </label></td>\r\n                ");
            __builder.OpenElement(81, "td");
            __builder.OpenElement(82, "select");
            __builder.AddAttribute(83, "for", "Publisher");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                    book.PubId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PubId = __value, book.PubId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(87, "option");
            __builder.AddAttribute(88, "value", "0");
            __builder.AddContent(89, "[Select Publisher]");
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                         foreach (var publisher in publishers)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", 
#nullable restore
#line 109 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                            publisher.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, 
#nullable restore
#line 110 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                 publisher.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 112 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "td");
            __builder.AddMarkupContent(95, "\r\n                    &#8194;\r\n");
#nullable restore
#line 117 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                     if ((book.ISBN == null) || (book.ISBN == 0))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "<a class=\"btn btn-primary\" href=\"/Publisher/addPublisher/0\">Add publisher</a>");
#nullable restore
#line 120 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(97, "a");
            __builder.AddAttribute(98, "class", "btn btn-primary");
            __builder.AddAttribute(99, "href", "/Publisher/addPublisher/" + (
#nullable restore
#line 123 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                                                                  book.ISBN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Add publisher");
            __builder.CloseElement();
#nullable restore
#line 124 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "tr");
            __builder.AddMarkupContent(103, "<td></td>\r\n                ");
            __builder.OpenElement(104, "td");
            __builder.AddMarkupContent(105, "<br>\r\n                    ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "type", "button");
            __builder.AddAttribute(108, "class", "btn btn-primary");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 132 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                      () => CreateBook()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(110, "\r\n                        &#8195;Save&#8195;\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "&#8194;\r\n                    ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "type", "button");
            __builder.AddAttribute(114, "class", "btn btn-warning");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 136 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
                                      () => Cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(116, "\r\n                        &#8194;&#8201;Cancel&#8201;&#8194;\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "C:\Git\BookApp\BookApp\BookApp\Pages\Book\AddBook.razor"
       
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
