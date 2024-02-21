using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjekt.Models
{
    
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public string Code { get; set; }

        public OfferType Type { get; set;}
        public decimal OfferedValue { get; set; } 
         
        public decimal ? MinAmount { get; set; }

        public DateTime? ValidTill { get; set; }

        public bool IsActive { get; set; }

        public Offer(int id, string name, string image, string description, string code, OfferType type, decimal offeredValue, decimal? minAmount, DateTime? validTill)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Code = code;
            Type = type;
            OfferedValue = offeredValue;
            MinAmount = minAmount;
            ValidTill = validTill;
            IsActive = true;
        }

        public Offer()
        {
            
        }
        public override string ToString() => $" id: {Id}, Name: {Name}]";
        
           
        
    }
}
