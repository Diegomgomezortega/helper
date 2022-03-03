#pragma checksum "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc4a4301ff6f15a1d217fd93add50edb47ee69d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/anuncios")]
    public partial class ContenedorAnuncios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddAttribute(2, "b-jpwymvyv50");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "b-jpwymvyv50");
#nullable restore
#line 7 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
         if (anuncios == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<h3 class=\"text-center\" b-jpwymvyv50>No hay anuncios disponibles. Realiza el tuyo!</h3>");
#nullable restore
#line 10 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
        }
        else
        {
            if (anuncios.Count == 0)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<h3 b-jpwymvyv50>Cargando.....</h3>");
#nullable restore
#line 17 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                 foreach (var item in anuncios)
                {
                    switch (item.Tipo)
                    {
                        case 1:
                            TipoAnuncio = "Buscado";
                            colorHeader= "#ff9494";
                            break;
                        case 2:
                            TipoAnuncio = "En Adopción";
                            colorHeader= "#b3ffC0";
                            break;
                        case 3:
                            TipoAnuncio = "Encontrado";
                            colorHeader= "#c4cdff";
                            break;
                        default:
                            TipoAnuncio = "Buscado";
                            colorHeader = "#ff9494";
                            break;
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-4");
            __builder.AddAttribute(10, "b-jpwymvyv50");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card text-center");
            __builder.AddAttribute(13, "style", "width: 18rem; background-color: #FFEC84");
            __builder.AddAttribute(14, "b-jpwymvyv50");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-header");
            __builder.AddAttribute(17, "style", "background-color:" + (
#nullable restore
#line 43 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                                              colorHeader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-jpwymvyv50");
            __builder.OpenElement(19, "h2");
            __builder.AddAttribute(20, "class", "text-center");
            __builder.AddAttribute(21, "b-jpwymvyv50");
            __builder.AddContent(22, 
#nullable restore
#line 44 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                          TipoAnuncio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            <img src=\"/image/mascota2.jpg\" class=\"card-img-top\" alt=\"anuncio1\" b-jpwymvyv50>\r\n                            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-body");
            __builder.AddAttribute(26, "b-jpwymvyv50");
            __builder.OpenElement(27, "h3");
            __builder.AddAttribute(28, "class", "text-center");
            __builder.AddAttribute(29, "b-jpwymvyv50");
            __builder.AddContent(30, 
#nullable restore
#line 48 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                         item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "text-center");
            __builder.AddAttribute(34, "b-jpwymvyv50");
            __builder.AddContent(35, 
#nullable restore
#line 49 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                        item.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "ul");
            __builder.AddAttribute(38, "class", "list-group list-group-flush");
            __builder.AddAttribute(39, "b-jpwymvyv50");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "list-group-item");
            __builder.AddAttribute(42, "b-jpwymvyv50");
            __builder.AddContent(43, 
#nullable restore
#line 53 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                             item.Tamano

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "list-group-item");
            __builder.AddAttribute(47, "b-jpwymvyv50");
            __builder.AddContent(48, "Fecha:");
            __builder.AddContent(49, 
#nullable restore
#line 54 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                                   item.FechaSuceso.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "list-group-item");
            __builder.AddAttribute(53, "b-jpwymvyv50");
            __builder.AddContent(54, "Color: ");
            __builder.AddContent(55, 
#nullable restore
#line 55 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                                    item.ColorRGB1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(56, " - ");
            __builder.AddContent(57, 
#nullable restore
#line 55 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                                                                                      item.ColorRGB2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.AddMarkupContent(59, @"<div class=""card-body"" b-jpwymvyv50><button type=""button"" class=""btn btn-primary btn-sm btn-block"" b-jpwymvyv50>Lo ví</button>
                                <button type=""button"" class=""btn btn-success btn-sm btn-block"" b-jpwymvyv50>Lo tengo conmigo</button></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        <br b-jpwymvyv50>\r\n                        <br b-jpwymvyv50>");
            __builder.CloseElement();
#nullable restore
#line 65 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
                 


            }



        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
       

    string TipoAnuncio;
    string colorHeader;

    List<Helper.Shared.Data.Entidades.Anuncio> anuncios=new List<Helper.Shared.Data.Entidades.Anuncio>();

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();
        await TraerAnuncios();
    }
    private async Task TraerAnuncios()
    {
        var respuestaHttp = await http.Get<List<Helper.Shared.Data.Entidades.Anuncio>>("api/publicaciones");
        if (!respuestaHttp.Error)
        {
            anuncios = respuestaHttp.Respuesta;

        }



    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService http { get; set; }
    }
}
#pragma warning restore 1591
