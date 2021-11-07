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
        List<ClientesBE> lstData;

        public ClientesDL()
        {
            this.lstData = new List<ClientesBE>();

            this.lstData.Add(new ClientesBE {
                CodClienteN = 1,
                NomCliente = "Cliente1"
            });

            this.lstData.Add(new ClientesBE
            {
                CodClienteN = 2,
                NomCliente = "Cliente2"
            });

        }

        public void Add(ClientesBE clienteBE)
        {
            lstData.Add(clienteBE);
        }

        public List<ClientesBE> GetList()
        {
            return this.lstData;
        }
    }
}
