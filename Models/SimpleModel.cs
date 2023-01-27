using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Simple
    {
        public Int64 Id { get; set; }
        
        public string Name { get; set; }
        
        public string Age { get; set; }
        public string Gender { get; set; }
    }
}