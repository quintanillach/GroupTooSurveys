#pragma checksum "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8173e3d95439496de0f4c9a1412f7a3f6135769c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Index.cshtml", typeof(AspNetCore.Views_Courses_Index))]
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
#line 1 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\_ViewImports.cshtml"
using GroupTooUniversity;

#line default
#line hidden
#line 2 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\_ViewImports.cshtml"
using GroupTooUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8173e3d95439496de0f4c9a1412f7a3f6135769c", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e558f1fc3027a2d8e0c190949d8b3b982fceca", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GroupTooUniversity.Models.Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
  
  ViewData["Title"] = "Courses";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h2>Courses</h2>\r\n\r\n<p>\r\n  ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8173e3d95439496de0f4c9a1412f7a3f6135769c4922", async() => {
                BeginContext(149, 10, true);
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
            BeginContext(163, 72, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th>\r\n        ");
            EndContext();
            BeginContext(236, 44, false);
#line 16 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.CourseID));

#line default
#line hidden
            EndContext();
            BeginContext(280, 35, true);
            WriteLiteral("\r\n      </th>\r\n      <th>\r\n        ");
            EndContext();
            BeginContext(316, 41, false);
#line 19 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(357, 35, true);
            WriteLiteral("\r\n      </th>\r\n      <th>\r\n        ");
            EndContext();
            BeginContext(393, 43, false);
#line 22 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(436, 35, true);
            WriteLiteral("\r\n      </th>\r\n      <th>\r\n        ");
            EndContext();
            BeginContext(472, 46, false);
#line 25 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(518, 66, true);
            WriteLiteral("\r\n      </th>\r\n      <th></th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(625, 36, true);
            WriteLiteral("      <tr>\r\n        <td>\r\n          ");
            EndContext();
            BeginContext(662, 43, false);
#line 35 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
     Write(Html.DisplayFor(modelItem => item.CourseID));

#line default
#line hidden
            EndContext();
            BeginContext(705, 41, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n          ");
            EndContext();
            BeginContext(747, 40, false);
#line 38 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
     Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(787, 41, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n          ");
            EndContext();
            BeginContext(829, 42, false);
#line 41 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
     Write(Html.DisplayFor(modelItem => item.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(871, 41, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n          ");
            EndContext();
            BeginContext(913, 50, false);
#line 44 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
     Write(Html.DisplayFor(modelItem => item.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(963, 41, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n          ");
            EndContext();
            BeginContext(1004, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8173e3d95439496de0f4c9a1412f7a3f6135769c10292", async() => {
                BeginContext(1055, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
                                 WriteLiteral(item.CourseID);

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
            BeginContext(1063, 14, true);
            WriteLiteral(" |\r\n          ");
            EndContext();
            BeginContext(1077, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8173e3d95439496de0f4c9a1412f7a3f6135769c12678", async() => {
                BeginContext(1131, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
                                    WriteLiteral(item.CourseID);

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
            BeginContext(1142, 14, true);
            WriteLiteral(" |\r\n          ");
            EndContext();
            BeginContext(1156, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8173e3d95439496de0f4c9a1412f7a3f6135769c15070", async() => {
                BeginContext(1209, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
                                   WriteLiteral(item.CourseID);

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
            BeginContext(1219, 30, true);
            WriteLiteral("\r\n        </td>\r\n      </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Not User\source\repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Courses\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1256, 20, true);
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GroupTooUniversity.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
