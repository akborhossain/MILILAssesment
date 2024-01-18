namespace MILILAssesment.Models.Entities
{
    public class PRBookInfo
    {
        public int Id { get; set; }
        public string ReqNo { get; set; }
        public DateTime? ReqDate { get; set; }
        public string ReqBy { get; set; }
        public decimal? ReqQty { get; set; }
        public decimal? IssuedQty { get; set; }
        public string OfficeCode { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public DateTime? EntryDate { get; set; }
        public string ReqbyTierCode { get; set; }
        public string UpdateUserName { get; set; }
        public DateTime? UpdateEntryDate { get; set; }
        public string EntryWSIP { get; set; }
        public string UpdateWSIP { get; set; }
        public bool Locked { get; set; }
        public bool Active { get; set; }
        public bool Archive { get; set; }
    }
}
