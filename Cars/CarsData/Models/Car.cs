using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CarsData.Models
{
    public class Car
    {
        [HiddenInput(DisplayValue = true)] 
        public int CarId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Input retard")]
        public string Name { get; set; }

        [Display(Name = "Short deeeeeescription")]
        [Required(ErrorMessage = "Input retard")]
        public string ShortDescription { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Long description")]
        [Required(ErrorMessage = "Input retard")]
        public string LongDescription { get; set; }

        [Display(Name = "Image url")]
        [Required(ErrorMessage = "Input retard")]
        public string Image { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Input retard")]
        public decimal Price { get; set; }

        [Display(Name = "Favorite")]
        [Required(ErrorMessage = "Input retard")]
        public bool IsFavorite { get; set; }

        [Display(Name = "Availability")]
        public bool Available { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public virtual Category Categories { get; set; }
        
    }
}
