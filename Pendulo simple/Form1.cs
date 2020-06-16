using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Pendulo_simple
{
    public partial class Form1 : Form
    {
        Pendulo pendulo;
        PenduloService penduloService = new PenduloService();
        public Form1()
        {
            InitializeComponent();
        }


        private void generarPendulo()
        {
            try
            {
                pendulo = new Pendulo();
                pendulo.Longitud = Convert.ToDouble(TxtLongitud.Text.Trim());
                pendulo.masa = Convert.ToDouble(txtMasa.Text.Trim());
                pendulo.oscilaciones = Convert.ToDouble(txtOscilaciones.Text.Trim());
                pendulo.tiempo = Convert.ToDouble(txtTiempo.Text.Trim());
                pendulo.Email = txtEmail.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos son incorrectos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generarPendulo();
            txtFrecuencia.Text = Convert.ToString(penduloService.calcularFrecuencia(pendulo));
            txtGravedad.Text = Convert.ToString(penduloService.calcularGravedad(pendulo));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generarPendulo();
            txtFrecuencia.Text = Convert.ToString(penduloService.calcularFrecuencia(pendulo));
            txtGravedad.Text = Convert.ToString(penduloService.calcularGravedad(pendulo));
            try
            {
                penduloService.Guardar(pendulo);
                MessageBox.Show("Prueba realizada exitosamente", "Prueba exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar esta prueba ", "Prueba incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);  
            }

        }
    }
}
