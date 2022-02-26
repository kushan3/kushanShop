using System;
using System.ComponentModel.DataAnnotations;

namespace KushanShop.Models
{
    public class KushanShop
    {
        public int Id { get; set; }
        public string Type { get; set; }

        
        public String Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}