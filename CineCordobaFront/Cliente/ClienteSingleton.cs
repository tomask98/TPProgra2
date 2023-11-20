using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaFront.Cliente
{
    public class ClienteSingleton
    {
        private static ClienteSingleton instancia;

        private HttpClient httpCliente;
        private ClienteSingleton()
        {
            httpCliente= new HttpClient();
            
        }
        public static ClienteSingleton ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia= new ClienteSingleton();  
            }
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await httpCliente.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await httpCliente.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }
            return response;
        }

    }
}
