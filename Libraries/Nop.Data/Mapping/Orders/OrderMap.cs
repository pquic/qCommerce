using System.Data.Entity.ModelConfiguration;
using Nop.Core.Domain.Orders;

namespace Nop.Data.Mapping.Orders
{
    public partial class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.ToTable("Order");
            this.HasKey(o => o.Id);
            this.Property(o => o.CurrencyRate).HasPrecision(18, 4);
            this.Property(o => o.OrderSubtotalInclTax).HasPrecision(18, 4);
            this.Property(o => o.OrderSubtotalExclTax).HasPrecision(18, 4);
            this.Property(o => o.OrderSubTotalDiscountInclTax).HasPrecision(18, 4);
            this.Property(o => o.OrderSubTotalDiscountExclTax).HasPrecision(18, 4);
            this.Property(o => o.OrderShippingInclTax).HasPrecision(18, 4);
            this.Property(o => o.OrderShippingExclTax).HasPrecision(18, 4);
            this.Property(o => o.PaymentMethodAdditionalFeeInclTax).HasPrecision(18, 4);
            this.Property(o => o.PaymentMethodAdditionalFeeExclTax).HasPrecision(18, 4);
            this.Property(o => o.OrderTax).HasPrecision(18, 4);
            this.Property(o => o.OrderDiscount).HasPrecision(18, 4);
            this.Property(o => o.OrderTotal).HasPrecision(18, 4);
            this.Property(o => o.RefundedAmount).HasPrecision(18, 4);
            this.Property(o => o.OrderWeight).HasPrecision(18, 4);

            this.Property(o => o.TaxRates).IsMaxLength();
            this.Property(o => o.AuthorizationTransactionId).IsMaxLength();
            this.Property(o => o.AuthorizationTransactionCode).IsMaxLength();
            this.Property(o => o.AuthorizationTransactionResult).IsMaxLength();
            this.Property(o => o.CaptureTransactionId).IsMaxLength();
            this.Property(o => o.CaptureTransactionResult).IsMaxLength();
            this.Property(o => o.SubscriptionTransactionId).IsMaxLength();
            this.Property(o => o.PurchaseOrderNumber).IsMaxLength();
            this.Property(o => o.TrackingNumber).IsMaxLength();

            this.Ignore(o => o.OrderStatus);
            this.Ignore(o => o.PaymentStatus);
            this.Ignore(o => o.ShippingStatus);
            this.Ignore(o => o.CustomerTaxDisplayType);
            this.Ignore(o => o.TaxRatesDictionary);
            
            this.HasRequired(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);





            //code below is commented because it causes some issues on big databases - http://www.nopcommerce.com/boards/t/11126/bug-version-20-command-confirm-takes-several-minutes-using-big-databases.aspx
            //this.HasRequired(o => o.BillingAddress).WithOptional().Map(x => x.MapKey("BillingAddressId")).WillCascadeOnDelete(false);
            //this.HasOptional(o => o.ShippingAddress).WithOptionalDependent().Map(x => x.MapKey("ShippingAddressId")).WillCascadeOnDelete(false);
            this.HasRequired(o => o.BillingAddress)
                .WithMany()
                .HasForeignKey(o => o.BillingAddressId)
                .WillCascadeOnDelete(false);
            this.HasOptional(o => o.ShippingAddress)
                .WithMany()
                .HasForeignKey(o => o.ShippingAddressId)
                .WillCascadeOnDelete(false);
        }
    }
}