using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Productos
    {
        //Creamos nuestra lista para la data table
        public DataTable ListaDT { get; set; } = new DataTable();

        //Crea la Estructura de la Lista de alumnos
        //
        public Productos()
        {
            ListaDT.TableName = "ListaProductos";
            ListaDT.Columns.Add("Codigo");
            ListaDT.Columns.Add("Descripcion");
            ListaDT.Columns.Add("Stock");

            LeerArchivo();
        }

        //Lee el archivo Alumnos.xml si es que este existe
        //
        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Productos.xml"))
            {
                ListaDT.ReadXml("Productos.xml");
            }
        }

        // Inserta un nuevo alumno en la lista de alumnos y luego escribe esta lista en el archivo Alumnos.xml
        //
        public void InsertProducto(Producto aProducto)
        {
            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Codigo"] = aProducto.p_codigo;
            ListaDT.Rows[NuevoRenglon]["Descripcion"] = aProducto.p_descripcion;
            ListaDT.Rows[NuevoRenglon]["Stock"] = aProducto.p_stock;


            ListaDT.WriteXml("Productos.xml");
        }

        public void IngresoStock(string txtCant, string txtId, Producto aProducto)
        {
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    row["Stock"] = Convert.ToInt32(row["Stock"]) + Convert.ToInt32(txtCant);
                    ListaDT.WriteXml("Productos.xml");
                }
            }
            ListaDT.AcceptChanges();
            return;
        }

        public void SalidaStock(string txtCant, string txtId, Producto aProducto)
        {
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    row["Stock"] = Convert.ToInt32(row["Stock"]) - Convert.ToInt32(txtCant);
                    if (Convert.ToInt32(row["Stock"]) <= 0)
                    {
                        row["Stock"] = 0;
                    }

                    ListaDT.WriteXml("Productos.xml");
                }
            }
            ListaDT.AcceptChanges();
            return;
        }



        public bool BorrarProducto(string txtId)
        {
            bool existe = false;
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {

                if (txtId == (row["Codigo"].ToString()))
                {
                    row.Delete();
                    ListaDT.WriteXml("Productos.xml");
                    existe = true;
                }
            }
            ListaDT.AcceptChanges();
            return existe;
        }

        public bool ExisteProducto(string txtId)
        {
            bool existe = false;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    existe = true;
                }
            }
            return existe;

        }

        public int BuscarProducto(string txtId)
        {
            int index = 0;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    index = ListaDT.Rows.IndexOf(row);

                }
            }
            return index;

        }

        public string BuscarDescripcion(string txtCod)
        {
            string DescripcionEncontrada = null;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtCod == (row["Codigo"].ToString()))
                {
                    DescripcionEncontrada = (row["Descripcion"].ToString());

                }
            }
            return DescripcionEncontrada;

        }

        public int BuscarStock(string txtCod)
        {
            int StockEncontrado = 0;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtCod == (row["Codigo"].ToString()))
                {
                    StockEncontrado = Convert.ToInt32(row["Stock"]);

                }
            }
            return StockEncontrado;

        }

        private int NuevoId()
        {
            int NuevoId = 0;

            foreach (DataRow fila in ListaDT.Rows)
            {
                if (NuevoId < Convert.ToInt32(fila["Id"]))
                {
                    NuevoId = Convert.ToInt32(fila["Id"]);
                }
            }

            NuevoId++;
            return NuevoId;
        }



    }

}

