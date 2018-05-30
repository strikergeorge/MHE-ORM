using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Applications
    {
        public string AirId { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }
        public string AuthCode { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
