#pragma checksum "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd7e7507f6474d542029ec83a040793d69b2b138"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                 nuevo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                       onValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "center");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-sm-4");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card");
                __builder2.AddAttribute(11, "style", "width: 28rem; background-color: #FFEC84");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "card-header");
                __builder2.OpenElement(14, "h2");
                __builder2.AddAttribute(15, "class", "text-center");
                __builder2.AddContent(16, 
#nullable restore
#line 8 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                             tituloAnuncio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 11 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                 if (nuevo.Foto != null && ImageDateUrls.Count == 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(17, "img");
                __builder2.AddAttribute(18, "src", 
#nullable restore
#line 13 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                               nuevo.RutaFoto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(19, "class", "card-img-top");
                __builder2.AddAttribute(20, "alt", "anuncio1");
                __builder2.CloseElement();
#nullable restore
#line 14 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                     if (ImageDateUrls.Count > 0)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "card-body");
#nullable restore
#line 20 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                             foreach (var image in ImageDateUrls)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "img");
                __builder2.AddAttribute(24, "src", 
#nullable restore
#line 22 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                           image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(25, "class", "card-img-top");
                __builder2.AddAttribute(26, "alt", "anuncio1");
                __builder2.CloseElement();
#nullable restore
#line 23 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"

                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 27 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                    }
                    else

                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(27, "<img src=\"/image/mascota2.jpg\" class=\"card-img-top\" alt=\"anuncio1\">");
#nullable restore
#line 32 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "card-body");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "placeholder", "Foto");
                __builder2.AddAttribute(33, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 38 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                             OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-floating");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "id", "especie");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "placeholder", "Especie");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                                     nuevo.Especie

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevo.Especie = __value, nuevo.Especie))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevo.Especie));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.AddMarkupContent(45, "<label for=\"especie\">Especie</label>\r\n                    ");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateValidationMessage_0(__builder2, 46, 47, 
#nullable restore
#line 43 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                              () => nuevo.Especie

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "card-body");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-floating");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateInputSelect_1(__builder2, 53, 54, "tipo", 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 49 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                               (string value)=>TipoPublicacion(value)

#line default
#line hidden
#nullable disable
                ), 56, 
#nullable restore
#line 49 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                                                           ()=>tipo

#line default
#line hidden
#nullable disable
                , 57, 
#nullable restore
#line 49 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                                                                             tipo

#line default
#line hidden
#nullable disable
                , 58, "form-select form-select-sm", 59, ".form-select-sm example", 60, (__builder3) => {
                    __builder3.AddMarkupContent(61, "<option value=\"Perdido\">Perdido</option>\r\n                            ");
                    __builder3.AddMarkupContent(62, "<option value=\"En Adopción\">En adopción</option>\r\n                            ");
                    __builder3.AddMarkupContent(63, "<option value=\"Encontrado\">Encontrado</option>");
                }
                );
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.AddMarkupContent(65, "<label for=\"tipo\"> Estado del amiga/o:</label>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "card-body");
#nullable restore
#line 61 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                 if (nombre)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-floating");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "id", "nombre");
                __builder2.AddAttribute(74, "placeholder", "Nombre");
                __builder2.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                                       nuevo.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevo.Nombre = __value, nuevo.Nombre))));
                __builder2.AddAttribute(77, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevo.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.AddMarkupContent(79, "<label for=\"nombre\">Nombre</label>\r\n                        ");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateValidationMessage_2(__builder2, 80, 81, 
#nullable restore
#line 66 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                  () => nuevo.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(82, "\r\n                        <br>\r\n                        <br>");
                __builder2.CloseElement();
#nullable restore
#line 70 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"

                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-floating");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "id", "descripcion");
                __builder2.AddAttribute(88, "placeholder", "Descripcion");
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                                             nuevo.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevo.Descripcion = __value, nuevo.Descripcion))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevo.Descripcion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.AddMarkupContent(93, "<label for=\"descripcion\">Descripción</label>\r\n                    ");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateValidationMessage_3(__builder2, 94, 95, 
#nullable restore
#line 75 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                              () => nuevo.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.OpenElement(97, "ul");
                __builder2.AddAttribute(98, "class", "card-body");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-floating");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateInputSelect_4(__builder2, 101, 102, "tamano", 103, "form-select form-select-sm", 104, ".form-select-sm example", 105, 
#nullable restore
#line 82 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                  nuevo.Tamano

#line default
#line hidden
#nullable disable
                , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevo.Tamano = __value, nuevo.Tamano)), 107, () => nuevo.Tamano, 108, (__builder3) => {
                    __builder3.AddMarkupContent(109, "<option value=\"Pequeño\">Chico (1 a 5kg)</option>\r\n                            ");
                    __builder3.AddMarkupContent(110, "<option value=\"Mediano\">Mediano (6 a 10kg)</option>\r\n                            ");
                    __builder3.AddMarkupContent(111, "<option value=\"Grande\">Grande (11 a 15kg)</option>\r\n                            ");
                    __builder3.AddMarkupContent(112, "<option value=\"Enorme\">Enorme (16kg o +)</option>");
                }
                );
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.AddMarkupContent(114, "<label for=\"tamano\"> Tamaño</label>\r\n                        ");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateValidationMessage_5(__builder2, 115, 116, 
#nullable restore
#line 89 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                  () => nuevo.Tamano

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                    <br>\r\n                    ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "form-floating");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateInputDate_6(__builder2, 120, 121, "fecha", 122, "form-control", 123, "Fecha", 124, 
#nullable restore
#line 93 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                                     fecha

#line default
#line hidden
#nullable disable
                , 125, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fecha = __value, fecha)), 126, () => fecha);
                __builder2.AddMarkupContent(127, "\r\n                        ");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateValidationMessage_7(__builder2, 128, 129, 
#nullable restore
#line 94 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                  () => nuevo.FechaSuceso

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(130, "\r\n                        ");
                __builder2.AddMarkupContent(131, "<label for=\"fecha\"> Fecha</label>\r\n                        <br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                    ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "form-floating");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(135);
                __builder2.AddAttribute(136, "id", "color1");
                __builder2.AddAttribute(137, "class", "form-control");
                __builder2.AddAttribute(138, "placeholder", "Color Dominante");
                __builder2.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 99 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                                                nuevo.ColorRGB1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevo.ColorRGB1 = __value, nuevo.ColorRGB1))));
                __builder2.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevo.ColorRGB1));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, "\r\n                        ");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateValidationMessage_8(__builder2, 143, 144, 
#nullable restore
#line 100 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                  () => nuevo.ColorRGB1

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(145, "\r\n                        ");
                __builder2.AddMarkupContent(146, "<label for=\"color1\">Color Dominante</label>\r\n                        <br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                    ");
                __builder2.OpenElement(148, "div");
                __builder2.AddAttribute(149, "class", "form-floating");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(150);
                __builder2.AddAttribute(151, "id", "color2");
                __builder2.AddAttribute(152, "class", "form-control");
                __builder2.AddAttribute(153, "placeholder", "Color Secundario (No es obligatorio)");
                __builder2.AddAttribute(154, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 105 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                  nuevo.ColorRGB2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(155, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevo.ColorRGB2 = __value, nuevo.ColorRGB2))));
                __builder2.AddAttribute(156, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevo.ColorRGB2));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(157, "\r\n                        ");
                __Blazor.Helper.Client.Shared.FormAnuncio.TypeInference.CreateValidationMessage_9(__builder2, 158, 159, 
#nullable restore
#line 106 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                  () => nuevo.ColorRGB2

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(160, "\r\n                        ");
                __builder2.AddMarkupContent(161, "<label for=\"color2\">Color Secundario (No es obligatorio)</label>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n                ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "card-body");
                __builder2.OpenElement(165, "button");
                __builder2.AddAttribute(166, "class", "btn btn-primary btn-sm btn-block");
                __builder2.AddAttribute(167, "type", "submit");
                __builder2.AddContent(168, 
#nullable restore
#line 114 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                    textobtn1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\r\n                    ");
                __builder2.OpenElement(170, "button");
                __builder2.AddAttribute(171, "class", "btn btn-success btn-sm btn-block");
                __builder2.AddAttribute(172, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                               onCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(173, 
#nullable restore
#line 115 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                                                                                          textobtn2

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n                    ");
                __builder2.AddContent(175, 
#nullable restore
#line 116 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
                     ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n            <br>\r\n            <br>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "D:\Diego\Aplicaciones\BlazorWebAssembly\Helper\Helper\Client\Shared\FormAnuncio.razor"
       
    [Parameter] public Anuncio nuevo { get; set; }
    [Parameter] public EventCallback onValidSubmit { get; set; }
    [Parameter] public EventCallback onCancel { get; set; }
    [Parameter] public EventCallback onChange { get; set; }
    [Parameter] public string textobtn1 { get; set; }
    [Parameter] public string textobtn2 { get; set; }
    [Parameter] public string tituloAnuncio { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public DateTime fecha { get; set; }
    public bool nombre = true;
    public string tipo;
    byte[] image;
    
    string texto;
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
    private void TipoPublicacion(string n)
    {
        switch (n)
        {
            case "Perdido":

                nuevo.Estado = n;
                nuevo.Tipo = 1;
                nombre = true;
                break;
            case "En Adopción":
                nuevo.Estado = n;
                nuevo.Tipo = 2;
                nombre = true;
                break;

            case "Encontrado":
                nuevo.Estado = n;
                nuevo.Tipo = 3;
                nombre = false;
                break;
                //default:
                //    colorHeader = "#ff9494";
                //    break;
        }
        tipo = nuevo.Estado;


    }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Helper.Client.Shared.FormAnuncio
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, TValue __arg3, int __seq4, System.Object __arg4, int __seq5, System.Object __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "class", __arg4);
        __builder.AddAttribute(__seq5, "aria-label", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "aria-label", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
