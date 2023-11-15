namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        double precio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("c");
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProducto.Text;

            if (producto.Equals("Aguardiente 375ml")) precio = 22.000;
            if (producto.Equals("Aguardiente 750ml")) precio = 35.000;
            if (producto.Equals("Aguardiente 1L")) precio = 65.000;
            if (producto.Equals("Ron Caldas 375ml")) precio = 35.000;
            if (producto.Equals("Ron Caldas 750ml")) precio = 45.000;
            if (producto.Equals("Ron Caldas 1L")) precio = 120.000;
            if (producto.Equals("jhonny Walker whisky")) precio = 85.000;
            if (producto.Equals("Black and White carterita")) precio = 20.000;
            if (producto.Equals("Black and white 1L")) precio = 45.000;
            if (producto.Equals("Smirnoff 375ml")) precio = 9.000;
            if (producto.Equals("Baileys 700ml")) precio = 60.000;
            if (producto.Equals("Passport Scotch 1L")) precio = 50.000;
            if (producto.Equals("Something Special 700ml")) precio = 70.000;
            if (producto.Equals("Coronita 210ml")) precio = 4.000;
            if (producto.Equals("Corona 355ml")) precio = 5.000;
            if (producto.Equals("Aguila 1L")) precio = 5.500;
            if (producto.Equals("Aguila Ligth 750ml")) precio = 4.500;
            if (producto.Equals("Aguila ligth 1L")) precio = 5.500;
            if (producto.Equals("Poker 1L")) precio = 6.000;
            if (producto.Equals("Poker 750ml")) precio = 4.500;
            if (producto.Equals("Poker lata")) precio = 3.500;
            if (producto.Equals("Aguila lata")) precio = 3.500;
            if (producto.Equals("Aguila ligth lata")) precio = 3.500; ;
            if (producto.Equals("Coronita en lata")) precio = 3.500;
            if (producto.Equals("Cola y Pola lata ")) precio = 3.500;
            if (producto.Equals("Botella de agua")) precio = 2.000;
            if (producto.Equals("Botella de jugo")) precio = 3.500;
            if (producto.Equals("Speed Max lata")) precio = 1.800;
            if (producto.Equals("Amper lata")) precio = 3.500;
            if (producto.Equals("Coca Cola lata")) precio = 3.000;
            if (producto.Equals("Coca Cola botella")) precio = 2.500;
            if (producto.Equals("Gateorade botella")) precio = 3.500;
            if (producto.Equals("Gaseosa postobon 1L")) precio = 2.800;
            if (producto.Equals("Gaseosa postobon medio litro")) precio = 3.000;
            if (producto.Equals("Coca Cola 3L")) precio = 8.000;
            if (producto.Equals("Pony Malta 1L")) precio = 3.500;
            if (producto.Equals("Pony Malta 350ml")) precio = 2.500;
            if (producto.Equals("Mr Tea")) precio = 3.000;
            if (producto.Equals("Electrolit")) precio = 3.500;

            lblPrecio.Text = precio.ToString("C");
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmRegistrar_Click(object sender, EventArgs e)
        {
            //Validando

            if (cboProducto.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto...!!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar una cantidad...!!!");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe ingresar un tipo de pago...!!!");
            else
            {
                //Capturando datos
                string producto = cboProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;

                //procesador de calculos
                double subtotal = cantidad * precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("efectivo"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double precioFinal = subtotal - descuento + recargo;

                //impresion de resultados
                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());

                lvVenta.Items.Add(fila);
                btmCancelar_Click(sender, e);
            }



        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
