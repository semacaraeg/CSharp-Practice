using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAzureFunc
{
    class LeaveRequest
    {
        [JsonProperty(PropertyName = "employeeID")]
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
