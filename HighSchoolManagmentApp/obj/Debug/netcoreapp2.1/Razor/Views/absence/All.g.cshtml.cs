#pragma checksum "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a284b2dcebf0d2f572844e328119f8254f04657c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a284b2dcebf0d2f572844e328119f8254f04657c", @"/Views/absence/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51eb8edbfb824e78ee75096757a27726f6c13813", @"/Views/_ViewImports.cshtml")]
    public class Views_absence_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HighSchoolManagmentApp.Models.Absence>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2>All absence</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(190, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32abfa7b96d4d5c952340736a28c41d", async() => {
                BeginContext(213, 10, true);
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
            BeginContext(227, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(320, 38, false);
#line 17 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(358, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(414, 42, false);
#line 20 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.seance));

#line default
#line hidden
            EndContext();
            BeginContext(456, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(512, 40, false);
#line 23 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(552, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(608, 42, false);
#line 26 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
           Write(Html.DisplayNameFor(model => model.raison));

#line default
#line hidden
            EndContext();
            BeginContext(650, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(785, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(846, 37, false);
#line 36 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(883, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(951, 41, false);
#line 39 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.seance));

#line default
#line hidden
            EndContext();
            BeginContext(992, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1060, 39, false);
#line 42 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1167, 41, false);
#line 45 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.raison));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1276, 65, false);
#line 48 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1366, 71, false);
#line 49 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1462, 69, false);
#line 50 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 53 "S:\asp\HisghSchoolManagment\High School Managment Platform\HighSchoolManagmentApp\Views\absence\All.cshtml"
        }

#line default
#line hidden
            BeginContext(1586, 24, true);
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