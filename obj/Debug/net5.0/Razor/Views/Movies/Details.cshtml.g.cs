#pragma checksum "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "473842c15cb7e4b26b6bee878bfa91b17088b9a6"
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
#line 1 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\_ViewImports.cshtml"
using CoreFiveCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\_ViewImports.cshtml"
using CoreFiveCRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\_ViewImports.cshtml"
using CoreFiveCRUD.ViewsModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"473842c15cb7e4b26b6bee878bfa91b17088b9a6", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab635959f711d593a4c142c5eea8f80fccb4888", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
   ViewData["Title"] = Model.Title; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row justify-content-between mt-60-px\">\n    <div class=\"col-md-3\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 143, "\"", 208, 2);
            WriteAttributeValue("", 149, "data:image/*;base64,", 149, 20, true);
#nullable restore
#line 7 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
WriteAttributeValue("", 169, Convert.ToBase64String(Model.Poster), 169, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 231, "\"", 249, 1);
#nullable restore
#line 7 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
WriteAttributeValue("", 237, Model.Title, 237, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div>\n    <div class=\"col-md-7\">\n        <div class=\"d-flex justify-content-between mb-3\">\n            <h3>");
#nullable restore
#line 11 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <span class=\"mt-2\">\n                <i class=\"bi bi-star-fill text-warning\"></i>\n                <span class=\"text-muted\">");
#nullable restore
#line 14 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
                                    Write(Model.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </span>\n        </div>\n        <span class=\"text-muted mr-3\">\n            <i class=\"bi bi-calendar-week\"></i>\n            ");
#nullable restore
#line 19 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
       Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span>\n        <span class=\"text-muted\">\n            <i class=\"bi bi-film\"></i>\n            ");
#nullable restore
#line 23 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
       Write(Model.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span>\n        <p class=\"text-justify mt-3\">");
#nullable restore
#line 25 "C:\Users\mudi\source\repos\CoreFiveCRUD\Views\Movies\Details.cshtml"
                                Write(Model.Storeline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n</div>");
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
