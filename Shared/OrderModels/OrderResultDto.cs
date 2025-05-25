using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.OrderModels
{
    public class OrderResultDto
    {

        public Guid Id { get; set; }

        public string UserEmail { get; set; }

        public AddressDto ShippingAddress { get; set; }

        public ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();

        public string DeliveryMethod { get; set; }

        public int? DeliveryMethodId { get; set; }

        public string paymentStatus { get; set; }

        public decimal SubTotal { get; set; }

        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;

        public string PaymentIntentId { get; set; } = string.Empty;

        public decimal Total { get; set; }
    }
}
