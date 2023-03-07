namespace BackEnd.Models
{
    public class UsuarioModel
    {
        public int UsrId { get; set; }
        public string? UsrNombre { get; set; }
        public string? UsrApellido { get; set; }
        public string? UsrEmail { get; set; }
        public string? UsrPassword { get; set; }
        public int? UsrRolId { get; set; }
        public int? UsrMbrId { get; set; }
    }
}
