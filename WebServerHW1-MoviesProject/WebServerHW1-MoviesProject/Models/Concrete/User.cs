namespace WebServerHW1_MoviesProject.Models.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Cart Cart { get; set; }
    }
}
