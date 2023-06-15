namespace SpaceM2.Core.BLL.Model
{
    public class ConstructionModel
    {
        public int ConstructionId { get; set; }
        public int ConstructionNumber { get; set; }
        public string WallType { get; set; }
        public int SortingOrder { get; set; }
        public string MaterialName { get; set; }
        public decimal PartThickness { get; set; }
        public bool ForProcessing { get; set; }
        public decimal FinalThickness { get; set; }
    }
}
