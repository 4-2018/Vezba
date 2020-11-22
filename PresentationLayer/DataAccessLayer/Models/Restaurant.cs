using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer
{
    public class Restaurant
    {
    

        public int  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Restaurant(int id, string title, string description, decimal price)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Price = price;
        }
        public Restaurant()
        {

        }
       

        public override string ToString()
        {
            return "Id: " + this.Id + " " +
                "Naziv: " + this.Title + " " +
                "Opis: " + this.Description + " " +
                "Cena: " + this.Price;
                ;
        }

    }
}
