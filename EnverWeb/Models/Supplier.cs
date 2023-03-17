using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnverWeb.Models
{
    public class Supplier
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }
        public string Name { get; set; }
        public string TelelphoneNo { get; set; }
    }
}
