using System.ComponentModel.DataAnnotations;

namespace MILILAssesment.Models
{
    public class PRBookInfoViewModel
    {
            [Required(ErrorMessage = "The ReqNo field is required.")]
            [StringLength(20, ErrorMessage = "The ReqNo field must be at most {1} characters.")]
            public string ReqNo { get; set; }

            [Display(Name = "Request Date")]
            [DataType(DataType.DateTime, ErrorMessage = "Invalid date format.")]
            public DateTime? ReqDate { get; set; }

            [StringLength(40, ErrorMessage = "The ReqBy field must be at most {1} characters.")]
            public string ReqBy { get; set; }

            [Display(Name = "Request Quantity")]
            public decimal? ReqQty { get; set; }

            [Display(Name = "Issued Quantity")]
            public decimal? IssuedQty { get; set; }

            [StringLength(20, ErrorMessage = "The OfficeCode field must be at most {1} characters.")]
            public string OfficeCode { get; set; }

            [Display(Name = "Issue Date")]
            [DataType(DataType.DateTime, ErrorMessage = "Invalid date format.")]
            public DateTime? IssuedDate { get; set; }

            [Display(Name = "Status")]
            [StringLength(20, ErrorMessage = "The Status field must be at most {1} characters.")]
            public string Status { get; set; }

            [Display(Name = "User Name")]
            [StringLength(50, ErrorMessage = "The UserName field must be at most {1} characters.")]
            public string UserName { get; set; }

            [Display(Name = "Entry Date")]
            public DateTime? EntryDate { get; set; }

            [Display(Name = "Req by Tier Code")]
            [StringLength(30, ErrorMessage = "The ReqbyTierCode field must be at most {1} characters.")]
            public string ReqbyTierCode { get; set; }

            [Display(Name = "Update User Name")]
            [StringLength(50, ErrorMessage = "The UpdateUserName field must be at most {1} characters.")]
            public string UpdateUserName { get; set; }

            [Display(Name = "Update Entry Date")]
            public DateTime? UpdateEntryDate { get; set; }

            [Display(Name = "Entry WSIP")]
            [StringLength(50, ErrorMessage = "The EntryWSIP field must be at most {1} characters.")]
            public string EntryWSIP { get; set; }

            [Display(Name = "Update WSIP")]
            [StringLength(50, ErrorMessage = "The UpdateWSIP field must be at most {1} characters.")]
            public string UpdateWSIP { get; set; }

            [Display(Name = "Locked")]
            public bool Locked { get; set; }

            [Display(Name = "Active")]
            public bool Active { get; set; }

            [Display(Name = "Archive")]
            public bool Archive { get; set; }

    }
}
