using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace DefinexAPI.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
}
