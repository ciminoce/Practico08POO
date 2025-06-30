using Ejercicio04W.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04.Windows
{
    public partial class FrmDetalles : Form
    {
        private Producto producto;
        public FrmDetalles()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            TxtCodigo.Text=producto.Codigo;
            TxtPrecioBase.Text = producto.PrecioBase.ToString();
            TxtStock.Text = producto.Stock.ToString();
            TxtTipoProducto.Text = producto.GetType().Name;
            TxtNombre.Text = producto.Nombre;
            if(producto is Bebida b)
            {
                MostrarDetalles(true, false, false);
                ChkEsAlcoholica.Checked=b.EsAlcoholica;
            }else if(producto is Alimento a)
            {
                MostrarDetalles(false, false, true);
                TxtFechaVto.Text = a.FechaVencimiento.ToShortDateString();
            }
            else if(producto is ArticuloDeLimpieza art)
            {
                MostrarDetalles(false, true, false);
                ChkEsBiodegradable.Checked = art.EsBiodegradable;
            }
        }

        private void MostrarDetalles(bool verAlco, bool verBio, bool verFecha)
        {
            ChkEsAlcoholica.Visible = verAlco;
            ChkEsBiodegradable.Visible = verBio;

            lblFechaVto.Visible = verFecha;
            TxtFechaVto.Visible = verFecha;
        }
    }
}
