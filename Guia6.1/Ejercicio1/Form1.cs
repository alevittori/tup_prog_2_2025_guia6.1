using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular departamento;
        RegistroVehiculo nuevoRegistro;

        public Form1()
        {
            InitializeComponent();

            departamento = new DepartamentoVehicular();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nom, dni, patente;
            Persona propietario;

            try
            {
                nom = tbNombre.Text;
                dni = tbDNI.Text;
                patente = tbPatente.Text.Trim();

                propietario = new Persona(dni, nom);

                departamento.RegistrarVehiculo( propietario , patente);

                tbNombre.Clear();
                tbDNI.Clear();
                tbPatente.Clear();

                

            }
            catch (FormatoPatenteNoValidaException fp)
            {
                MessageBox.Show(fp.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (RangoDniIncorrectoException re)
            {
                MessageBox.Show(re.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Ups!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            FormVer VMostrar = new FormVer();

            VMostrar.listaRegistros.DataSource = departamento.ObtenerRegistros();

            VMostrar.ShowDialog();
        }
    }
}
