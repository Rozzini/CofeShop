using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Model
{
    public class Car
    {
        public int CarId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public bool IsFavorite { get; set; }

        public bool Available { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public virtual Category Categories { get; set; }
        
    }
}
