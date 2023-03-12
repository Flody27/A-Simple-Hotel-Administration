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

            HabitacionViewModel Habitacion;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Habitacione" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return Habitacion;
        }

        public HabitacionViewModel Create(HabitacionViewModel habitacion)
        {
            HabitacionViewModel Habitacion;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Habitacione", habitacion);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return Habitacion;
        }

        public HabitacionViewModel Update(HabitacionViewModel habitacion)
        {
            HabitacionViewModel Habitacion;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Habitacione", habitacion);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return Habitacion;
        }

        public HabitacionViewModel Delete(int id)
        {
            HabitacionViewModel Habitacion;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Habitacione" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Habitacion = JsonConvert.DeserializeObject<HabitacionViewModel>(content);

            return Habitacion;
        }

    }
}
