#pragma checksum "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42dbe46c8a28cd8179a89457d415bfe92bc20f53"
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
#line 3 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\FetchData.razor"
using TestingCosmos.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Development\Christian_RnD\TestingCosmos\TestingCosmos\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
