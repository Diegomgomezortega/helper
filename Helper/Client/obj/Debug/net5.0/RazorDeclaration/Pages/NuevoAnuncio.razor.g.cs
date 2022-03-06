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
    [Microsoft.AspNetCore.Components.RouteAttribute("/anuncios/nuevo")]
    public partial class NuevoAnuncio : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Pages\NuevoAnuncio.razor"
       
    //public string txtbtn1 = "Guardar Anuncio";
    //public string txtbtn2 = "Cancelar";
    public string Tamano;


    private Anuncio anuncio = new Anuncio();


    private async Task GrabarNuevo()
    {
        anuncio.FechaAnuncio = DateTime.Now;
        anuncio.UsuarioId = 4;//momentaneo hasta que pueda tomar el id de cada usuario

        var httpRespuesta = await http.Post<Helper.Shared.Data.Entidades.Anuncio>("api/publicaciones", anuncio);
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
    private void CargarFecha()
    {
        //hoy = DateTime.Now.ToShortDateString();

    }
    private void SelectTamano()
    {


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
    }
}
#pragma warning restore 1591
