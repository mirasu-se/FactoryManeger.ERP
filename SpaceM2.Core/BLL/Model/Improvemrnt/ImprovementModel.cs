using System;

namespace SpaceM2.Core.BLL.Model
{
    public class ImprovementModel
    {
        public int ImprovementId { get; set; }
        public string ProjectNumber { get; set; }
        public string StatusType { get; set; }
        public DateTime DateRegistered { get; set; }
        public string IssuedBy { get; set; }
        public string Problem { get; set; }
        public string ImprovementReason { get; set; }
        public string ActionInProject { get; set; }
        public string Responsible1 { get; set; }
        public DateTime RepairDate { get; set; }
        public string Solution { get; set; }
        public string Responsible2 { get; set; }
        public DateTime LongTermDateStart { get; set; }
        public int VeckaStart { get; set; }
        public int VeckaSlut{ get; set; }
    }
}
