#pragma checksum "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\HomePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4fbeeeca701244aca0c7352f7cd92020bb461c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestingCosmos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using TestingCosmos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\_Imports.razor"
using TestingCosmos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\HomePage.razor"
using controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\HomePage.razor"
using TestingCosmos.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\HomePage.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\HomePage.razor"
using TestingCosmos.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class HomePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\HomePage.razor"
       

    private HomeData homeData;

     protected override async Task OnInitializedAsync()
     {
        homeData = await processHomeData.GetHomeData();

     }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProcessHomeData processHomeData { get; set; }
    }
}
#pragma warning restore 1591