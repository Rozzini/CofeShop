using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CarsData.Models
{
    public class Category
    {
        [HiddenInput(DisplayValue = false)]
        public int CategoryId { get; set; }

        [DataMember]
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Input please")]
        public string CategoryName { get; set; }

        [DataMember]
        [Display(Name = "Category Description")]
        [Required(ErrorMessage = "Input please")]
        public string Description { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
