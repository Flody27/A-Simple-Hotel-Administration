using Frontend.Models;
using FrontEnd.Helpers;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class ConsultaHabitacionHelper
    {
        private ServiceRepository serviceRepository;

        public ConsultaHabitacionHelper()
        {
            serviceRepository = new ServiceRepository();
        }

        public HabitacionViewModel consultar(BuscarHabitaconViewModel model) {
            HabitacionViewModel consulta;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/ConsultaHabitacion/", model);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            consulta = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return consulta;
        }
    }
}
