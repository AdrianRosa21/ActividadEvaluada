using System;
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
        public FormularioEntradaDatos(double[,] matrizTemperaturas)
        {
            InitializeComponent();
            this.matrizTemperaturas = matrizTemperaturas;//Se declara porque viene de otro form
        }

        private void FormularioEntradaDatos_Load(object sender, EventArgs e)
        {
            cmbRegion.Text = "Norte";//10 regiones
            cmbRegion.DropDownStyle = ComboBoxStyle.DropDownList;//Esto hace que el usuario escriba o borre texto manualmente
            cmbMeses.Text = "Enero";//12 meses
            cmbMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTemperatura.PlaceholderText = "Ingrese la temperatura";//Esto hace que se coloque sobre el texto como en html

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener índices seleccionados
            int indiceRegion = cmbRegion.SelectedIndex;
            int indiceMes = cmbMeses.SelectedIndex;

            // Validar que se hayan seleccionado región y mes
            if ((indiceRegion == -1 || indiceMes == -1) || (indiceRegion>10 || indiceMes>12) )
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

            // Validar que la temperatura sea un número
            if (!double.TryParse(txtTemperatura.Text, out double temperatura))
            {
                MessageBox.Show("Ingrese una temperatura válida.");
                return;
            }

            // Guardar en la matriz
            matrizTemperaturas[indiceRegion, indiceMes] = temperatura;

            MessageBox.Show("Datos guardados correctamente.", "Aprobado",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
