using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CarsData.Models
{

    [DataContract]
    public class Car
    {
       
        [HiddenInput(DisplayValue = false)] 
        public int CarId { get; set; }

        [DataMember]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Input please")]
        public string Name { get; set; }

        [DataMember]
        [Display(Name = "Short deeeeeescription")]
        [Required(ErrorMessage = "Input please")]
        public string ShortDescription { get; set; }

        [DataMember]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Long description")]
        [Required(ErrorMessage = "Input please")]
        public string LongDescription { get; set; }

        [DataMember]
        [Display(Name = "Image url")]
        [Required(ErrorMessage = "Input please")]
        public string Image { get; set; }

        [DataMember]
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Input please")]
        public decimal Price { get; set; }

        [DataMember]
        [Display(Name = "Favorite")]
        [Required(ErrorMessage = "Input please")]
        public bool IsFavorite { get; set; }

        [DataMember]
        [Display(Name = "Availability")]
        public bool Available { get; set; }

        [DataMember]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category Categories { get; set; }
        
    }
}
