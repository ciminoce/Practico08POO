using Ejercicio04W.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicio04.Windows
{
    public partial class FrmProductosAE : Form
    {
        private Producto? producto;
        public FrmProductosAE()
        {
            InitializeComponent();

        }
        public Producto? GetProducto()
        {
            return producto;
        }
        public void SetProducto(Producto? producto)
        {
            this.producto = producto;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarTiposProducto();
            CargarDatosProducto(producto);
            if (producto is not null)
            {
                this.Text = "Editar Producto";

                TxtCodigo.Enabled = false; // El código no se debe cambiar en edición
                CboTipoProducto.Enabled = false; // El tipo de producto no se cambia en edición

            }
            else
            {
                this.Text = "Nuevo Producto";
                NudStock.Value = 1;

            }
        }

        // --- Método CargarTiposProducto modificado para usar la enumeración ---
        public void CargarTiposProducto()
        {
            CboTipoProducto.DataSource = Enum.GetValues(typeof(TipoProducto));
        }

        private void CargarDatosProducto(Producto? producto)
        {
            if (producto is not null)
            {
                TxtCodigo.Text = producto.Codigo;
                TxtNombre.Text = producto.Nombre;
                TxtPrecioBase.Text = producto.PrecioBase.ToString();
                NudStock.Value = producto.Stock;

                // Determinar el tipo del producto
                TipoProducto tipoSeleccionado = TipoProducto.Alimento; // Valor por defecto

                if (producto is Alimento)
                    tipoSeleccionado = TipoProducto.Alimento;
                else if (producto is Bebida)
                    tipoSeleccionado = TipoProducto.Bebida;
                else if (producto is ArticuloDeLimpieza)
                    tipoSeleccionado = TipoProducto.ArticuloDeLimpieza;

                CboTipoProducto.SelectedItem = tipoSeleccionado;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text;
            string nombre = TxtNombre.Text;
            decimal precioBase;
            int stock = (int)NudStock.Value;

            var tipoSeleccionado = (TipoProducto)CboTipoProducto.SelectedItem!;

            if (!decimal.TryParse(TxtPrecioBase.Text, out precioBase))
            {
                MessageBox.Show("El precio base debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (tipoSeleccionado)
            {
                case TipoProducto.Alimento:
                    producto = new Alimento()
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        PrecioBase = precioBase,
                        Stock = stock,
                        FechaVencimiento = DtpFechaVencimiento.Value

                    };
                    break;
                case TipoProducto.Bebida:
                    producto = new Bebida()
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        PrecioBase = precioBase,
                        Stock = stock,
                        EsAlcoholica = ChkEsAlcoholica.Checked

                    };
                    break;
                case TipoProducto.ArticuloDeLimpieza:
                    producto = new ArticuloDeLimpieza()
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        PrecioBase = precioBase,
                        Stock = stock,
                        EsBiodegradable = ChkEsBiodegradable.Checked

                    };
                    break;
                default:
                    MessageBox.Show("Debe seleccionar un tipo de producto.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            var validationContext = new ValidationContext(producto);
            var errores = new List<ValidationResult>();
            if (!Validator.TryValidateObject(producto, validationContext, errores, true))
            {
                MostrarErrores(errores);
                return;
            }
            DialogResult=DialogResult.OK;

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void MostrarErrores(List<ValidationResult> errores)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Errores en los datos comunes:");
            foreach (var error in errores)
            {
                sb.AppendLine($"- {error.ErrorMessage}");
            }
            MessageBox.Show(sb.ToString(), "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboTipoProducto.SelectedItem is TipoProducto tipo)
            {
                switch (tipo)
                {
                    case TipoProducto.Alimento:
                        MostrarControles(true, false, false);
                        break;

                    case TipoProducto.ArticuloDeLimpieza:
                        MostrarControles(false, false, true);
                        break;

                    case TipoProducto.Bebida:
                        MostrarControles(false, true, false);
                        break;
                }
            }
        }
        private void MostrarControles(bool fechaVencimiento, bool esAlcoholica, bool esBiodegradable)
        {
            DtpFechaVencimiento.Visible = fechaVencimiento;
            lblFechaVto.Visible = fechaVencimiento;

            ChkEsAlcoholica.Visible = esAlcoholica;

            ChkEsBiodegradable.Visible = esBiodegradable;
        }
    }
}

