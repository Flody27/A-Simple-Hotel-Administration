using FrontEnd.Helpers;
using Frontend.Models;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class MembresiaHelper
    {

        private ServiceRepository serviceRepository;

        public MembresiaHelper()
        {
            serviceRepository = new ServiceRepository();
        }

        public List<MembresiaViewModel> GetAll()
        {
            List<MembresiaViewModel> lista;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Membresia");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista = JsonConvert.DeserializeObject<List<MembresiaViewModel>>(content);

            return lista;
        }

        public MembresiaViewModel Get(int id)
        {

            MembresiaViewModel Membresia;

            HttpResponseMessage responseMessage = serviceRepository.GetResponse("/api/Membresia/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Membresia = JsonConvert.DeserializeObject<MembresiaViewModel>(content);

            return Membresia;
        }

        public MembresiaViewModel Create(MembresiaViewModel payload)
        {
            MembresiaViewModel Membresia;

            HttpResponseMessage responseMessage = serviceRepository.PostResponse("/api/Membresia", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Membresia = JsonConvert.DeserializeObject<MembresiaViewModel>(content);

            return Membresia;
        }

        public MembresiaViewModel Update(MembresiaViewModel payload)
        {
            MembresiaViewModel Membresia;

            HttpResponseMessage responseMessage = serviceRepository.PutResponse("/api/Membresia", payload);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Membresia = JsonConvert.DeserializeObject<MembresiaViewModel>(content);

            return Membresia;
        }

        public MembresiaViewModel Delete(int id)
        {
            MembresiaViewModel Membresia;

            HttpResponseMessage responseMessage = serviceRepository.DeleteResponse("/api/Membresia/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Membresia = JsonConvert.DeserializeObject<MembresiaViewModel>(content);

            return Membresia;
        }

    }
}
