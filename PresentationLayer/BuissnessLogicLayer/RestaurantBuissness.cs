using DataAccessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnessLogicLayer
{
    public class RestaurantBuissness
    {
        public readonly ResaurantRepository repository;

        

        public RestaurantBuissness()
        {
            this.repository = new ResaurantRepository();
        }

        public List<Restaurant> GetAllMenuItems()
        {
            return this.repository.GetAllMenuItems();
        }

        public bool InsertMenuItems(Restaurant r)
        {
            
            if(this.repository.InsertMenuItems(r) > 0 )
            {
                return true;
            }else
            {
                return false;
            }
        }

        public List<Restaurant> Between( decimal min, decimal max)
        {
            return this.repository.GetAllMenuItems().Where(r => r.Price > min && r.Price < max).ToList();
        }
    } 
}
