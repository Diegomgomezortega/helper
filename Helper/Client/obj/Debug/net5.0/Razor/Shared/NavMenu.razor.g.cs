#pragma checksum "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed89fdbf8b5429e9c0942cb30aeb6c08c464c0dd"
// <auto-generated/>
#pragma warning disable 1591
namespace Helper.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Helper.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Helper.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<nav class=""navbar navbar-expand-lg navbar-light bg-light"" b-wtp8v772pj><div class=""container-fluid"" b-wtp8v772pj><a class=""navbar-brand"" href=""#"" b-wtp8v772pj>Navbar</a>
        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-wtp8v772pj><span class=""navbar-toggler-icon"" b-wtp8v772pj></span></button>
        <div class=""collapse navbar-collapse"" id=""navbarNav"" b-wtp8v772pj><ul class=""navbar-nav"" b-wtp8v772pj><li class=""nav-item"" b-wtp8v772pj><a class=""nav-link active"" aria-current=""page"" href=""#"" b-wtp8v772pj>Home</a></li>
                <li class=""nav-item"" b-wtp8v772pj><a class=""nav-link"" href=""#"" b-wtp8v772pj>Features</a></li>
                <li class=""nav-item"" b-wtp8v772pj><a class=""nav-link"" href=""#"" b-wtp8v772pj>Pricing</a></li>
                <li class=""nav-item"" b-wtp8v772pj><a class=""nav-link disabled"" href=""#"" tabindex=""-1"" aria-disabled=""true"" b-wtp8v772pj>Disabled</a></li></ul></div></div></nav>");
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
