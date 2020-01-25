using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Model
{
    public class Car
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Image { get; set; }

        public ushort Price { get; set; }

        public bool IsFavorite { get; set; }

        public bool Available { get; set; }


        [ForeignKey("Category")]
        public int CategotyId { get; set; }

        public virtual Category Category { get; set; }
        
    }
}
