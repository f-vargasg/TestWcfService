using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestWcfService.DTO
{

    [DataContract]
    public class BaseDTO
    {
        [DataMember]
        public int IdEntidad { get; set; }

        [DataMember]
        public string Mensaje { get; set; }
    }
}
