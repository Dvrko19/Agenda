using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        private List<Persona> mPersonas;
        private Persona mPersona;
        private PersonasConsultas MpersonasC;
        public Form1()
        {
            InitializeComponent();
            MpersonasC = new PersonasConsultas();
            mPersonas = new List<Persona>();
            mPersona = new Persona();
            CargarProductos();
            DataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void CargarProductos(string filtro = "")
        {
            DataGrid1.Refresh();
            DataGrid1.Rows.Clear();
            mPersonas.Clear();
            mPersonas = MpersonasC.getPersonas(filtro);
            for (int i = 0; i < mPersonas.Count; i++)
            {
                DataGrid1.RowTemplate.Height = 50;
                DataGrid1.Rows.Add(
                    mPersonas[i].id,
                    mPersonas[i].nombre,
                    mPersonas[i].Birth,
                    mPersonas[i].Gen,
                    mPersonas[i].email,
                    mPersonas[i].phone,
                    mPersonas[i].city
                    );
               
            }
        }
        private bool DatosCorrectos() {
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            };
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el email");
                return false;
            };
            if (txtPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el numero telefonico");
                return false;
            };
            if (txtCity.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la ciudad");
                return false;
            };
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;
               
            }
            CargarDatosProductos();
            if (MpersonasC.AgregarPersona(mPersona))
            {
                MessageBox.Show("Persona agregada con exito");
                CargarProductos();
                LimpiarCampo();

            }

        }

        private void LimpiarCampo()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
            txtID.Text = "";
            txtBirth.Text = "";
            txtGen.Text = "";
        }

        private void CargarDatosProductos()
        {
            mPersona.id = getIDIfExist();
            mPersona.nombre = txtName.Text.Trim();
            mPersona.email = txtEmail.Text.Trim();
            mPersona.phone = txtPhone.Text.Trim();
            mPersona.city = txtCity.Text.Trim();    
            mPersona.Gen = txtGen.Text.Trim();
            mPersona.Birth = txtBirth.Text.Trim();


        }

        private int getIDIfExist()
        {
            if (int.TryParse(txtID.Text.Trim(), out int id))
            {
                return id;
            }
            return -1;
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DataGrid1.Rows[e.RowIndex];
            txtName.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtEmail.Text = Convert.ToString(fila.Cells["Email"].Value);
            txtPhone.Text = Convert.ToString(fila.Cells["Phone"].Value);
            txtCity.Text = Convert.ToString(fila.Cells["city"].Value);
            txtGen.Text = Convert.ToString(fila.Cells["Gen"].Value);
            txtBirth.Text = Convert.ToString(fila.Cells["Birth"].Value);
            txtID.Text = Convert.ToString(fila.Cells["id"].Value);
            MemoryStream Stream = new MemoryStream();

        }

        private void Bmodificar_Click(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;

            }
            CargarDatosProductos();
            if (MpersonasC.ModificarPersona(mPersona))
            {
                MessageBox.Show("Persona modificada con exito");
                CargarProductos();
                LimpiarCampo();

            }
        }

        private void Beliminar_Click_1(object sender, EventArgs e)
        {
            if (getIDIfExist() == 1)
            {
                return ;
            }
            if(MessageBox.Show("¿Desea Borrar a la persona?", "Eliminar Persona", MessageBoxButtons.YesNo) == DialogResult.Yes){

                CargarDatosProductos();
                if (MpersonasC.EliminarProducto(mPersona))
                {
                    
                    MessageBox.Show("Persona eliminada con exito");
                    CargarProductos();
                    LimpiarCampo();
                }

            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             CargarProductos(txtfind.Text.Trim());
        }
    }
}
