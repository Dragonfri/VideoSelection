#pragma checksum "C:\Users\Ykim1059\Downloads\VideoSelection-FinalSprint\VideoSelection-FinalSprint\MovieApp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf4a3cc2cf2eb3cec710913265edc40b4eeb754"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\Ykim1059\Downloads\VideoSelection-FinalSprint\VideoSelection-FinalSprint\MovieApp\Views\_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#line 2 "C:\Users\Ykim1059\Downloads\VideoSelection-FinalSprint\VideoSelection-FinalSprint\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf4a3cc2cf2eb3cec710913265edc40b4eeb754", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dd375ecbd23f05af2e7a2e1ae3c32af9a1424c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ykim1059\Downloads\VideoSelection-FinalSprint\VideoSelection-FinalSprint\MovieApp\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 104, true);
            WriteLiteral("<section class=\"page-section movie\" style=\"margin-top:15px;\">\r\n    <div class=\"container\">\r\n        <h2>");
            EndContext();
            BeginContext(146, 17, false);
#line 6 "C:\Users\Ykim1059\Downloads\VideoSelection-FinalSprint\VideoSelection-FinalSprint\MovieApp\Views\Home\About.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(163, 19, true);
            WriteLiteral("</h2>\r\n        <h3>");
            EndContext();
            BeginContext(183, 19, false);
#line 7 "C:\Users\Ykim1059\Downloads\VideoSelection-FinalSprint\VideoSelection-FinalSprint\MovieApp\Views\Home\About.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(202, 96, true);
            WriteLiteral("</h3>\r\n\r\n        <p>Use this area to provide additional information.</p>\r\n    </div>\r\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591