using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Productos_FE
{
    public partial class FrmProductos : Form
    {
        Producto producto = new Producto();

        Productos productos = new Productos();

        public bool existe;
        public int index;

        public long Valorverif;
        public long Verificacion;

        public FrmProductos()
        {
            InitializeComponent();
            dataGridView1.DataSource = productos.ListaDT;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            lblDescripcionMov.Text = "";
            lblStockMov.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtCodigo.Text != "Codigo")
            {
                //borro el error 
                errorCodigo.SetError(txtCodigo, "");
            }
            else
            {
                errorCodigo.SetError(txtCodigo, "Debe ingresar un codigo");
                txtCodigo.Focus();
                return;
            }

            if (long.TryParse(txtCodigo.Text, out Verificacion))
            {
                Valorverif = long.Parse(txtCodigo.Text);
                errorCodigo.SetError(txtCodigo, "");
            }
            else
            {
                errorCodigo.SetError(txtCodigo, "Ingrese un codigo numerico");
                return;
            }

            if (txtDescripcion.Text != "" && txtDescripcion.Text != "Descripcion")
            {
                //borro el error 
                errorDescripcion.SetError(txtDescripcion, "");
            }
            else
            {
                errorDescripcion.SetError(txtDescripcion, "Debe ingresar una descripcion");
                txtDescripcion.Focus();
                return;
            }

           



            Producto producto = new Producto(int.Parse(txtCodigo.Text), txtDescripcion.Text);

            existe = productos.ExisteProducto(txtCodigo.Text);
            if(existe)
            {
                MessageBox.Show("Este codigo de producto ya fue cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            lblStockMov.Text = producto.p_stock.ToString() + " Unidades";

            productos.InsertProducto(producto);
            dataGridView1.DataSource = productos.ListaDT;
            dataGridView1.ClearSelection();
            MessageBox.Show("Producto Cargado");

            lblDescripcionMov.Text = productos.BuscarDescripcion(txtCodigo1.Text);
            lblStockMov.Text = productos.BuscarStock(txtCodigo1.Text).ToString() + " Unidades";

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                errorCodigo.SetError(txtCodigo, "Ingrese un codigo");
                return;
            }
            errorCodigo.SetError(txtCodigo, "");

            existe = productos.ExisteProducto(txtCodigo.Text);
            if (long.TryParse(txtCodigo.Text, out Verificacion) && existe)
            {
                Valorverif = long.Parse(txtCodigo.Text);
                productos.BorrarProducto(txtCodigo.Text);

                dataGridView1.DataSource = productos.ListaDT;
                dataGridView1.ClearSelection();
                MessageBox.Show("Producto Borrado");

                lblDescripcionMov.Text = productos.BuscarDescripcion(txtCodigo1.Text);
                lblStockMov.Text = productos.BuscarStock(txtCodigo1.Text).ToString() + " Unidades";
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("El codigo no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                errorCodigo.SetError(txtCodigo, "Ingrese un codigo");
                return;
            }
            errorCodigo.SetError(txtCodigo, "");


            existe = productos.ExisteProducto(txtCodigo.Text);
            index = productos.BuscarProducto(txtCodigo.Text);

            if (long.TryParse(txtCodigo.Text, out Verificacion) && existe)
            {
                Valorverif = long.Parse(txtCodigo.Text);
                dataGridView1.Rows[index].Selected = true;
            }
            else
            {
                MessageBox.Show("El codigo no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CargaProductos_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void FrmProductos_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            existe = productos.ExisteProducto(txtCodigo1.Text);
            index = productos.BuscarProducto(txtCodigo1.Text);

            if(existe)
            {
                lblDescripcionMov.Text = productos.BuscarDescripcion(txtCodigo1.Text);
                lblStockMov.Text = productos.BuscarStock(txtCodigo1.Text).ToString() + " Unidades";
            }
            else
            {
                lblDescripcionMov.Text = "";
                lblStockMov.Text = "";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            existe = productos.ExisteProducto(txtCodigo1.Text);
            if (!existe)
            {
                MessageBox.Show("Ingrese un codigo valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad valida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnIngreso.Checked)
            {
                productos.IngresoStock(txtCantidad.Text, txtCodigo1.Text, producto);
                MessageBox.Show("Stock Actualizado");
            }

            if (btnSalida.Checked)
            {
                productos.SalidaStock(txtCantidad.Text, txtCodigo1.Text, producto);
                MessageBox.Show("Stock Actualizado");
            }

            lblDescripcionMov.Text = productos.BuscarDescripcion(txtCodigo1.Text);
            lblStockMov.Text = productos.BuscarStock(txtCodigo1.Text).ToString() + " Unidades";

            txtCodigo1.Text = "";
            txtCantidad.Text = "";

            dataGridView1.DataSource = productos.ListaDT;
            dataGridView1.ClearSelection();
            
        }
    }
}
