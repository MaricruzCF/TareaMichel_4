using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaMichel_4
{
    public partial class Form1 : Form
    {
        Catalogo catalago;
        public Form1()
        {
            InitializeComponent();
            catalago = new Catalogo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            int costo = int.Parse(txtCosto.Text);
            Productos producto = new Productos(codigo, txtNombre.Text, txtDescripcion.Text, cantidad, costo);

            catalago.Agregar(producto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            catalago.Buscar(codigo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            catalago.Eliminar(codigo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            catalago.ToString();
        }
    }
}
