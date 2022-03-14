using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Helper.Client.Servicios
{
    public class HttpRespuesta<T>
    {
        #region Cramos propiedades de la Clase
        public T Respuesta { get; }
        public bool Error { get; }
        
        public HttpResponseMessage httpResponseMessage { get; }
        #endregion

        //Mi respuesta va a tener si es succes o true la respuesta, si la respuesta es falsa, voy a usar el mensaje que viene en ResponseMessage
        #region Constructor
        public HttpRespuesta(T respuesta,
            bool error,
            HttpResponseMessage httpResponseMessage)
        {
            Respuesta = respuesta;
            Error = error;
            this.httpResponseMessage = httpResponseMessage;
        }
        #endregion

        //Metodo para trar el cuerpo del mensaje
        public async Task <string> GetBody()
        {
            var resp = await httpResponseMessage.Content.ReadAsStringAsync();//Al contenido lo convierto en strin para pode enterarme lo que trar
            return resp;
        }




    }
}
