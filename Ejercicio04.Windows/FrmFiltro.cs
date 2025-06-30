using Ejercicio04W.Entidades;

namespace Ejercicio04W.Windows
{
    public partial class FrmFiltro : Form
    {
        private TipoProducto tipoProductoFiltro;
        public FrmFiltro()
        {
            InitializeComponent();
        }

        public TipoProducto GetFiltro()
        {
            return tipoProductoFiltro;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            CboTipoProducto.DataSource = Enum.GetValues(typeof(TipoProducto));
        }

        private void CboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoProductoFiltro = (TipoProducto)CboTipoProducto.SelectedItem!;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
