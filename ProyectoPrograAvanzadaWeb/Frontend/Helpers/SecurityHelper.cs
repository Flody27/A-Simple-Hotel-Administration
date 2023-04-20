using Frontend.Models;
using FrontEnd.Helpers;
using Newtonsoft.Json;

namespace Frontend.Helpers
{
    public class SecurityHelper
    {
        private ServiceRepository ServiceRepository;

        public SecurityHelper()
        {
            ServiceRepository = new ServiceRepository();
        }

        public TokenModel Login(UsuarioViewModel usuario)
        {
            try
            {
                TokenModel TokenModel;

                HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/Authenticate/login", usuario);
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                TokenModel = JsonConvert.DeserializeObject<TokenModel>(content);

                return TokenModel;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
