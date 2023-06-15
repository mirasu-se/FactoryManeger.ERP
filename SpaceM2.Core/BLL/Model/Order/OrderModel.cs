using System;

namespace SpaceM2.Core.BLL.Model
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string IssuedBy { get; set; }
        public string ProjectNumber { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierAddressNumber { get; set; }
        public string StatusType { get; set; }
        public string Comment { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DesiredDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime NeededDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNumeber { get; set; }
        public string OrderClarification { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal Calculation { get; set; }
        public string Warranty { get; set; }
        public string IndustrialAgreement { get; set; }
        public string Responsibility { get; set; }
    }
}
