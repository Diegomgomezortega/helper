using System.Threading.Tasks;

namespace Helper.Client.Servicios
{
    public interface IHttpService
    {
        Task<HttpRespuesta<T>> Get<T>(string url);
    }
}