#pragma checksum "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\seance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebec38b562afdffdc685af148f132b757285f5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_absence_seance), @"mvc.1.0.view", @"/Views/absence/seance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/absence/seance.cshtml", typeof(AspNetCore.Views_absence_seance))]
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
#line 1 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\_ViewImports.cshtml"
using HighSchoolManagmentApp;

#line default
#line hidden
#line 2 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\_ViewImports.cshtml"
using HighSchoolManagmentApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebec38b562afdffdc685af148f132b757285f5a", @"/Views/absence/seance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51eb8edbfb824e78ee75096757a27726f6c13813", @"/Views/_ViewImports.cshtml")]
    public class Views_absence_seance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HighSchoolManagmentApp.Models.Seance>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\seance.cshtml"
  
    ViewData["Title"] = "student";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(257, 19, true);
            WriteLiteral("\r\n<h2>seance</h2>\r\n");
            EndContext();
            BeginContext(277, 10, false);
#line 11 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\seance.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(287, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(290, 12, false);
#line 12 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\seance.cshtml"
Write(Model.Number);

#line default
#line hidden
            EndContext();
            BeginContext(302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(305, 15, false);
#line 13 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\seance.cshtml"
Write(Model.subjectId);

#line default
#line hidden
            EndContext();
            BeginContext(320, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(323, 13, false);
#line 14 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\seance.cshtml"
Write(Model.salleId);

#line default
#line hidden
            EndContext();
            BeginContext(336, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HighSchoolManagmentApp.Models.Seance> Html { get; private set; }
    }
}
#pragma warning restore 1591