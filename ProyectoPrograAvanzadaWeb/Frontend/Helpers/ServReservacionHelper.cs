using FrontEnd.Helpers;
using Frontend.Models;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class ServReservacionHelper
    {
        private ServiceRepository serviceRepository;

        public ServReservacionHelper()
        {
            serviceRepository = new ServiceRepository();
        }

        public List<ServReservacionViewModel> GetAll()
        {
            List<ServReservacionViewModel> lista;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/ServicioReservacion");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<ServReservacionViewModel>>(content);

            return lista;
        }

        public ServReservacionViewModel Get(int id)
        {

            ServReservacionViewModel servReserv;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/ServicioReservacion/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servReserv = JsonConvert.DeserializeObject<ServReservacionViewModel>(content);

            return servReserv;
        }

        public ServReservacionViewModel Create(ServReservacionViewModel payload)
        {
            ServReservacionViewModel servReserv;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/ServicioReservacion", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servReserv = JsonConvert.DeserializeObject<ServReservacionViewModel>(content);

            return servReserv;
        }

        public ServReservacionViewModel Update(ServReservacionViewModel payload)
        {
            ServReservacionViewModel servReserv;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/ServicioReservacion", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servReserv = JsonConvert.DeserializeObject<ServReservacionViewModel>(content);

            return servReserv;
        }

        public ServReservacionViewModel Delete(int id)
        {
            ServReservacionViewModel servReserv;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/ServicioReservacion/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            servReserv = JsonConvert.DeserializeObject<ServReservacionViewModel>(content);

            return servReserv;
        }

    }
}
