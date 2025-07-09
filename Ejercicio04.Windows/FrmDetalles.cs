using Ejercicio04W.Entidades;

namespace Ejercicio04.Windows
{
    public partial class FrmDetalles : Form
    {
        private Producto? producto;
        public FrmDetalles()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);
            if (producto is not null)
            {
                
            }
        }
        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }
    }
}
