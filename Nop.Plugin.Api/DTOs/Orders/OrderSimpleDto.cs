using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Nop.Plugin.Api.DTO.Base;
using Nop.Plugin.Api.DTO.Customers;
using Nop.Plugin.Api.DTO.OrderItems;
using Nop.Plugin.Api.DTOs.Orders;

namespace Nop.Plugin.Api.DTO.Orders
{
    [JsonObject(Title = "order")]
    //[Validator(typeof(OrderDtoValidator))]
    public class OrderSimpleDto : BaseDto
    {
        private ICollection<OrderItemDto> _orderItems;

        [JsonProperty("store_id")]
        public int? StoreId { get; set; }


        /// <summary>
        ///     Gets or sets a value indicating whether a customer chose "pick up in store" shipping option
        /// </summary>
        [JsonProperty("pick_up_in_store")]
        public bool? PickUpInStore { get; set; }

        /// <summary>
        ///     Gets or sets the payment method system name
        /// </summary>
        [JsonProperty("payment_method_system_name")]
        public string PaymentMethodSystemName { get; set; }


        /// <summary>
        ///     Gets or sets the order discount (applied to order total)
        /// </summary>
        [JsonProperty("order_discount")]
        public decimal? OrderDiscount { get; set; }

        /// <summary>
        ///     Gets or sets the order total
        /// </summary>
        [JsonProperty("order_total")]
        public decimal? OrderTotal { get; set; }

        /// <summary>
        ///     Gets or sets the refunded amount
        /// </summary>
        [JsonProperty("refunded_amount")]
        public decimal? RefundedAmount { get; set; }

        /// <summary>
        ///     Gets or sets the customer IP address
        /// </summary>
        [JsonProperty("customer_ip")]
        public string CustomerIp { get; set; }

        /// <summary>
        ///     Gets or sets the paid date and time
        /// </summary>
        [JsonProperty("paid_date_utc")]
        public DateTime? PaidDateUtc { get; set; }

        /// <summary>
        ///     Gets or sets the shipping method
        /// </summary>
        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        ///     Gets or sets the date and time of order creation
        /// </summary>
        [JsonProperty("created_on_utc")]
        public DateTime? CreatedOnUtc { get; set; }

        [JsonProperty("customer_id")]
        public int? CustomerId { get; set; }

        /// <summary>
        ///     Gets or sets the shipping address
        /// </summary>
        [JsonProperty("shipping_address")]
        public AddressDto ShippingAddress { get; set; }

        /// <summary>
        ///     Gets or sets order items
        /// </summary>
        [JsonProperty("order_items")]
        public ICollection<OrderItemDto> OrderItems
        {
            get
            {
                if (_orderItems == null)
                {
                    _orderItems = new List<OrderItemDto>();
                }

                return _orderItems;
            }
            set => _orderItems = value;
        }

        /// <summary>
        ///     Gets or sets the order status
        /// </summary>
        [JsonProperty("order_status")]
        public OrderStatus? OrderStatus { get; set; }

        /// <summary>
        ///     Gets or sets the payment status
        /// </summary>
        [JsonProperty("payment_status")]
        public PaymentStatus? PaymentStatus { get; set; }

        /// <summary>
        ///     Gets or sets the shipping status
        /// </summary>
        [JsonProperty("shipping_status")]
        public ShippingStatus? ShippingStatus { get; set; }
    }
}
