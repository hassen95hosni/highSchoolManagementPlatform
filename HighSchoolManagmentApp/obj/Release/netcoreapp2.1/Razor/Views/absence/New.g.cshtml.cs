#pragma checksum "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2700bb0d7df91e04b270c37c8f1c501802098881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_absence_New), @"mvc.1.0.view", @"/Views/absence/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/absence/New.cshtml", typeof(AspNetCore.Views_absence_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2700bb0d7df91e04b270c37c8f1c501802098881", @"/Views/absence/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51eb8edbfb824e78ee75096757a27726f6c13813", @"/Views/_ViewImports.cshtml")]
    public class Views_absence_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HighSchoolManagmentApp.ViewModel.AbsenceSeanceviewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
  
    ViewData["Title"] = "New";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 16, true);
            WriteLiteral("\r\n<h2>New</h2>\r\n");
            EndContext();
#line 8 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
 using (Html.BeginForm("Create", "absence"))
{

#line default
#line hidden
            BeginContext(215, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(254, 36, false);
#line 11 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.LabelFor(m => m.absence.raison));

#line default
#line hidden
            EndContext();
            BeginContext(290, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(301, 71, false);
#line 12 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.TextBoxFor(m => m.absence.raison, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(372, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(425, 34, false);
#line 15 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.LabelFor(m => m.absence.date));

#line default
#line hidden
            EndContext();
            BeginContext(459, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(470, 69, false);
#line 16 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.TextBoxFor(m => m.absence.date, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(539, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(592, 38, false);
#line 19 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.LabelFor(m => m.absence.seanceId));

#line default
#line hidden
            EndContext();
            BeginContext(630, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(641, 139, false);
#line 20 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.DropDownListFor(m => m.absence.seanceId, new SelectList(Model.seance, "Id", "Name"), "Select Seance", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(780, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(833, 39, false);
#line 23 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.LabelFor(m => m.absence.studentId));

#line default
#line hidden
            EndContext();
            BeginContext(872, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(883, 141, false);
#line 24 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
   Write(Html.DropDownListFor(m => m.absence.studentId, new SelectList(Model.student, "Id", "Name"), "Select Seance", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1042, 68, true);
            WriteLiteral("    <button type=\"submit\" class=\" btn btn_primary\"> save </button>\r\n");
            EndContext();
#line 29 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\New.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HighSchoolManagmentApp.ViewModel.AbsenceSeanceviewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
