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
    public class ClientesDTO
    {
        int codClienteN;
        string nomCliente;

        public ClientesDTO()
        {

        }

        public ClientesDTO(ClientesBE clientesBE)
        {
            this.codClienteN = clientesBE.CodClienteN;
            this.nomCliente = clientesBE.NomCliente;
        }

        [DataMember]
        public int CodClienteN
        {
            get { return codClienteN; }
            set { codClienteN = value; }
        }

        [DataMember]
        public string NomCliente
        {
            get { return nomCliente; }
            set { nomCliente = value; }
        }
    }
}
