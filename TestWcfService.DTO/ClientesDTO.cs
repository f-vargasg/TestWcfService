using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TestWcfService.BE;

namespace TestWcfService.DTO
{

    [DataContract]
    public class ClientesDTO : BaseDTO
    {
        string nomCliente;

        public ClientesDTO()
        {

        }

        public ClientesDTO(ClienteBE clientesBE)
        {
            this.nomCliente = clientesBE.NomCliente;
        }

        [DataMember]
        public string NomCliente
        {
            get { return nomCliente; }
            set { nomCliente = value; }
        }
    }
}
