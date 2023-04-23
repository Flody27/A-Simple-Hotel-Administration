using FrontEnd.Helpers;
using Frontend.Models;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;

namespace Frontend.Helpers
{
    public class ReservacionHelper
    {

        private ServiceRepository serviceRepository;

/*        public ReservacionHelper()
        {
            serviceRepository = new ServiceRepository();
        }*/

        public ReservacionHelper(string token)
        {
            serviceRepository = new ServiceRepository(token);
        }

        public List<ReservacionViewModel> GetAll()
        {
            List<ReservacionViewModel> lista;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Reservaciones");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<ReservacionViewModel>>(content);

            return lista;
        }

        public ReservacionViewModel Get(int id)
        {

            ReservacionViewModel Reservacion;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Reservaciones/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Reservacion = JsonConvert.DeserializeObject<ReservacionViewModel>(content);

            return Reservacion;
        }

        public ReservacionViewModel Create(ReservacionViewModel payload)
        {
            ReservacionViewModel Reservacion;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Reservaciones", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Reservacion = JsonConvert.DeserializeObject<ReservacionViewModel>(content);

            return Reservacion;
        }

        public ReservacionViewModel Update(ReservacionViewModel payload)
        {
            ReservacionViewModel Reservacion;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Reservaciones", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Reservacion = JsonConvert.DeserializeObject<ReservacionViewModel>(content);

            return Reservacion;
        }

        public ReservacionViewModel Delete(int id)
        {
            ReservacionViewModel Reservacion;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Reservaciones/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Reservacion = JsonConvert.DeserializeObject<ReservacionViewModel>(content);

            return Reservacion;
        }

    }
}
