﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.BaseDeDatos.LopezV
{
    public partial class frmEliminarEntrenador : Form
    {
        public frmEliminarEntrenador()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clsEntrenador BuscarEntrenador = new clsEntrenador();
            BuscarEntrenador.Buscar(txtCodigoEntrBuscado.Text);
            if (BuscarEntrenador.CodigoEntrenador != txtCodigoEntrBuscado.Text)
            {
                MessageBox.Show("El codigo no fue encontrado");
            }
            else
            {
                txtCodigoEntrenador.Text = BuscarEntrenador.CodigoEntrenador;
                txtNombre.Text = BuscarEntrenador.NombreEntrenador;
                txtApellido.Text = BuscarEntrenador.ApellidoEntrenador;
                txtDireccion.Text = BuscarEntrenador.DireccionEntrenador;
                lstDeporte.Text = Convert.ToString(BuscarEntrenador.DeporteEntrenador);
                lstProvincia.Text = Convert.ToString(BuscarEntrenador.ProvinciaEntrenador);

            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            
            string CodigoEntrenador = txtCodigoEntrBuscado.Text;
            //Creo el objeto de la clase 
            clsEntrenador EliminarEntr = new clsEntrenador();
            //llamo a la clase que tiene el procedimiento Eliminar
            EliminarEntr.Eliminar(CodigoEntrenador);

            //Limpiar cajas de texto
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCodigoEntrBuscado.Text = "";
            txtCodigoEntrenador.Text = "";
            lstDeporte.SelectedIndex = -1;
            lstProvincia.SelectedIndex = -1;

        }
    }
}
