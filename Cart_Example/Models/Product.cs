using System.ComponentModel.DataAnnotations.Schema;

namespace Cart_Example.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        [ForeignKey("categ")]
        public int categid { get; set; }

        public Catogery? categ { get; set; }

        public bool check { get; set; } = false;
    }
}
