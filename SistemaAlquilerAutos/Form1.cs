using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAlquilerAutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación: Evita guardar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
                return;
            }

            using (var db = new AppDbContext())
            {
                var nuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Documento = txtDocumento.Text
                };
                db.Clientes.Add(nuevoCliente);
                db.SaveChanges();
            }

            CargarClientes(); // Refresca la tabla
            txtNombre.Clear();
            txtDocumento.Clear();
        }

        private void CargarClientes()
        {
            using (var db = new AppDbContext())
            {
                dgvClientes.DataSource = db.Clientes.ToList();
            }
        }
    }
}