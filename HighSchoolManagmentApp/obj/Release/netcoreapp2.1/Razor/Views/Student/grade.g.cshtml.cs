#pragma checksum "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\grade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa0b5fe35a6612aa1c2d4adf9ef905015a62996"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_grade), @"mvc.1.0.view", @"/Views/Student/grade.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/grade.cshtml", typeof(AspNetCore.Views_Student_grade))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffa0b5fe35a6612aa1c2d4adf9ef905015a62996", @"/Views/Student/grade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51eb8edbfb824e78ee75096757a27726f6c13813", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_grade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HighSchoolManagmentApp.Models.Grade>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\grade.cshtml"
  
    ViewData["Title"] = "grade";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 18, true);
            WriteLiteral("\r\n<h2>grade</h2>\r\n");
            EndContext();
            BeginContext(151, 10, false);
#line 8 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\grade.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(164, 62, false);
#line 9 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\grade.cshtml"
Write(Html.ActionLink("schedule", "schedule", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(226, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HighSchoolManagmentApp.Models.Grade> Html { get; private set; }
    }
}
#pragma warning restore 1591
