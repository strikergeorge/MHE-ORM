using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Businesses
    {
        public string AirId { get; set; }
        public string BusinessCode { get; set; }
        public int? RequestType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ResponseEndPoint { get; set; }
        public bool? UseDefaultTemplate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
