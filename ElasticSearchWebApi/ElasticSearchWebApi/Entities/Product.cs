using Nest;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ElasticSearchWebApi.Entities
{
    public class Product
    {   
        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
