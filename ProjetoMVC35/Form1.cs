using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVC35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_clienteC30DTO objDTO = new tbl_clienteC30DTO();
                tbl_ClienteC30BLL objBLL = new tbl_ClienteC30BLL();

                objDTO.Cpf_cliente = txtCpfC30.Text.Trim();
                objDTO.Nome_cliente = txtNomeC30.Text.Trim();
                objDTO.Nome_mae = txtMaeC30.Text.Trim();

                if (objBLL.Autenticar(objDTO.Cpf_cliente, objDTO.Nome_cliente, objDTO.Nome_mae))
                {
                    MessageBox.Show("Beneficiário localizado no banco de dados");
                }
                else
                {
                    MessageBox.Show("Beneficiário não Localizado no banco de dados");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Erro: \n" + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
