#pragma checksum "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3851f65d5d2c21a02acd415200118c523f0ea946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConcertCentral.Pages.Pages_TopEventPlanners), @"mvc.1.0.razor-page", @"/Pages/TopEventPlanners.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TopEventPlanners.cshtml", typeof(ConcertCentral.Pages.Pages_TopEventPlanners), null)]
namespace ConcertCentral.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3851f65d5d2c21a02acd415200118c523f0ea946", @"/Pages/TopEventPlanners.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7439dfd0da02ade7615b3431287896f35b039024", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TopEventPlanners : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
  
    ViewData["Title"] = "Top Event Planners";

#line default
#line hidden
            BeginContext(88, 57, true);
            WriteLiteral("    <link rel=\"icon\" href=\"/images/ConcertCentral.png\">\r\n");
            EndContext();
            BeginContext(148, 50, true);
            WriteLiteral("<div>  \r\n    <h1>Top Event Planners</h1>\r\n    <h2>");
            EndContext();
            BeginContext(199, 23, false);
#line 9 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
   Write(Model.EventPlanner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(222, 280, true);
            WriteLiteral(@"</h2>
    <table class=""table"">
        <tr>
            <th>Concert Name</th>
            <th>Venue</th>
            <th>Concert Date</th>
            <th>Parking Availability</th>
            <th>Ticket Range </th>
            <th>Seats Available</th>
        </tr>

");
            EndContext();
#line 20 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
         foreach (var x in @Model.EventPlanner.Concerts)
        {

#line default
#line hidden
            BeginContext(571, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(602, 6, false);
#line 23 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
           Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(608, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(632, 7, false);
#line 24 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
           Write(x.Venue);

#line default
#line hidden
            EndContext();
            BeginContext(639, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(663, 13, false);
#line 25 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
           Write(x.ConcertDate);

#line default
#line hidden
            EndContext();
            BeginContext(676, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 27 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
                 if(x.ParkingAvailability)
                {
                    

#line default
#line hidden
            BeginContext(790, 9, true);
            WriteLiteral("Available");
            EndContext();
#line 29 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
                                          
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(894, 11, true);
            WriteLiteral("Unavailable");
            EndContext();
#line 33 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
                                            
                }

#line default
#line hidden
            BeginContext(933, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(969, 10, false);
#line 36 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
           Write(x.MinPrice);

#line default
#line hidden
            EndContext();
            BeginContext(979, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(983, 10, false);
#line 36 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
                         Write(x.MaxPrice);

#line default
#line hidden
            EndContext();
            BeginContext(993, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1017, 16, false);
#line 37 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
           Write(x.SeatsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(1033, 23, true);
            WriteLiteral("</td>\r\n         </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\TopEventPlanners.cshtml"
        }

#line default
#line hidden
            BeginContext(1067, 22, true);
            WriteLiteral("    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopEventPlannersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopEventPlannersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopEventPlannersModel>)PageContext?.ViewData;
        public TopEventPlannersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
