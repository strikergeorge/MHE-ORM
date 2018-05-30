using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class RequestHistory
    {
        public int RequestHistoryId { get; set; }
        public string RequestId { get; set; }
        public int? ApprovalStatus { get; set; }
        public string Comments { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
