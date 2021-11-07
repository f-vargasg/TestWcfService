using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWcfService.BE;
using TestWcfService.DL;

namespace TestWcfService.BL
{
    public class ClientesBL
    {

        ClientesDL clienteDL;

        public ClientesBL()
        {
            this.clienteDL = new ClientesDL();
        }

        public void Add(ClientesBE clientesBE)
        {
            this.clienteDL.Add(clientesBE);
        }

        public List<ClientesBE> GetList()
        {
            return this.clienteDL.GetList();
        }

    }
}
