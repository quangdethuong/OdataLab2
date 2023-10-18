using System.ComponentModel.DataAnnotations;

namespace ODataBookStore.Models
{
    public class Press
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
    }
}
