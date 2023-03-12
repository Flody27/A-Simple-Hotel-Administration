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

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Role");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<RolViewModel>>(content);

            return lista;
        }

        public RolViewModel Get(int id)
        {

            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Role/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

        public RolViewModel Create(RolViewModel payload)
        {
            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Role", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

        public RolViewModel Update(RolViewModel payload)
        {
            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Role", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

        public RolViewModel Delete(int id)
        {
            RolViewModel Rol;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Role/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Rol = JsonConvert.DeserializeObject<RolViewModel>(content);

            return Rol;
        }

    }
}
