#pragma checksum "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4356246eb23d2e5e41e8662193b0a3c0aafaffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SCCRequests_Delete), @"mvc.1.0.view", @"/Views/SCCRequests/Delete.cshtml")]
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
#line 1 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\_ViewImports.cshtml"
using ScheduleChange;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\_ViewImports.cshtml"
using ScheduleChange.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4356246eb23d2e5e41e8662193b0a3c0aafaffc", @"/Views/SCCRequests/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c5644d2fdad2257ef778e358a30c225fed435c", @"/Views/_ViewImports.cshtml")]
    public class Views_SCCRequests_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScheduleChange.Data.SCCRequest>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>SCCRequest</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MessageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MessageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SCType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SCType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Airline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Airline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FlightDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FlightDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoardPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoardPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OffPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OffPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoardTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoardTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OffTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OffTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Frequency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Frequency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DayChangeIndicator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DayChangeIndicator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EquipType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EquipType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EquipConfig));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EquipConfig));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SCReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SCReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Overbooking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Overbooking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProtectionPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProtectionPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VIPNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VIPNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OtherNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4356246eb23d2e5e41e8662193b0a3c0aafaffc16751", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4356246eb23d2e5e41e8662193b0a3c0aafaffc17018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 125 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequests\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4356246eb23d2e5e41e8662193b0a3c0aafaffc18813", async() => {
                    WriteLiteral("Back to List");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScheduleChange.Data.SCCRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
