


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodProjekt.api.Data.Entities
{
    [Table(nameof(Offer))]
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        [Required, StringLength(25, MinimumLength = 3)]
        public string Image { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        [Required, StringLength(10, MinimumLength = 3)]
        public string Code { get; set; }

        public OfferType Type { get; set; }
        public decimal OfferedValue { get; set; }

        public decimal? MinAmount { get; set; }

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
        



    }
}
