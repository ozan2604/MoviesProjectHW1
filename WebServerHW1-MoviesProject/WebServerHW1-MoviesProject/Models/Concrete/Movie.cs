namespace WebServerHW1_MoviesProject.Models.Concrete
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string[] Stars { get; set; }
        public int  ReleaseYear { get; set; }   
        public string ImageUrl { get; set; }    
    }
}
