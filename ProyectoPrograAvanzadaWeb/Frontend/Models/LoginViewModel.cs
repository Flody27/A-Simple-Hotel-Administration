using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class LoginViewModel
    {

        public string UserName { get; set; } 
        public string Email { get; set; }

		[DataType(DataType.Password)]
		public string Password { get; set; } 

    }
}
