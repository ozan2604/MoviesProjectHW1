using Microsoft.AspNetCore.Http.HttpResults;

namespace WebServerHW1_MoviesProject.Models.Concrete
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedTime  { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
