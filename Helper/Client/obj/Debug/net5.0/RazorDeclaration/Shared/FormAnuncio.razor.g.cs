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
    public partial class FormAnuncio : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
       
    [Parameter] public Anuncio nuevo { get; set; }
    [Parameter] public EventCallback onValidSubmit { get; set; }
    [Parameter] public EventCallback onCancel { get; set; }
    [Parameter] public EventCallback onChange { get; set; }
    [Parameter] public string textobtn1 { get; set; }
    [Parameter] public string textobtn2 { get; set; }
    [Parameter] public string tituloAnuncio { get; set; }
    byte[] image;

    private string Estado;
    private IList<string> ImageDateUrls = new List<string>();
    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        ImageDateUrls.Clear();
        nuevo.Foto = null;
        var maxAllowedFile = 1;
        var format = "image/jpg";
        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFile))
        {

            var resizedFile = await imageFile.RequestImageFileAsync(format, 200, 200);

            var buffer = new byte[resizedFile.Size];
            await resizedFile.OpenReadStream().ReadAsync(buffer);
            nuevo.Foto = buffer;
            var imageDataUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            ImageDateUrls.Add(imageDataUrl);


        }

    }

    private void TipoPublicacion(int tipo)
    {
        switch (tipo)
        {
            case 1:
                nuevo.Estado = "Perdido";
                break;
            case 2:
                nuevo.Estado = "En Adopción";
                break;
            case 3:
                nuevo.Estado = "Encontrado";
                break;
                //default:
                //    colorHeader = "#ff9494";
                //    break;
        }


    }









#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
