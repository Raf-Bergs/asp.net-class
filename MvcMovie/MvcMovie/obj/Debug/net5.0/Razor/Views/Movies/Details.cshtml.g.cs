#pragma checksum "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86102bae78481556a986a2d429a15d3542675b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86102bae78481556a986a2d429a15d3542675b0", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<dl>\r\n    <dt>\r\n        ");
#nullable restore
#line 10 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 13 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 16 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 19 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 22 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 25 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 28 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 31 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 34 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 37 "D:\College\Y2\SEM2\ASP.NET\www\MvcMovie\MvcMovie\Views\Movies\Details.cshtml"
   Write(Html.DisplayFor(model => model.Rating.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n</dl>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
