﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ActividadEvaluada
{
    public partial class FormularioEntradaDatos : Form
    {
        private double[,] matrizTemperaturas;
        private double[,] matrizPrecipitaciones;
        public FormularioEntradaDatos(double[,] matrizTemperaturas, double[,] matrizPrecipitaciones)
        {
            InitializeComponent();
            
            this.matrizPrecipitaciones = matrizPrecipitaciones;
            this.matrizTemperaturas = matrizTemperaturas;
        }
        private void DeclararBotonSalir()
        {
            btnRegresar.BackColor = Color.FromArgb(255, 204, 204); // Color pastel para
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.FlatAppearance.BorderColor = Color.FromArgb(255, 150, 150);
            btnRegresar.FlatAppearance.BorderSize = 2;
            btnRegresar.ForeColor = Color.Black;
        }
        private void DeclararBotonCalcular()
        {

            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(255, 150, 150);
            btnGuardar.BackColor = Color.FromArgb(189, 236, 182); // Color pastel azul
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;


        }
        private void FormularioEntradaDatos_Load(object sender, EventArgs e)
        {
            DeclararBotonSalir();
            DeclararBotonCalcular();
            cmbRegion.Text = "Norte";//10 regiones
            cmbRegion.DropDownStyle = ComboBoxStyle.DropDownList;//Esto hace que el usuario escriba o borre texto manualmente
            cmbMeses.Text = "Enero";//12 meses
            cmbMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTemperatura.PlaceholderText = "Ingrese la temperatura";
            txtPrecipitacion.PlaceholderText = "Indique la precipitación";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener índices seleccionados
            int indiceRegion = cmbRegion.SelectedIndex;
            int indiceMes = cmbMeses.SelectedIndex;
            
            // Validar que se hayan seleccionado región y mes
            if (indiceRegion == -1 || indiceMes == -1)
            {
                MessageBox.Show("Seleccione una región y un mes.");
                return;
            }
            /*en orden son 
             1   Norte
             2   Sur
             3   Este
             4  Oeste
             5  Centro
             6  Costa
             7  Montaña
             8   Selva
             9   Desierto
             10  Valle
             */

            
            if (!double.TryParse(txtTemperatura.Text, out double temperatura))
            {
                MessageBox.Show("Ingrese una temperatura válida.","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            // Validar que la precipitación sea un número valida si no se puede convertir 
            if (!double.TryParse(txtPrecipitacion.Text, out double precipitacion))
            {
                MessageBox.Show("Ingrese una precipitacion válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validar que la precitipacion no sea menos a 0
            if (precipitacion < 0)
            {
                MessageBox.Show("Ingrese una precipitacion valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si ya existe
            if (matrizTemperaturas[indiceRegion, indiceMes] != 0 || matrizPrecipitaciones[indiceRegion, indiceMes] != 0)
            {
                MessageBox.Show("No se pueden sobrescribir los datos. Ya existen datos en esta posición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            matrizPrecipitaciones[indiceRegion,indiceMes] = precipitacion;
            // Guardar en la matriz
            matrizTemperaturas[indiceRegion, indiceMes] = temperatura;

            MessageBox.Show("Datos guardados correctamente.", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
