#pragma checksum "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83dc6b56333e009fff4f9eb9b4fe770878ae1983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_absence), @"mvc.1.0.view", @"/Views/Student/absence.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/absence.cshtml", typeof(AspNetCore.Views_Student_absence))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83dc6b56333e009fff4f9eb9b4fe770878ae1983", @"/Views/Student/absence.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51eb8edbfb824e78ee75096757a27726f6c13813", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_absence : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HighSchoolManagmentApp.Models.Absence>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
  
    ViewData["Title"] = "All Absence";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 35, true);
            WriteLiteral("\r\n<h2>All Absence</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(192, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92660b4f38a34554913d7f8423c38e2f", async() => {
                BeginContext(212, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(226, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(319, 38, false);
#line 18 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(357, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(413, 42, false);
#line 21 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
           Write(Html.DisplayNameFor(model => model.seance));

#line default
#line hidden
            EndContext();
            BeginContext(455, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(511, 40, false);
#line 24 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
           Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(551, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(607, 45, false);
#line 27 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
           Write(Html.DisplayNameFor(model => model.studentId));

#line default
#line hidden
            EndContext();
            BeginContext(652, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(708, 42, false);
#line 30 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
           Write(Html.DisplayNameFor(model => model.raison));

#line default
#line hidden
            EndContext();
            BeginContext(750, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(885, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(946, 37, false);
#line 40 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(983, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1051, 43, false);
#line 43 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.DisplayFor(modelItem => item.seanceId));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1117, 63, false);
#line 44 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.ActionLink("seance", "seance", new { id = item.seanceId }));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1248, 39, false);
#line 47 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1355, 44, false);
#line 50 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.DisplayFor(modelItem => item.studentId));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1422, 66, false);
#line 51 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.ActionLink("student", "student", new { id = item.studentId }));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1556, 41, false);
#line 54 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.DisplayFor(modelItem => item.raison));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    ");
            EndContext();
            BeginContext(1667, 57, false);
#line 58 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 61 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\Student\absence.cshtml"
        }

#line default
#line hidden
            BeginContext(1779, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HighSchoolManagmentApp.Models.Absence>> Html { get; private set; }
    }
}
#pragma warning restore 1591
