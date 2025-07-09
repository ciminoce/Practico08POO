using Ejercicio04W.Entidades;
using Ejercicio04W.Servicios;
using Ejercicio04W.Servicios.Dto;
using Ejercicio04W.Windows.GridHelper;
using System.Text;

namespace Ejercicio04.Windows
{
    public partial class FrmProductos : Form
    {
        private IServicioProductos _servicioProductos;
        private List<Producto> productos = null!;
        public FrmProductos(IServicioProductos servicioProductos)
        {
            InitializeComponent();

            _servicioProductos = servicioProductos;
        }

        private void CargarDatosIniciales()
        {
            if (!_servicioProductos.ObtenerTodos().Any())
            {
                _servicioProductos.Agregar(new Alimento { Codigo = "A0001", Nombre = "Pan Integral", PrecioBase = 500, Stock = 30, FechaVencimiento = DateTime.Today.AddDays(7) });
                _servicioProductos.Agregar(new Bebida { Codigo = "B0002", Nombre = "Gaseosa Cola", PrecioBase = 800, Stock = 100, EsAlcoholica = false });
                _servicioProductos.Agregar(new ArticuloDeLimpieza { Codigo = "L0003", Nombre = "Detergente Bio", PrecioBase = 650, Stock = 50, EsBiodegradable = true });
                _servicioProductos.Agregar(new Alimento { Codigo = "A0004", Nombre = "Leche Fresca", PrecioBase = 750, Stock = 20, FechaVencimiento = DateTime.Today.AddDays(2) });
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (FrmProductosAE frmAE = new FrmProductosAE())
            {
                DialogResult dr = frmAE.ShowDialog(this);

                if (dr == DialogResult.Cancel)
                {
                    LblStatus.Text = "Creación de producto cancelada.";
                    return;
                }

                Producto? producto = frmAE.GetProducto();

                if (producto is null)
                    return;

                ValidationResultDto resultado = _servicioProductos.Agregar(producto);

                if (resultado.EsValido)
                {
                    LblStatus.Text = "Producto agregado exitosamente.";
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, producto);
                    GridHelper.AgregarFila(r, dgvDatos);
                }
                else
                {
                    MostrarErrores(resultado.Errores);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                LblStatus.Text = "Seleccione un producto para editar.";
                return;
            }

            string? codigoSeleccionado = dgvDatos.SelectedRows[0].Cells["Codigo"].Value.ToString();
            Producto? productoAEditar = _servicioProductos.ObtenerProductoPorCodigo(codigoSeleccionado);

            if (productoAEditar == null)
            {
                LblStatus.Text = "Producto no encontrado para editar. Recargue la lista.";
                return;
            }

            using (FrmProductosAE frmAE = new FrmProductosAE())
            {
                frmAE.SetProducto(productoAEditar);
                if (frmAE.ShowDialog() == DialogResult.OK)
                {
                    // frmAE.ProductoFinal ya contendrá el producto completo editado
                    productoAEditar = frmAE.GetProducto();
                    if (productoAEditar == null) return;
                    ValidationResultDto resultado = _servicioProductos.Editar(productoAEditar);
                    if (resultado.EsValido)
                    {
                        LblStatus.Text = "Producto editado exitosamente.";
                        DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                        GridHelper.SetearFila(r, productoAEditar);
                        GridHelper.AgregarFila(r, dgvDatos);

                    }
                    else
                    {
                        MostrarErrores(resultado.Errores);
                    }
                }
                else
                {
                    LblStatus.Text = "Edición de producto cancelada.";
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }


        //private void btnRefrescar_Click(object sender, EventArgs e)
        //{
        //    ActualizarListaProductos();
        //    txtFiltroNombre.Text = ""; // Limpiar filtro
        //}

        //private void btnAplicarFiltro_Click(object sender, EventArgs e)
        //{
        //    ActualizarListaProductos(txtFiltroNombre.Text);
        //}

        private void MostrarErrores(List<string> errores) // Para errores del ValidationResultDto
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Errores de validación:");
            foreach (var error in errores)
            {
                sb.AppendLine($"- {error}");
            }
            MessageBox.Show(sb.ToString(), "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LblStatus.Text = "Errores en la operación. Vea el detalle.";
        }
        private void CargarTiposProductoFiltro()
        {
            // Añadir la opción "Seleccione" al principio
            CboTiposProductosFiltro.Items.Add("Seleccione");

            // Añadir los valores de la enumeración TipoProducto
            foreach (TipoProducto tipo in Enum.GetValues(typeof(TipoProducto)))
            {
                CboTiposProductosFiltro.Items.Add(tipo.ToString());
            }
            CboTiposProductosFiltro.SelectedIndex = 0; // Seleccionar "Seleccione" por defecto
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

            CargarDatosIniciales();
            productos = _servicioProductos.ObtenerTodos();
            CargarTiposProductoFiltro();
            MostrarDatosEnGrilla();
            LblStatus.Text = $"Mostrando {productos.Count} productos.";

        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (Producto p in productos)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, p);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

        private void CboTiposProductosFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboTiposProductosFiltro.SelectedIndex == 0) return;

            string? tipoProducto = CboTiposProductosFiltro.SelectedItem?.ToString();
            if (tipoProducto != null)
            {
                productos = _servicioProductos.ObtenerTodos(tipoProducto);
                MostrarDatosEnGrilla();
                LblStatus.Text = $"Mostrando {productos.Count} de tipo {tipoProducto}";
            }
            else
            {
                LblStatus.Text = "Error: No se pudo determinar el tipo de producto seleccionado.";
            }
        }

        private void TsbActualizar_Click(object sender, EventArgs e)
        {
            productos = _servicioProductos.ObtenerTodos();
            MostrarDatosEnGrilla();
            LblStatus.Text = $"Mostrando {productos.Count} productos";
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                LblStatus.Text = "Seleccione un producto para ver sus detalles.";
                return;
            }
            var r = dgvDatos.SelectedRows[0];

            string? codigoSeleccionado = r.Cells["Codigo"].Value.ToString();
            Producto? producto = _servicioProductos.ObtenerProductoPorCodigo(codigoSeleccionado!);

            if (producto != null)
            {
                using (FrmDetalles frmDetalles = new FrmDetalles())
                {
                    frmDetalles.SetProducto(producto);
                    frmDetalles.ShowDialog(); // Mostrar como modal
                }
            }
            else
            {
                LblStatus.Text = "Producto no encontrado. Recargue la lista.";
            }

        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                LblStatus.Text = "Seleccione un producto para editar.";
                return;
            }

            string? codigoSeleccionado = dgvDatos.SelectedRows[0].Cells["Codigo"].Value.ToString();
            Producto? productoAEditar = _servicioProductos.ObtenerProductoPorCodigo(codigoSeleccionado);

            if (productoAEditar == null)
            {
                LblStatus.Text = "Producto no encontrado para editar. Recargue la lista.";
                return;
            }

            using (FrmProductosAE frmAE = new FrmProductosAE())
            {
                frmAE.SetProducto(productoAEditar);
                if (frmAE.ShowDialog() == DialogResult.OK)
                {

                    productoAEditar = frmAE.GetProducto();
                    if (productoAEditar == null) return;
                    ValidationResultDto resultado = _servicioProductos.Editar(productoAEditar);
                    if (resultado.EsValido)
                    {
                        LblStatus.Text = "Producto editado exitosamente.";
                        DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                        GridHelper.SetearFila(r, productoAEditar);
                        GridHelper.AgregarFila(r, dgvDatos);

                    }
                    else
                    {
                        MostrarErrores(resultado.Errores);
                    }
                }
                else
                {
                    LblStatus.Text = "Edición de producto cancelada.";
                }
            }

        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                LblStatus.Text = "Seleccione un producto para eliminar.";
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            DialogResult confirmacion = MessageBox
                .Show("¿Está seguro que desea eliminar el producto seleccionado?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {

                string? codigoSeleccionado = r.Cells["Codigo"].Value.ToString();
                ValidationResultDto resultado = _servicioProductos.Eliminar(codigoSeleccionado!);

                if (resultado.EsValido)
                {
                    LblStatus.Text = "Producto eliminado exitosamente.";
                    GridHelper.QuitarFila(r, dgvDatos);

                }
                else
                {
                    MostrarErrores(resultado.Errores);
                }
            }
            else
            {
                LblStatus.Text = "Eliminación cancelada.";
            }

        }
    }
}
