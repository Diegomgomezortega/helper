#pragma checksum "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc4bb179b04588f0be0a0ff8a30c0135f52c273"
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
#nullable restore
#line 11 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Helper.Client.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Helper.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Helper.Shared.Data.Entidades;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.AddAttribute(2, "b-wtp8v772pj");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddAttribute(5, "b-wtp8v772pj");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href=\"#\" b-wtp8v772pj>Helper</a>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "navbar-toggler");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "data-bs-toggle", "collapse");
            __builder.AddAttribute(12, "data-bs-target", "#navbarNav");
            __builder.AddAttribute(13, "aria-controls", "navbarNav");
            __builder.AddAttribute(14, "aria-expanded", "false");
            __builder.AddAttribute(15, "aria-label", "Toggle navigation");
            __builder.AddAttribute(16, "b-wtp8v772pj");
            __builder.AddMarkupContent(17, "<span class=\"navbar-toggler-icon\" b-wtp8v772pj></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "collapse navbar-collapse");
            __builder.AddAttribute(21, "id", "navbarNav");
            __builder.AddAttribute(22, "b-wtp8v772pj");
            __builder.OpenElement(23, "ul");
            __builder.AddAttribute(24, "class", "navbar-nav");
            __builder.AddAttribute(25, "b-wtp8v772pj");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item");
            __builder.AddAttribute(28, "b-wtp8v772pj");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "");
            __builder.AddAttribute(32, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 18 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<li class=\"nav-item\" b-wtp8v772pj><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" b-wtp8v772pj>Inicio</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item");
            __builder.AddAttribute(38, "b-wtp8v772pj");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<a class=\"nav-link active\" aria-current=\"page\" href=\"anuncios\" b-wtp8v772pj>Todos</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "nav-item");
            __builder.AddAttribute(46, "b-wtp8v772pj");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "nav-link");
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(50, "<a class=\"nav-link active\" aria-current=\"page\" href=\"perdidos\" b-wtp8v772pj>Perdidos</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "li");
            __builder.AddAttribute(53, "class", "nav-item");
            __builder.AddAttribute(54, "b-wtp8v772pj");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
            __builder.AddAttribute(56, "class", "nav-link");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "<a class=\"nav-link active\" aria-current=\"page\" href=\"adopciones\" b-wtp8v772pj>En adopción</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "li");
            __builder.AddAttribute(61, "class", "nav-item");
            __builder.AddAttribute(62, "b-wtp8v772pj");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(63);
            __builder.AddAttribute(64, "class", "nav-link");
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(66, "<a class=\"nav-link active\" aria-current=\"page\" href=\"anuncios/nuevo\" b-wtp8v772pj>Nuevo Anuncio</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\NavMenu.razor"
       
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
