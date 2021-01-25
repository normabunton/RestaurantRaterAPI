using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRaterAPI.Models   //this class acts in a way to communicate with the store where we store the information in the database, so we query through the 
                                        //database in this class and make changes
{
    public class RestaurantDbContext : DbContext      //DBContext is our Base Class//this is a snapshot that looks at the databse as it is 
                                                        //when we first interacted with it
                                                        ////once we make chages and save it then they will be applied ot the database
    {
        public RestaurantDbContext() : base("DefaultConnection")
        {
            
        }

        //public DbSet<Restaurant> Restaurants { get; set; }
    }
}