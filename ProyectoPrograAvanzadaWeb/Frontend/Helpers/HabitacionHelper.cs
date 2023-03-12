using FrontEnd.Helpers;
using Frontend.Models;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class HabitacionHelper
    {
        private ServiceRepository serviceRepository;

        public HabitacionHelper()
        {
            serviceRepository = new ServiceRepository();
        }

        public List<HabitacionViewModel> GetAll()
        {
            List<HabitacionViewModel> lista;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Habitacione");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<HabitacionViewModel>>(content);

            return lista;
        }

        public HabitacionViewModel Get(int id)
        {
            HabitacionViewModel habitacion;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Habitacione/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return habitacion;
        }

        public HabitacionViewModel Create(HabitacionViewModel payload)
        {
            HabitacionViewModel habitacion;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Habitacione", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return habitacion;
        }

        public HabitacionViewModel Update(HabitacionViewModel payload)
        {
            HabitacionViewModel habitacion;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Habitacione", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return habitacion;
        }

        public HabitacionViewModel Delete(int id)
        {
            HabitacionViewModel habitacion;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Habitacione/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return habitacion;
        }

    }
}
