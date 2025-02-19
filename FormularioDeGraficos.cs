using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ActividadEvaluada
{
    public partial class FormularioDeGraficos : Form
    {

        private double[,] matrizTemperaturas;
        private double[,] matrizPrecipitaciones;
       
        public FormularioDeGraficos(double[,] matrizTemperaturas, double[,] matrizPrecipitaciones)
        {
            InitializeComponent();
            this.matrizPrecipitaciones = matrizPrecipitaciones;
            this.matrizTemperaturas = matrizTemperaturas;
            
            ConfigurarComboBox();
        }

        private void FormularioDeGraficos_Load(object sender, EventArgs e)
        {

        }
        private void ConfigurarComboBox()
        {
           
            cmbRegiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegiones.Location = new System.Drawing.Point(10, 10);
            cmbRegiones.Width = 200;

            // Agregar opciones al ComboBox (regiones)
            string[] regiones = { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" };
            cmbRegiones.Items.AddRange(regiones);

            // Asignar evento cuando se selecciona una región
            cmbRegiones.SelectedIndexChanged += new EventHandler(cmbRegiones_SelectedIndexChanged);

            // Agregar el ComboBox al formulario
            this.Controls.Add(cmbRegiones);
        }


        private void cmbRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Esto pedirle ayuda a la seño porque estoy bien perdido
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
