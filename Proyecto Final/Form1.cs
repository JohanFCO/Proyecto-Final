namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CConexion conexion = new CConexion();
            conexion.abrir();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManejodeClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo (new Manejo_de_Clientes());

        }

        private void btnRecibodepago_Click(object sender, EventArgs e)
        {
            AbrirFormHijo (new Recibo_de_pago());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void AbrirFormHijo (object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();


        }

        private void btnManejodeProducto_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Manejo_de_Producto());

        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Consultar_Ventas());
        }

        private void btnEntradaAlmacen_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Entrada_a_Almacen());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Factura());
        }
    }
}