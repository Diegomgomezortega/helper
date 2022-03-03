using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Helper.Client.Servicios
{
    public class HttpService : IHttpService
    //es lo que nos permite recibir lo que viene de la wepApi serializado, pero tengo que deserializarlo para que el Client pueda leerlo correctamente
    {
        private readonly HttpClient http;

        public HttpService(HttpClient http)
        {
            this.http = http;
        }

        //Realizamos un metodo que va a traer la respuesta en forma de T
        public async Task<HttpRespuesta<T>> Get<T>(string url)
        {
            var respuestaHttp = await http.GetAsync(url);
            if (respuestaHttp.IsSuccessStatusCode)//Si funciona, necesito deserializar la respuesta
            {
                var respuesta = await DeserializarRespuesta<T>(respuestaHttp);
                return new HttpRespuesta<T>(respuesta, false, respuestaHttp);


            }
            else
            {
                return new HttpRespuesta<T>(default, true, respuestaHttp);
            }

        }

        public async Task<HttpRespuesta<object>> Post<T>(string url,T enviar)
        {
            try
            {
                var enviarJson = JsonSerializer.Serialize(enviar);
                var enviarContent = new StringContent(enviarJson, Encoding.UTF8, "application/json");
                var respuestaHttp = await http.PostAsync(url, enviarContent);
                return new HttpRespuesta<object>(null, !respuestaHttp.IsSuccessStatusCode, respuestaHttp);

            }
            catch (System.Exception e)
            {
                throw;
            }
            

        }
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpRespuesta)
        {
            var RespuestaString = await httpRespuesta.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(RespuestaString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

    }
}
