using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWcfService.BE;

namespace TestWcfService.DL
{
    public class ClientesDL
    {
        List<ClienteBE> lstData;

        public ClientesDL()
        {
            this.lstData = new List<ClienteBE>();

            this.lstData.Add(new ClienteBE {
                CodClienteN = 1,
                NomCliente = "Cliente1"
            });

            this.lstData.Add(new ClienteBE
            {
                CodClienteN = 2,
                NomCliente = "Cliente2"
            });

        }

        public void Add(ClienteBE clienteBE)
        {
            lstData.Add(clienteBE);
        }

        public List<ClienteBE> GetList()
        {
            return this.lstData;
        }
    }
}
