using FrontEnd.Helpers;
using Frontend.Models;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class ServicioHelper
    {
        private ServiceRepository serviceRepository;

        public ServicioHelper()
        {
            serviceRepository = new ServiceRepository();
        }

        public List<ServicioViewModel> GetAll()
        {
            List<ServicioViewModel> lista;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Servicios");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<ServicioViewModel>>(content);

            return lista;
        }

        public ServicioViewModel Get(int id)
        {
            ServicioViewModel servicio;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Servicios/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servicio = JsonConvert.DeserializeObject<ServicioViewModel>(content);

            return servicio;
        }

        public ServicioViewModel Create(ServicioViewModel payload)
        {
            ServicioViewModel servicio;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Servicios", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servicio = JsonConvert.DeserializeObject<ServicioViewModel>(content);

            return servicio;
        }

        public ServicioViewModel Update(ServicioViewModel payload)
        {
            ServicioViewModel servicio;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Servicios", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servicio = JsonConvert.DeserializeObject<ServicioViewModel>(content);

            return servicio;
        }

        public ServicioViewModel Delete(int id)
        {
            ServicioViewModel servicio;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Servicios/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servicio = JsonConvert.DeserializeObject<ServicioViewModel>(content);

            return servicio;
        }
    }
}
