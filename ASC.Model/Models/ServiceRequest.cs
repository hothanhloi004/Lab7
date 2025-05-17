using ASC.Model.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC.Model.Models
{
    public class ServiceRequest : BaseEntity, IAuditTracker
    {
        public ServiceRequest() { }
        public ServiceRequest(string email) 
        {
            this.RowKey = Guid.NewGuid().ToString();
            this.PartitionKey = email;
        }
        public string VechicleName { get; set; }
        public string VechicleType { get; set; }
        public string Status { get; set; }
        public string RequestedServiecs { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? CompletedTime { get; set; }
        public string ServiceEngineer { get; set; }

    }
}
