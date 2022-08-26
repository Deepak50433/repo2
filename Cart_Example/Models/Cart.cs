using System.ComponentModel.DataAnnotations.Schema;

namespace Cart_Example.Models
{
    public class Cart
    {
        public int id { get; set; }

        public string user { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("categ")]
        public int categid { get; set; }
        public Catogery? categ { get; set; }

        [ForeignKey("prod")]

        public int prodid { get; set; }
        public Product? prod { get; set; }
    }
}
