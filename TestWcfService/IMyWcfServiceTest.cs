using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TestWcfService.BE;
using TestWcfService.DTO;

namespace TestWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyWcfServiceTest
    {

        [OperationContract]
        void Add(ClientesDTO cliente);

        [OperationContract]
        List<ClientesDTO> GetList();

        // TODO: Add your service operations here
    }

    /*
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
    */
}
