#pragma checksum "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13bab2bf449ea46d53605fbd55834ab22e39d345"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
using static BlazorMovies.Client.Shared.MainLayout;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "style", "color:" + (
#nullable restore
#line 6 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                 Appstate.Color

#line default
#line hidden
#nullable disable
            ) + ";font-size:" + (
#nullable restore
#line 6 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                                           Appstate.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "ingleton Count : ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                                                                            singleton.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<h3>Movie</h3>\r\n    ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MovieList>(8);
            __builder.AddAttribute(9, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 9 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                       movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                      AddNewMovie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "新增電影");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.DummyTextvox>(15);
            __builder.AddAttribute(16, "placeholder", "Movie name");
            __builder.AddAttribute(17, "disabled", "true");
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\k2lairrol\Documents\GitHub\BlazorMovie\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
      
    [CascadingParameter] public Appstate Appstate { get; set; }
    private List<Movie> movies;
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(1000);
        movies = repository.GetMovies();
    }
    private void AddNewMovie()
    {
        movies.Add(new Movie { Title = "New Movie", ReleaseDate = DateTime.Today });
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletonService singleton { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
