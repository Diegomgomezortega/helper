// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Helper.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar/{anuncioId:int}")]
    public partial class EditarAnuncio : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Pages\EditarAnuncio.razor"
       
    string colorHeader;
    private IList<string> ImageDateUrls = new List<string>();
    private Anuncio anuncio;
    bool mostrarNombre;
    [Parameter] public int anuncioId { get; set; }


    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();
        await TraerAnuncio();
        ImagenPrevia(anuncio);
    }
    private async Task TraerAnuncio()
    {
        var respuestaHttp = await http.Get<Anuncio>($"api/publicaciones/{anuncioId}");
        if (!respuestaHttp.Error)
        {
            anuncio = respuestaHttp.Respuesta;

        }
        if (respuestaHttp.Error)
        {
            var body = await respuestaHttp.GetBody();//Sitenemos un error, se va a mostrar
        }

    }
    private void ImagenPrevia(Anuncio item)
    {
        //int tipo1 = item.Tipo;
        TipoPublicacion();
        var format = "image/jpg";
        var imageDataUrl = $"data:{format};base64,{Convert.ToBase64String(item.Foto)}";
        item.RutaFoto = imageDataUrl;

    }
    private void TipoPublicacion()
    {
        switch (anuncio.Tipo)
        {
            case 1:
                colorHeader = "#ff9494";
                anuncio.Estado = "Perdido";
                mostrarNombre = true;

                break;
            case 2:
                colorHeader = "#FFF664";
                anuncio.Estado = "En Adopción";
                mostrarNombre = true;

                break;
            case 3:
                colorHeader = "#7aff33";
                anuncio.Estado = "Encontrado";
                mostrarNombre = false;

                break;
                //default:
                //    colorHeader = "#ff9494";
                //    break;
        }


    }
    private async Task GrabarEditar()
    {
        anuncio.FechaAnuncio = DateTime.Now;
        anuncio.UsuarioId = 4;//momentaneo hasta que pueda tomar el id de cada usuario

        var httpRespuesta = await http.Put<Anuncio>($"api/publicaciones/{anuncio.Id}", anuncio);
        if (httpRespuesta.Error)
        {
            var body = await httpRespuesta.GetBody();//Sitenemos un error, se va a mostrar
        }
        navigationManager.NavigateTo("/anuncios"); //Luego va a los anuncios

    }
    private void Cancelar()
    {
        navigationManager.NavigateTo("/anuncios");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
