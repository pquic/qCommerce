namespace Nop.Core.Domain.Shipping
{
    /// <summary>
    /// Represents the shipping status enumeration
    /// </summary>
    public enum ShippingStatus : int
    {
        /// <summary>
        /// Shipping not required
        /// </summary>
        ShippingNotRequired = 10,
        /// <summary>
        /// Not yet shipped
        /// </summary>
        NotYetShipped = 20,
        /// <summary>
        /// Shipped
        /// </summary>
        Shipped = 30,
        /// <summary>
        /// Delivered
        /// </summary>
        Delivered = 40,
    }
}
