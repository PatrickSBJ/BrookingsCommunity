#pragma checksum "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\Home\PeoplePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e823675ef1d59a6643586956eeb8cb25b27a0e15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PeoplePage), @"mvc.1.0.view", @"/Views/Home/PeoplePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PeoplePage.cshtml", typeof(AspNetCore.Views_Home_PeoplePage))]
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
#line 1 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\_ViewImports.cshtml"
using BrookingsCommunity;

#line default
#line hidden
#line 2 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\_ViewImports.cshtml"
using BrookingsCommunity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e823675ef1d59a6643586956eeb8cb25b27a0e15", @"/Views/Home/PeoplePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a144b72eb274e8c7c36e5f6b58409ba116c23eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PeoplePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ImportantPerson>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\Home\PeoplePage.cshtml"
  
    ViewData["Title"] = "People Page";

#line default
#line hidden
            BeginContext(77, 50, true);
            WriteLiteral("\r\n        <h1>Important Brookings Locations</h1>\r\n");
            EndContext();
#line 7 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\Home\PeoplePage.cshtml"
         foreach (ImportantPerson person in Model)
        {

#line default
#line hidden
            BeginContext(190, 31, true);
            WriteLiteral("            <span>Name: </span>");
            EndContext();
            BeginContext(222, 11, false);
#line 9 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\Home\PeoplePage.cshtml"
                          Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(233, 47, true);
            WriteLiteral("<br />\r\n            <span>Achievements: </span>");
            EndContext();
            BeginContext(281, 19, false);
#line 10 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\Home\PeoplePage.cshtml"
                                  Write(person.Achievements);

#line default
#line hidden
            EndContext();
            BeginContext(300, 22, true);
            WriteLiteral("<br />\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 322, "\"", 347, 1);
#line 11 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\Home\PeoplePage.cshtml"
WriteAttributeValue("", 329, person.LinkToInfo, 329, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(348, 23, true);
            WriteLiteral(">More Information</a>\r\n");
            EndContext();
#line 12 "C:\Users\Patrick\Documents\Visual Studio 2017\Projects\BrookingsCommunity\BrookingsCommunity\Views\Home\PeoplePage.cshtml"
        }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ImportantPerson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
