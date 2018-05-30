using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Requests
    {
        public string RequestId { get; set; }
        public string AirId { get; set; }
        public string BusinessCode { get; set; }
        public string ApproverPeoplekey { get; set; }
        public string Title { get; set; }
        public DateTime? DueDate { get; set; }
        public int? Priority { get; set; }
        public string FromEnterpriseId { get; set; }
        public string OtherJsonDetails { get; set; }
        public bool? IsRead { get; set; }
        public string ApplicationName { get; set; }
        public int? RequestType { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? RequestTime { get; set; }
    }
}
