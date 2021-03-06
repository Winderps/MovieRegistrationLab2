#pragma checksum "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c352295e8bd153d5d5c8221b01250023fde1af04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_AddMovie), @"mvc.1.0.view", @"/Views/Movie/AddMovie.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\_ViewImports.cshtml"
using MovieRegistrationLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\_ViewImports.cshtml"
using MovieRegistrationLab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c352295e8bd153d5d5c8221b01250023fde1af04", @"/Views/Movie/AddMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a7ed6f29487d40d61d5fbc5bf8cb15fb58795a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_AddMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml"
  
    string movieListJSON = HttpContextAccessor.HttpContext.Session.GetString("MovieCart") ?? "NULL";
    List<Movie> currentCart = new List<Movie>();
    if (movieListJSON != "NULL")
    {
        currentCart = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
    }
    if (!currentCart.Any(x => x.ID.Equals(Model.ID)))
    {
        currentCart.Add(Model);
        movieListJSON = JsonSerializer.Serialize(currentCart);
        HttpContextAccessor.HttpContext.Session.SetString("MovieCart", movieListJSON);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 18 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" was added to your cart.</p>\r\n");
#nullable restore
#line 19 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 22 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is already in your cart.</p>\r\n");
#nullable restore
#line 23 "C:\Users\Winderps\source\repos\MovieRegistrationLab\MovieRegistrationLab\Views\Movie\AddMovie.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
