#pragma checksum "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb28245a754ee06dc7f14fbcac3011322f12776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_ListRiders), @"mvc.1.0.view", @"/Views/Info/ListRiders.cshtml")]
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
#line 1 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\_ViewImports.cshtml"
using MotoGP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\_ViewImports.cshtml"
using MotoGP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb28245a754ee06dc7f14fbcac3011322f12776", @"/Views/Info/ListRiders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c11a21fd0de2028889f3b1a931d0560cbec79e", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_ListRiders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MotoGP.Models.Rider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
  
    ViewData["Title"] = "Riders";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"cards\">\r\n");
#nullable restore
#line 9 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
     foreach (var item in Model)
    {
        // Get the value "number" from Model that has table content Riders in it.
        var rider = "/images/riders/" + item.Number + ".jpg";
        // Get the value "CountryID" from Model that has table content Riders in it.
        var flag = "/images/flags/" + item.CountryID + ".png";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"column\">\r\n            <article class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 537, "\"", 549, 1);
#nullable restore
#line 17 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
WriteAttributeValue("", 543, rider, 543, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"rider\" />\r\n                <h2 class=\"number\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 628, "\"", 639, 1);
#nullable restore
#line 19 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
WriteAttributeValue("", 634, flag, 634, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"flag\" class=\"flag\" />\r\n                    ");
#nullable restore
#line 20 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
               Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <p>\r\n                    ");
#nullable restore
#line 23 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
                               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </article>\r\n        </div>\r\n");
#nullable restore
#line 27 "D:\College\Y2\SEM2\ASP.NET\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<p><a href=\"javascript:history.back()\">Back</a></p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MotoGP.Models.Rider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
