#pragma checksum "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce4bad052b5c206fd9d9db43485552ce8deb2e2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SCCRequestModels_Details), @"mvc.1.0.view", @"/Views/SCCRequestModels/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce4bad052b5c206fd9d9db43485552ce8deb2e2a", @"/Views/SCCRequestModels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c5644d2fdad2257ef778e358a30c225fed435c", @"/Views/_ViewImports.cshtml")]
    public class Views_SCCRequestModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScheduleChange.Models.SCCRequestModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>SCCRequestModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MessageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.MessageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SCType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.SCType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Airline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Airline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FlightDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.FlightDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BoardPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.BoardPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OffPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.OffPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BoardTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.BoardTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OffTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.OffTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Frequency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Frequency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DayChangeIndicator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.DayChangeIndicator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EquipType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.EquipType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EquipConfig));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.EquipConfig));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SCReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.SCReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Overbooking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Overbooking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProtectionPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProtectionPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VIPNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.VIPNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.OtherNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce4bad052b5c206fd9d9db43485552ce8deb2e2a16269", async() => {
                WriteLiteral("Edit");
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
#line 124 "E:\SCC\ScheduleChange\ScheduleChangeWeb\ScheduleChange\Views\SCCRequestModels\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce4bad052b5c206fd9d9db43485552ce8deb2e2a18426", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScheduleChange.Models.SCCRequestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
