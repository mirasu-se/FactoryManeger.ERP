namespace SpaceM2.Core.BLL.Model
{
    public class QuantityModel
    {
        public int QuantityId { get; set; }
        public string OrderNumber { get; set; }
        public string ModuleNumber { get; set; }
        public string ItemNumber { get; set; }
        public string ItemComment { get; set; }
        public decimal ItemLength { get; set; }
        public decimal ItemWidth { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int NumberOfItems { get; set; }
        public decimal Conversion { get; set; }
    }
}
