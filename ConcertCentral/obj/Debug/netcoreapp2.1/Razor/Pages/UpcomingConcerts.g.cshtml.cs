#pragma checksum "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968944358768ffee61a140d9d17039715e91a8b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConcertCentral.Pages.Pages_UpcomingConcerts), @"mvc.1.0.razor-page", @"/Pages/UpcomingConcerts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UpcomingConcerts.cshtml", typeof(ConcertCentral.Pages.Pages_UpcomingConcerts), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968944358768ffee61a140d9d17039715e91a8b1", @"/Pages/UpcomingConcerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7439dfd0da02ade7615b3431287896f35b039024", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UpcomingConcerts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
  
    ViewData["Title"] = "Upcoming Concerts";

#line default
#line hidden
            BeginContext(87, 57, true);
            WriteLiteral("    <link rel=\"icon\" href=\"/images/ConcertCentral.png\">\r\n");
            EndContext();
            BeginContext(147, 673, true);
            WriteLiteral(@"<h1>Upcoming Concerts</h1>

<table class=""table table-bordered ""style=""text-align:center;"">
    <thead>
        <tr >
            <th style=""text-align:center;"">#</th>
            <th style=""text-align:center;"">Concert Name</th>
            <th style=""text-align:center;"">Venue</th>
            <th style=""text-align:center;"">Concert Date</th>
            <th style=""text-align:center;"">Band Performing</th>
            <th style=""text-align:center;"">Parking Availability</th>
            <th style=""text-align:center;"">Ticket Range</th>
            <th style=""text-align:center;"">Seats Available</th>
        </tr>
    </thead>
    <tbody>
    
        
");
            EndContext();
#line 25 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
         for (var counter = 0; counter < Model.Concerts.Count(); counter++)
        {
            var i = Model.Concerts[counter];

#line default
#line hidden
            BeginContext(954, 40, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>");
            EndContext();
            BeginContext(996, 11, false);
#line 30 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
                Write(counter + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1036, 6, false);
#line 31 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
               Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1070, 7, false);
#line 32 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
               Write(i.Venue);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1105, 13, false);
#line 33 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
               Write(i.ConcertDate);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1146, 11, false);
#line 34 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
               Write(i.Band.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 36 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
                 if(i.ParkingAvailability)
                {
                    

#line default
#line hidden
            BeginContext(1275, 9, true);
            WriteLiteral("Available");
            EndContext();
#line 38 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
                                          
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1379, 11, true);
            WriteLiteral("Unavailable");
            EndContext();
#line 42 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
                                            
                }

#line default
#line hidden
            BeginContext(1416, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1444, 10, false);
#line 44 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
               Write(i.MinPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1454, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1458, 10, false);
#line 44 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
                             Write(i.MaxPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1468, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1496, 16, false);
#line 45 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
               Write(i.SeatsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(1517, 12, false);
#line 45 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
                                    Write(i.SeatStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1529, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\UpcomingConcerts.cshtml"
        }

#line default
#line hidden
            BeginContext(1568, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpcomingConcertsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpcomingConcertsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpcomingConcertsModel>)PageContext?.ViewData;
        public UpcomingConcertsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
