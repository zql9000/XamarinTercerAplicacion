using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TercerAplicacion.Models;

namespace TercerAplicacion.Services
{
    public class UsuarioService
    {
        HttpClient client;
        private const string url = "https://jsonplaceholder.typicode.com/users";

        public UsuarioService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            List<Usuario> usuarios = null;

            var uri = new Uri(url);

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(content);
            }

            return usuarios;
        }
    }
}
