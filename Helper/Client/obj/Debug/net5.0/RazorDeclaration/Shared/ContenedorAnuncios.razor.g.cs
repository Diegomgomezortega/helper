// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 14 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\_Imports.razor"
using Helper.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/anuncios")]
    public partial class ContenedorAnuncios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\ContenedorAnuncios.razor"
       
    bool mostrarModal = false;

    string TipoAnuncio;
    string colorHeader;

    DateTime fecha;
    Anuncio completo = new();
    AnuncioModal anuncioModal;

    List<Helper.Shared.Data.Entidades.Anuncio> anuncios = new List<Helper.Shared.Data.Entidades.Anuncio>();

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
    private void AnuncioCompleto(Anuncio anuncio)
    {

        completo = anuncio;
        TipoPublicacion(completo);

    }

    private void TipoPublicacion(Anuncio anuncio)
    {
        switch (anuncio.Tipo)
        {
            case 1:
                TipoAnuncio = "Buscado";
                colorHeader = "#ff9494";


                break;
            case 2:
                TipoAnuncio = "En Adopción";
                colorHeader = "#b3ffC0";
                break;
            case 3:
                TipoAnuncio = "Encontrado";
                colorHeader = "#c4cdff";
                break;
            default:
                TipoAnuncio = "Buscado";
                colorHeader = "#ff9494";
                break;
        }
        

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService http { get; set; }
    }
}
#pragma warning restore 1591
