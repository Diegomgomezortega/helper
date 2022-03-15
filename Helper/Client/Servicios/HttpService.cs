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

        //Por cada metodo, tengo que extrar una interfaz, esto para que podamos tener acceso
        //desde la vista del componente
        //Por ejemplo, "Extraer X(metodo) hasta IHttpService

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

        //Realizamos un metodo que va a subir la peticion en forma de object
        public async Task<HttpRespuesta<object>> Post<T>(string url,T enviar) //el argumento T puede ser cualquier modelo/entidad/elemento llamado enviar, en este caso
        {
            try
            {
                // var enviarJson guardada como JSON, que se consigue con el JsonSerializer.Serialize poniendo como agumento el objeto a enviar
                var enviarJson = JsonSerializer.Serialize(enviar);
                //var enviarContent es el enviarJson empaquetado y codificado, diciendo como va a estar codificado (Encoding.UTF8), y agragar el mediatipe ""application/json""
                var enviarContent = new StringContent(enviarJson, Encoding.UTF8, "application/json");
                //var respuestaHttp guarda lo que devuelve el Post que hicimos, con argumento la URL y el contenido que esta dentro del enviarContent
                var respuestaHttp = await http.PostAsync(url, enviarContent);
                //new HttpRespuesta de tipo Object pide 3 argumentos
                //el primer argumento es null, ya que no necesito que lo traiga
                //el segundo, es un argumento de la respuesta que va a traer, si es error, guardo el erro para mostrar
                //el tercer, si es succesfull,completa
                return new HttpRespuesta<object>(null, !respuestaHttp.IsSuccessStatusCode, respuestaHttp);

            }
            catch (System.Exception e)
            {
                throw;
            }
            

        }

        public async Task<HttpRespuesta<object>> Put<T>(string url, T enviar)
        {
            try
            {
                // var enviarJson guardada como JSON, que se consigue con el JsonSerializer.Serialize poniendo como agumento el objeto a enviar
                var enviarJson = JsonSerializer.Serialize(enviar);
                //var enviarContent es el enviarJson empaquetado y codificado, diciendo como va a estar codificado (Encoding.UTF8), y agragar el mediatipe ""application/json""
                var enviarContent = new StringContent(enviarJson, Encoding.UTF8, "application/json");
                //var respuestaHttp guarda lo que devuelve el Put que hicimos, con argumento la URL y el contenido que esta dentro del enviarContent
                var respuestaHttp = await http.PutAsync(url, enviarContent);
                //new HttpRespuesta de tipo Object pide 3 argumentos
                //el primer argumento es null, ya que no necesito que lo traiga
                //el segundo, es un argumento de la respuesta que va a traer, si es error, guardo el erro para mostrar
                //el tercer, si es succesfull,completa
                return new HttpRespuesta<object>(null, !respuestaHttp.IsSuccessStatusCode, respuestaHttp);

            }
            catch (System.Exception e)
            {
                throw;
            }

        }

        //Metodo para deserializar la respuesta traida, y poder manejar los datos
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpRespuesta)
        {
            var RespuestaString = await httpRespuesta.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(RespuestaString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

    }
}
