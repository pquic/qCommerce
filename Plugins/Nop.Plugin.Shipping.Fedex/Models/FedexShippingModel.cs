﻿using System.Collections.Generic;
using Nop.Web.Framework;

namespace Nop.Plugin.Shipping.Fedex.Models
{
    public class FedexShippingModel
    {
        public FedexShippingModel()
        {
            CarrierServicesOffered = new List<string>();
            AvailableCarrierServices = new List<string>();
        }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.Url")]
        public string Url { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.Key")]
        public string Key { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.Password")]
        public string Password { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.AccountNumber")]
        public string AccountNumber { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.MeterNumber")]
        public string MeterNumber { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.UseResidentialRates")]
        public bool UseResidentialRates { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.ApplyDiscounts")]
        public bool ApplyDiscounts { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }

        public IList<string> CarrierServicesOffered { get; set; }
        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.CarrierServices")]
        public IList<string> AvailableCarrierServices { get; set; }
        public string[] CheckedCarrierServices { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.Street")]
        public string Street { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.City")]
        public string City { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.StateOrProvinceCode")]
        public string StateOrProvinceCode { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.PostalCode")]
        public string PostalCode { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.CountryCode")]
        public string CountryCode { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.Fedex.Fields.PassDimensions")]
        public bool PassDimensions { get; set; }
    }
}