using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Automovil
{
    public partial class Form1 : Form
    {
        private Conexion conexion = new Conexion();
        
        public Form1()
        {
            InitializeComponent();
            conectar_database();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button_ingresar_Click(object sender, EventArgs e)
        {
            string matricula = textbox_matricula.Text;
            string marca = textbox_marca.Text;
            string modelo = textbox_modelo.Text;
            string color = combobox_color.Text;
            float precio = System.Convert.ToSingle(textbox_precio.Text);
            string descripcion = richtextbox_descripcion.Text;
            if (conexion.insertar_vehiculo(matricula, marca, modelo, color, precio, descripcion))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show("Error En Registro");
            }
        }

        private void conectar_database()
        {
            if (conexion.testear_conexion())
            {
                MessageBox.Show("Conexion Exitosa");
            }
            else
            {
                MessageBox.Show("Conexion Incorrecta");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'venta_vehiculosDataSet1.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.venta_vehiculosDataSet1.cliente);
            // TODO: esta línea de código carga datos en la tabla 'venta_vehiculosDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.venta_vehiculosDataSet.vehiculo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matricula = combobox_matricula.Text;
            string campo = combobox_campo.Text;
            string nuevo_valor = textbox_nuevovalor.Text;

            if (conexion.actualizar_vehiculo(matricula, campo, nuevo_valor))
            {
                MessageBox.Show("Actualizacion Exitosa");
            }
            else
            {
                MessageBox.Show("Actualizacion Erronea");
            }
        }


        
        
        
        
        
        
        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            String nit = txtNIT.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono;
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                telefono = "NULL";
            }
            else
            {
                telefono = txtTelefono.Text;
            }
            
            if (conexion.Agregar_Cliente(nit, nombre, apellido, direccion, telefono))
            {
                MessageBox.Show("Cliente agregado");
            }
            else
            {
                MessageBox.Show("error!");
            }
        }
    }
}
