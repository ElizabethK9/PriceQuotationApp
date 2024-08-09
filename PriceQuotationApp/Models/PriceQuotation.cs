using System;
using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class PriceQuotation
    {
        [Required(ErrorMessage = "Sales price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Sales price must be greater than 0.")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Discount percent is required.")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100.")]
        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount
        {
            get
            {
                return Subtotal * (DiscountPercent / 100);
            }
        }

        public decimal Total
        {
            get
            {
                return Subtotal - DiscountAmount;
            }
        }
    }
}
