using IntroduccionMaui.Maodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IntroduccionMaui.ConexionDatos
{
    public class RestConexionDatos : IRestConexionDatos
    {
        public  readonly HttpClient HttpClient;
        private readonly string dominio;
        private readonly string url;
        private readonly JsonSerializerOptions opcionesJson;
        public RestConexionDatos()
        {
            HttpClient = new HttpClient();
            dominio = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5089" : "http://localhost:5089";
            url = $"{dominio}/api";
            opcionesJson = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }
        public Task AddPlatoAsync(Plato plato)
        {
            throw new NotImplementedException();
        }

        public Task DeletePlato(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Plato>> GetPlatosAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdatePlatoAsync(Plato plato)
        {
            throw new NotImplementedException();
        }
    }
}
