using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TestWcfService.BE;
using TestWcfService.BL;
using TestWcfService.DTO;

namespace TestWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MyWcfServiceTest : IMyWcfServiceTest
    {
        

        public void Add(ClientesDTO cliente)
        {
            ClientesBL clienteBL = new ClientesBL();
            ClienteBE clienteBE = new ClienteBE
            {
                CodClienteN = cliente.IdEntidad,
                NomCliente = cliente.NomCliente
            };

            clienteBL.Add(clienteBE);

        }

        public List<BaseDTO> GetList()
        {
            var res = new List<BaseDTO>();
            ClientesBL clienteBL = new ClientesBL();
            foreach (var item in clienteBL.GetList())
            {
                ClientesDTO clientesDTO = new ClientesDTO
                {
                    IdEntidad = item.CodClienteN,
                    NomCliente = item.NomCliente
                };

                res.Add(clientesDTO);
            }

            return res;


        }
    }
}
