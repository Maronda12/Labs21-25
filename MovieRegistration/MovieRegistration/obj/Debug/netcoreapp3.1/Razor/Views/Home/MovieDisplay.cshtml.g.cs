#pragma checksum "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af26b3888c3ced12367cb9e55bdfa7c9552b7294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieDisplay), @"mvc.1.0.view", @"/Views/Home/MovieDisplay.cshtml")]
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
#line 1 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af26b3888c3ced12367cb9e55bdfa7c9552b7294", @"/Views/Home/MovieDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h4>ID:</h4>\r\n<p> ");
#nullable restore
#line 5 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml"
Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<h4>Title:</h4>\r\n<p> ");
#nullable restore
#line 9 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h4>Genre:</h4>\r\n<p> ");
#nullable restore
#line 12 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml"
Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h4>Year:</h4>\r\n<p> ");
#nullable restore
#line 15 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml"
Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h4>Actors:</h4>\r\n<p> ");
#nullable restore
#line 18 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml"
Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h4>Directors:</h4>\r\n<p> ");
#nullable restore
#line 21 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml"
Write(Model.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h1>");
#nullable restore
#line 23 "C:\Users\maron\Bootcamp\MovieRegistration\MovieRegistration\Views\Home\MovieDisplay.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registered.</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
