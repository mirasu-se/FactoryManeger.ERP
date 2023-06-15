using System;
namespace SpaceM2.Core.BLL.Model
{
    public class ProjectModel
    {
        public int ProjectId { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public int CustomerTypeId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int MunicipalityId { get; set; }
        public string MunicipalityName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public string StatusKey { get; set; }
        public string DrawingFilePath { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public DateTime RealStartDate { get; set; }
        public DateTime RealEndDate { get; set; }
        public int NumberOfBuildings { get; set; }
    }
}
