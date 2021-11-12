using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinTestWcf.WcfStrvTest;

namespace WinTestWcf
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["captionForm"];
        }

        private void tlstrExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlstrTest_Click(object sender, EventArgs e)
        {
            MyWcfServiceTestClient client = new MyWcfServiceTestClient();
            // List<ClientesDTO> lst = new List<ClientesDTO>();
            BaseDTO[] arrDatos = client.GetList();

            

            dgrData.DataSource = arrDatos;

        }
    }
}
