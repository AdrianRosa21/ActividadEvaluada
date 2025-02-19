using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadEvaluada
{
    public partial class FormularioEstadisticas : Form
    {
        private double[,] matrizTemperaturas;
        private double[,] matrizPrecipitaciones;
        public FormularioEstadisticas(double[,] matrizTemperaturas, double[,] matrizPrecipitaciones)
        {
            InitializeComponent();
            this.matrizPrecipitaciones = matrizPrecipitaciones;
            this.matrizTemperaturas = matrizTemperaturas;
        }

        private void FormularioEstadisticas_Load(object sender, EventArgs e)
        {
            DeclararBotonSalir();
            DeclararBotonCalcular();
            // Configurar las columnas del DataGridView
            dgDatos.ReadOnly = true;
            dgDatos.Columns.Add("Region", "Región");
            dgDatos.Columns.Add("Mes", "Mes");
            dgDatos.Columns.Add("Temperatura", "Temperatura (°C)");
            dgDatos.Columns.Add("Precipitacion", "Precipitación (mm)");
        }
        private void DeclararBotonCalcular()
        {
            
           
            btnCalcular.BackColor = Color.FromArgb(173, 216, 230); // Color pastel azul
            btnRegresar.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 112);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.FlatAppearance.BorderSize = 0;
           

        }
        private void DeclararBotonSalir()
        {
            btnRegresar.BackColor = Color.FromArgb(255, 204, 204); // Color pastel para
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.FlatAppearance.BorderColor = Color.FromArgb(255, 150, 150);
            btnRegresar.FlatAppearance.BorderSize = 2;
            btnRegresar.ForeColor = Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            dgDatos.Rows.Clear();
            // Recorrer las matrices y agregar los datos al dgDatos
            for (int region = 0; region < matrizTemperaturas.GetLength(0); region++)
            {
                for (int mes = 0; mes < matrizTemperaturas.GetLength(1); mes++)
                {
                    // Obtener los valores de las matrices
                    double temperatura = matrizTemperaturas[region, mes];
                    double precipitacion = matrizPrecipitaciones[region, mes];

                    // Agregar una fila al DataGridView y sacar un
                    int indice = dgDatos.Rows.Add(
                    ObtenerNombreRegion(region),
                    ObtenerNombreMes(mes),
                    temperatura,
                    precipitacion
                    );

                    if (temperatura > 30)
                    {
                        dgDatos.Rows[indice].Cells["Temperatura"].Style.BackColor = Color.Red;
                        dgDatos.Rows[indice].Cells["Temperatura"].Style.ForeColor = Color.White;
                    }
                    

                    
                    if (precipitacion > 50)
                    {
                        dgDatos.Rows[indice].Cells["Precipitacion"].Style.BackColor = Color.Blue;
                        dgDatos.Rows[indice].Cells["Precipitacion"].Style.ForeColor = Color.White;
                    }
                }
            }
        }
            

        // Metodo para obtener el nombre de la region por el indice osea el numero 
        private string ObtenerNombreRegion(int indice)
        {
            string[] regiones = { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" };
            return regiones[indice];//este es el indice de matriz
        }

        // Método para obtener el nombre del mes según el índice
        private string ObtenerNombreMes(int indice)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[indice];
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

