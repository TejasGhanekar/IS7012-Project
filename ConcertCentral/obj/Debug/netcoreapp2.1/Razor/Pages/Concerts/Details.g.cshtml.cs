#pragma checksum "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114b95c19bb1cd6a4f5c248a81edec24e1c1ccf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConcertCentral.Pages.Concerts.Pages_Concerts_Details), @"mvc.1.0.razor-page", @"/Pages/Concerts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Concerts/Details.cshtml", typeof(ConcertCentral.Pages.Concerts.Pages_Concerts_Details), null)]
namespace ConcertCentral.Pages.Concerts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\_ViewImports.cshtml"
using ConcertCentral;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114b95c19bb1cd6a4f5c248a81edec24e1c1ccf1", @"/Pages/Concerts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7439dfd0da02ade7615b3431287896f35b039024", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Concerts_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(100, 57, true);
            WriteLiteral("    <link rel=\"icon\" href=\"/images/ConcertCentral.png\">\r\n");
            EndContext();
            BeginContext(160, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Concert</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(282, 48, false);
#line 16 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.Name));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(374, 44, false);
#line 19 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.Name));

#line default
#line hidden
            EndContext();
            BeginContext(418, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(462, 49, false);
#line 22 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.Venue));

#line default
#line hidden
            EndContext();
            BeginContext(511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(555, 45, false);
#line 25 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.Venue));

#line default
#line hidden
            EndContext();
            BeginContext(600, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(644, 55, false);
#line 28 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.ConcertDate));

#line default
#line hidden
            EndContext();
            BeginContext(699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(743, 51, false);
#line 31 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.ConcertDate));

#line default
#line hidden
            EndContext();
            BeginContext(794, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(838, 63, false);
#line 34 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.ParkingAvailability));

#line default
#line hidden
            EndContext();
            BeginContext(901, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(945, 59, false);
#line 37 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.ParkingAvailability));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1048, 52, false);
#line 40 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.MinPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1144, 48, false);
#line 43 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.MinPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1236, 52, false);
#line 46 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.MaxPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1332, 48, false);
#line 49 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.MaxPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1424, 58, false);
#line 52 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.SeatsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1526, 54, false);
#line 55 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.SeatsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1624, 48, false);
#line 58 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.Band));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1716, 47, false);
#line 61 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.Band.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1807, 56, false);
#line 64 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concert.EventPlanner));

#line default
#line hidden
            EndContext();
            BeginContext(1863, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1907, 55, false);
#line 67 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concert.EventPlanner.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2009, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7addbb0b940d4026880674c3d4a3ca2d", async() => {
                BeginContext(2063, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Concerts\Details.cshtml"
                           WriteLiteral(Model.Concert.Id);

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
            BeginContext(2071, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2079, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de61fffec2774324a5e095de63f9184e", async() => {
                BeginContext(2101, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2117, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConcertCentral.Pages.Concerts.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConcertCentral.Pages.Concerts.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConcertCentral.Pages.Concerts.DetailsModel>)PageContext?.ViewData;
        public ConcertCentral.Pages.Concerts.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
