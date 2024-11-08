﻿using Strategy.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Core
{
    internal class InvoiceManager
    {
        private ICustomerDiscountStrategy _discountStratigy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy discountStrategy)
        {
            _discountStratigy = discountStrategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new List<InvoiceLine> { new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice } },
            };
            invoice.DiscountPercentage = _discountStratigy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
