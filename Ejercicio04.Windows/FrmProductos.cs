using Ejercicio04W.Entidades;
using Ejercicio04W.Servicios;
using Ejercicio04W.Windows;
using Ejercicio04W.Windows.GridHelper;

namespace Ejercicio04.Windows
{
    public partial class FrmProductos : Form
    {
        private List<Producto>? productos;
        private readonly IServicioProductos _servicioProductos;

        public FrmProductos(IServicioProductos servicioProductos)
        {
            InitializeComponent();

            _servicioProductos = servicioProductos;
        }


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            productos = _servicioProductos.ObtenerTodos();
            MostrarDatosEnGrilla();
            LblStatus.Text = $"Mostrando {productos.Count} productos";
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var item in productos)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, item);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbFiltrar_Click(object sender, EventArgs e)
        {
            FrmFiltro frm = new FrmFiltro() { Text = "Seleccionar Filtro" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            TipoProducto tipoFiltro = frm.GetFiltro();
            productos = _servicioProductos.ObtenerTodos(tipoFiltro.ToString());
            MostrarDatosEnGrilla();
            LblStatus.Text = $"Mostrando productos tipo {tipoFiltro.ToString()}";
        }

        private void TsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tsbDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Producto productoDetalle = (Producto)r.Tag;
            FrmDetalles frm = new FrmDetalles() { Text = "Detalles del Producto" };
            frm.SetProducto(productoDetalle);
            DialogResult dr = frm.ShowDialog(this);
        }
    }
}
