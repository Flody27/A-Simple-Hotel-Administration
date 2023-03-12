using FrontEnd.Helpers;
using Frontend.Models;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class RolHelper
    {

        private ServiceRepository serviceRepository;

        public RolHelper()
        {
            serviceRepository = new ServiceRepository();
        }

        public List<RolViewModel> GetAll()
        {
            List<RolViewModel> lista;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Roles");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<RolViewModel>>(content);

            return lista;
        }

        public RolViewModel Get(int id)
        {

            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Roles/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

        public RolViewModel Create(RolViewModel payload)
        {
            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Roles", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

        public RolViewModel Update(RolViewModel payload)
        {
            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Roles", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

        public RolViewModel Delete(int id)
        {
            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Roles/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

    }
}
