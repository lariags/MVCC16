using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCC16
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //teste
            try
            {
                tbl_clienteC16DTO objDTO = new tbl_clienteC16DTO();
                tbl_ClienteC16BLL objBLL = new tbl_ClienteC16BLL();

                objDTO.Cpf_cliente = txtCpfC16.Text.Trim();
                objDTO.Nome_cliente = txtNomeC16.Text.Trim();
                objDTO.Nome_mae = txtNomeMaeC16.Text.Trim();

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

