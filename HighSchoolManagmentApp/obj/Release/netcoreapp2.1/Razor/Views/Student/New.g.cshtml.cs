#pragma checksum "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999c0c53d8c1f7600bbdc338c4bd44bd8c5b3854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_New), @"mvc.1.0.view", @"/Views/Student/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/New.cshtml", typeof(AspNetCore.Views_Student_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999c0c53d8c1f7600bbdc338c4bd44bd8c5b3854", @"/Views/Student/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51eb8edbfb824e78ee75096757a27726f6c13813", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HighSchoolManagmentApp.ViewModel.StudentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
  
    ViewData["Title"] = "New";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 16, true);
            WriteLiteral("\r\n<h2>New</h2>\r\n");
            EndContext();
#line 8 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
 using (Html.BeginForm("create", "student"))
{

#line default
#line hidden
            BeginContext(209, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(248, 34, false);
#line 11 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
   Write(Html.LabelFor(m => m.student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(282, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(293, 69, false);
#line 12 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
   Write(Html.TextBoxFor(m => m.student.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(362, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(378, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(417, 40, false);
#line 16 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
   Write(Html.LabelFor(m => m.student.familyName));

#line default
#line hidden
            EndContext();
            BeginContext(457, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(468, 75, false);
#line 17 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
   Write(Html.TextBoxFor(m => m.student.familyName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(543, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(596, 37, false);
#line 20 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
   Write(Html.LabelFor(m => m.student.gradeId));

#line default
#line hidden
            EndContext();
            BeginContext(633, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(644, 137, false);
#line 21 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
   Write(Html.DropDownListFor(m => m.student.gradeId , new SelectList(Model.grade, "Id", "Name"), "Select grade", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(781, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(800, 68, true);
            WriteLiteral("    <button type=\"submit\" class=\" btn btn_primary\"> save </button>\r\n");
            EndContext();
#line 25 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\New.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HighSchoolManagmentApp.ViewModel.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
