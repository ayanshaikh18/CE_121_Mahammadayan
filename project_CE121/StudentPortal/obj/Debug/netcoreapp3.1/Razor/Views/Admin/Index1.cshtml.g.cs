#pragma checksum "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "543bf4e0f7fad79cb3052ffc63216f3d7cf2a99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index1), @"mvc.1.0.view", @"/Views/Admin/Index1.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\_ViewImports.cshtml"
using StudentPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\_ViewImports.cshtml"
using StudentPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\_ViewImports.cshtml"
using StudentPortal.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"543bf4e0f7fad79cb3052ffc63216f3d7cf2a99e", @"/Views/Admin/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce12b4e7eab16e16dace5aa27e585d92feff818", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentPortal.ViewModels.AdminHomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral(@"
<br />
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-12 text-center""><h4 class=""text-dark"">Department Wise List Of Students & Faculties</h4></div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""accordion"" id=""accordionExample"">
");
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                 foreach (var dept in Enum.GetValues(typeof(Branch)))
                {
                    var headingId = dept + "Heading";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 605, "\"", 620, 1);
#nullable restore
#line 16 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
WriteAttributeValue("", 610, headingId, 610, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h2 class=\"mb-0\">\r\n                                <button class=\"btn btn-link btn-block text-left\" type=\"button\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 18 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                                                                                                               Write(dept);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\r\n                                    ");
#nullable restore
#line 19 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                               Write(dept);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </button>\r\n                            </h2>\r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 1042, "\"", 1052, 1);
#nullable restore
#line 23 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
WriteAttributeValue("", 1047, dept, 1047, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1070, "\"", 1098, 1);
#nullable restore
#line 23 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
WriteAttributeValue("", 1088, headingId, 1088, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionExample\">\r\n                            <div class=\"card-body row\">\r\n                                <div class=\"col-sm-6\">\r\n                                    <h5>Faculties : </h5><br />\r\n");
#nullable restore
#line 27 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                     if (Model.Faculties.Where(f => f.Branch == (Branch)dept).Count() == 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("No Faculty is registered.");
#nullable restore
#line 29 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                                                              
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                     foreach (var faculty in Model.Faculties.Where(f => f.Branch == (Branch)dept))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "543bf4e0f7fad79cb3052ffc63216f3d7cf2a99e8479", async() => {
#nullable restore
#line 33 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                                                                          Write(faculty.Name);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 33 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                                                      WriteLiteral(faculty.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("<br />\r\n");
#nullable restore
#line 34 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"col-sm-6\">\r\n                                    <h5>Students</h5><br />\r\n");
#nullable restore
#line 38 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                     if (Model.Students.Where(f => f.Branch == (Branch)dept).Count() == 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("No Student is registered.");
#nullable restore
#line 40 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                                                              
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                     foreach (var student in Model.Students.Where(f => f.Branch == (Branch)dept))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "543bf4e0f7fad79cb3052ffc63216f3d7cf2a99e12386", async() => {
#nullable restore
#line 44 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                                                                          Write(student.Name);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 44 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                                                      WriteLiteral(student.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("<br />\r\n");
#nullable restore
#line 45 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\lenovo\source\repos\StudentPortal\StudentPortal\Views\Admin\Index1.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-sm-12"">
            <nav aria-label=""..."">
                <ul class=""pagination pagination-lg justify-content-center"">
                    <li class=""page-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "543bf4e0f7fad79cb3052ffc63216f3d7cf2a99e15689", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""page-item active"" aria-current=""page"">
                        <span class=""page-link"">
                            2
                            <span class=""sr-only"">(current)</span>
                        </span>
                    </li>

                </ul>
            </nav>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentPortal.ViewModels.AdminHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
