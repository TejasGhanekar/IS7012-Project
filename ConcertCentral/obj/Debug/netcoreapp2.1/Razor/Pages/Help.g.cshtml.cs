#pragma checksum "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b7adb2bf9b74a17f322319f4ab8858a3f56904"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConcertCentral.Pages.Pages_Help), @"mvc.1.0.razor-page", @"/Pages/Help.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Help.cshtml", typeof(ConcertCentral.Pages.Pages_Help), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b7adb2bf9b74a17f322319f4ab8858a3f56904", @"/Pages/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7439dfd0da02ade7615b3431287896f35b039024", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Help : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Tejas\Documents\GitHub\IS7012-Project\ConcertCentral\Pages\Help.cshtml"
  
     ViewData["Title"] = "Help";

#line default
#line hidden
            BeginContext(63, 57, true);
            WriteLiteral("    <link rel=\"icon\" href=\"/images/ConcertCentral.png\">\r\n");
            EndContext();
            BeginContext(123, 2359, true);
            WriteLiteral(@"<div>
    <p>
        <h3>The help page depicts the functionality of the website</h3>
    </p>
</div>
<hr/>
<div>
    <p>
        1. The ""Home"" page displays the relevant statistics and information related to the upcoming concerts.
        <img src = ""/images/Home.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        2. The ""About"" page displays the information regarding Concert Central and its owners.
        <img src = ""/images/About.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        3. The Admin can create a Band Profile and perform all the other CRUD oprations on it.
        <img src = ""/images/CreateBand.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        4. The Admin can create a Event Planner profile and perform all the other CRUD oprations on it.
        <img src = ""/images/CreateEventPlanner.PNG""> 
    </p>
       
</div>

<hr/>

<div>
    <p>
        5. The Admin can create a Concert profile and perform all the other CRUD oprations on it.
        <i");
            WriteLiteral(@"mg src = ""/images/CreateConcert.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        6. A user can see the consolidated view of all the concerts in the ""Upcoming Concerts"" tab.
        <img src = ""/images/UpcomingConcerts.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        7. The ""Top Bands Performing"" tab shows the information about the concerts of the top bands that are performing.
        <img src = ""/images/TopBands.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        8. The ""Top Event Planners"" tab shows the information about the concerts of the top Event Planers in the world.
        <img src = ""/images/TopEventPlanners.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        9. A user can search for any upcoming concert using the ""Search Concerts"" tab, by the concert name.
        <img src = ""/images/SearchConcert.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        10. A user can send his queries or grievance in the form of a message using the ""Contact Us""");
            WriteLiteral(@" tab .
        <img src = ""/images/ContactUs.PNG"">
    </p>

</div>

<hr/>

<div>
    <p>
        11. An Event Planner can change the minimum and maximum ticket price of a concert using the ""Edit Ticekt Price"" tab .
        <img src = ""/images/UpdateTicketPrice.PNG"">
    </p>

</div>

<hr/>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelpModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelpModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelpModel>)PageContext?.ViewData;
        public HelpModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
