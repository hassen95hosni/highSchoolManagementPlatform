#pragma checksum "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283096a4a7d9065d4a1ed9c1947f78b8c36cb77c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_absence_All), @"mvc.1.0.view", @"/Views/absence/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/absence/All.cshtml", typeof(AspNetCore.Views_absence_All))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283096a4a7d9065d4a1ed9c1947f78b8c36cb77c", @"/Views/absence/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51eb8edbfb824e78ee75096757a27726f6c13813", @"/Views/_ViewImports.cshtml")]
    public class Views_absence_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HighSchoolManagmentApp.Models.Absence>>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
  
    ViewData["Title"] = "All Absence";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 35, true);
            WriteLiteral("\r\n<h2>All Absence</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(190, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e26bca70640f4ffda89d9677c5d80e6c", async() => {
                BeginContext(210, 10, true);
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
            BeginContext(224, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(317, 38, false);
#line 17 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 42, false);
#line 20 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.seance));

#line default
#line hidden
            EndContext();
            BeginContext(453, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(509, 40, false);
#line 23 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(549, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(605, 45, false);
#line 26 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.studentId));

#line default
#line hidden
            EndContext();
            BeginContext(650, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(706, 42, false);
#line 29 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.raison));

#line default
#line hidden
            EndContext();
            BeginContext(748, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(866, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(915, 37, false);
#line 38 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1008, 43, false);
#line 41 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.seanceId));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1070, 63, false);
#line 42 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.ActionLink("seance", "seance", new { id = item.seanceId }));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1189, 39, false);
#line 45 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1284, 44, false);
#line 48 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.studentId));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1347, 66, false);
#line 49 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.ActionLink("student", "student", new { id = item.studentId }));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1469, 41, false);
#line 52 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.raison));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(1568, 57, false);
#line 56 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 59 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
}

#line default
#line hidden
            BeginContext(1664, 24, true);
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
