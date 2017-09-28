using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CRMService
{
    [DataContract]
    public class ProxyEmployee
    {
        [DataMember]
        public DateTime? BirthDate { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}