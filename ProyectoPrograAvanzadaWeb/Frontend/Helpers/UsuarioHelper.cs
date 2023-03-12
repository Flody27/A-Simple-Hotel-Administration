using Frontend.Models;
using FrontEnd.Helpers;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class UsuarioHelper
    {
        private ServiceRepository serviceRepository;

        public UsuarioHelper()
        {
            serviceRepository = new ServiceRepository();
        }

        public List<UsuarioViewModel> GetAll()
        {
            List<UsuarioViewModel> lista;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Usuario/");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<UsuarioViewModel>>(content);

            return lista;
        }

        public UsuarioViewModel Get(int id)
        {

            UsuarioViewModel usuario;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Usuario/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            usuario = JsonConvert.DeserializeObject<UsuarioViewModel>(content);

            return usuario;
        }

        public UsuarioViewModel Create(UsuarioViewModel usuario)
        {
            UsuarioViewModel Usuario;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Usuario/", usuario);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Usuario = JsonConvert.DeserializeObject<UsuarioViewModel>(content);

            return Usuario;
        }

        public UsuarioViewModel Update(UsuarioViewModel usuario)
        {
            UsuarioViewModel Usuario;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Usuario/", usuario);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Usuario = JsonConvert.DeserializeObject<UsuarioViewModel>(content);

            return Usuario;
        }

        public UsuarioViewModel Delete(int id)
        {
            UsuarioViewModel Usuario;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Usuario/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Usuario = JsonConvert.DeserializeObject<UsuarioViewModel>(content);

            return Usuario;
        }
    }
}
