using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRaterAPI.Models
{
    public class Restaurant
    {
        //this is  where we define what the table looks like
        //key attributes
        [Key]
        /// this is the primary key
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Rating { get; set; }
    }
}