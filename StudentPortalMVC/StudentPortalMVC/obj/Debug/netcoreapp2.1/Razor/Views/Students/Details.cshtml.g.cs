#pragma checksum "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d16b2b186a2606d576c068c2ba7b31ee0b7a09ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
#line 1 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\_ViewImports.cshtml"
using StudentPortalMVC;

#line default
#line hidden
#line 2 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\_ViewImports.cshtml"
using StudentPortalMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d16b2b186a2606d576c068c2ba7b31ee0b7a09ff", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b5ef4b79dd48633f739b224a265fdeb4ba6b5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentPortalMVC.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 47, false);
#line 14 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentRule));

#line default
#line hidden
            EndContext();
            BeginContext(254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(298, 43, false);
#line 17 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentRule));

#line default
#line hidden
            EndContext();
            BeginContext(341, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(385, 47, false);
#line 20 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(476, 43, false);
#line 23 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(519, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(563, 46, false);
#line 26 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(609, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(653, 42, false);
#line 29 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(695, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(739, 46, false);
#line 32 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MotherName));

#line default
#line hidden
            EndContext();
            BeginContext(785, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(829, 42, false);
#line 35 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.MotherName));

#line default
#line hidden
            EndContext();
            BeginContext(871, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(915, 41, false);
#line 38 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(956, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1000, 37, false);
#line 41 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1081, 44, false);
#line 44 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MobileNo));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1169, 40, false);
#line 47 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.MobileNo));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1253, 47, false);
#line 50 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1344, 43, false);
#line 53 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1431, 42, false);
#line 56 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1517, 38, false);
#line 59 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1599, 44, false);
#line 62 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1687, 40, false);
#line 65 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1771, 47, false);
#line 68 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1862, 43, false);
#line 71 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1949, 46, false);
#line 74 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BloodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2039, 42, false);
#line 77 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.BloodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2125, 41, false);
#line 80 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Batch));

#line default
#line hidden
            EndContext();
            BeginContext(2166, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2210, 37, false);
#line 83 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Batch));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2291, 43, false);
#line 86 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2378, 39, false);
#line 89 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2417, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2461, 45, false);
#line 92 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2550, 41, false);
#line 95 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2591, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2635, 47, false);
#line 98 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2682, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2726, 43, false);
#line 101 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2769, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2813, 45, false);
#line 104 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2858, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2902, 41, false);
#line 107 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2943, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2987, 47, false);
#line 110 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3034, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3078, 43, false);
#line 113 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3121, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3165, 42, false);
#line 116 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3207, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3251, 38, false);
#line 119 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3289, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3333, 41, false);
#line 122 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(3374, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3418, 37, false);
#line 125 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(3455, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3502, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf7d6ff5ed2f41f1b4e2ee9dc6efa5e5", async() => {
                BeginContext(3555, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 130 "C:\C# Project and Solve\StudentPortalMVC\StudentPortalMVC\StudentPortalMVC\Views\Students\Details.cshtml"
                           WriteLiteral(Model.StudentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3563, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3571, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1fa1d4a09d4fb694ee563028ab3928", async() => {
                BeginContext(3593, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3609, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentPortalMVC.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591