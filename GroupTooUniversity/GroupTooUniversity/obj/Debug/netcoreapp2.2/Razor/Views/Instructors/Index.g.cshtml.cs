#pragma checksum "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5777c5855d3dc181bc8b44d0bee557e81e452c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Index.cshtml", typeof(AspNetCore.Views_Instructors_Index))]
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
#line 1 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\_ViewImports.cshtml"
using GroupTooUniversity;

#line default
#line hidden
#line 2 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\_ViewImports.cshtml"
using GroupTooUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5777c5855d3dc181bc8b44d0bee557e81e452c0", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e558f1fc3027a2d8e0c190949d8b3b982fceca", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupTooUniversity.Models.SchoolViewModels.InstructorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
  
  ViewData["Title"] = "Instructors";

#line default
#line hidden
            BeginContext(118, 33, true);
            WriteLiteral("\r\n<h2>Instructors</h2>\r\n\r\n<p>\r\n  ");
            EndContext();
            BeginContext(151, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5777c5855d3dc181bc8b44d0bee557e81e452c05268", async() => {
                BeginContext(174, 10, true);
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
            BeginContext(188, 252, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th>Last Name</th>\r\n      <th>First Name</th>\r\n      <th>E-mail</th>\r\n      <th>Hire Date</th>\r\n      <th>Office</th>\r\n      <th>Courses</th>\r\n      <th></th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
     foreach (var item in Model.Instructors)
    {
      string selectedRow = "";
      if (item.ID == (int?)ViewData["InstructorID"])
      {
        selectedRow = "success";
      }

#line default
#line hidden
            BeginContext(631, 7, true);
            WriteLiteral("    <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 638, "\"", 658, 1);
#line 32 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 646, selectedRow, 646, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 23, true);
            WriteLiteral(">\r\n      <td>\r\n        ");
            EndContext();
            BeginContext(683, 43, false);
#line 34 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(726, 35, true);
            WriteLiteral("\r\n      </td>\r\n      <td>\r\n        ");
            EndContext();
            BeginContext(762, 47, false);
#line 37 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(809, 35, true);
            WriteLiteral("\r\n      </td>\r\n      <td>\r\n        ");
            EndContext();
            BeginContext(845, 40, false);
#line 40 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(885, 35, true);
            WriteLiteral("\r\n      </td>\r\n      <td>\r\n        ");
            EndContext();
            BeginContext(921, 43, false);
#line 43 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(964, 27, true);
            WriteLiteral("\r\n      </td>\r\n      <td>\r\n");
            EndContext();
#line 46 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
         if (item.OfficeAssignment != null)
        {
          

#line default
#line hidden
            BeginContext(1058, 30, false);
#line 48 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
     Write(item.OfficeAssignment.Location);

#line default
#line hidden
            EndContext();
#line 48 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
                                         
        }

#line default
#line hidden
            BeginContext(1101, 25, true);
            WriteLiteral("      </td>\r\n      <td>\r\n");
            EndContext();
#line 52 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
          
          foreach (var course in item.CourseAssignments)
          {
            

#line default
#line hidden
            BeginContext(1222, 22, false);
#line 55 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
       Write(course.Course.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1247, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1250, 19, false);
#line 55 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
                                   Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1269, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 56 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
          }
        

#line default
#line hidden
            BeginContext(1302, 33, true);
            WriteLiteral("      </td>\r\n      <td>\r\n        ");
            EndContext();
            BeginContext(1335, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5777c5855d3dc181bc8b44d0bee557e81e452c011974", async() => {
                BeginContext(1381, 6, true);
                WriteLiteral("Select");
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
#line 60 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
                                WriteLiteral(item.ID);

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
            BeginContext(1391, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1403, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5777c5855d3dc181bc8b44d0bee557e81e452c014354", async() => {
                BeginContext(1448, 4, true);
                WriteLiteral("Edit");
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
#line 61 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
                               WriteLiteral(item.ID);

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
            BeginContext(1456, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1468, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5777c5855d3dc181bc8b44d0bee557e81e452c016731", async() => {
                BeginContext(1516, 7, true);
                WriteLiteral("Details");
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
#line 62 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
                                  WriteLiteral(item.ID);

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
            BeginContext(1527, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1539, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5777c5855d3dc181bc8b44d0bee557e81e452c019114", async() => {
                BeginContext(1586, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
                                 WriteLiteral(item.ID);

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
            BeginContext(1596, 26, true);
            WriteLiteral("\r\n      </td>\r\n    </tr>\r\n");
            EndContext();
#line 66 "C:\Users\chris\Source\Repos\quintanillach\GroupTooSurveys\GroupTooUniversity\GroupTooUniversity\Views\Instructors\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1629, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupTooUniversity.Models.SchoolViewModels.InstructorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591
