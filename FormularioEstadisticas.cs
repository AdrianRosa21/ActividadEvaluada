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
            cmbRegion.Text = "Norte";
            cmbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            // Configurar las columnas del DataGridView
            dgDatos.ReadOnly = true;
            dgDatos.Columns.Add("Region", "Región");
            dgDatos.Columns.Add("Mes", "Mes");
            dgDatos.Columns.Add("Temperatura", "Temperatura (°C)");
            dgDatos.Columns.Add("Precipitacion", "Precipitación (mm)");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void DeclararBotonCalcular()
        {
            btnCalcular.BackColor = Color.FromArgb(173, 216, 230); // Color pastel azul
            btnCalcular.FlatAppearance.BorderColor = Color.FromArgb(255, 150, 150);
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Limpiar DataGridView y ListBox al iniciar
            dgDatos.Rows.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            // Obtener la región seleccionada en el ComboBox
            int regionSeleccionada = cmbRegion.SelectedIndex;
            string nombreRegion = ObtenerNombreRegion(regionSeleccionada);

            // Variables para promedios
            double sumaTemperatura = 0;
            double sumaPrecipitacion = 0;
            int contadorTemperatura = 0;
            int contadorPrecipitacion = 0;

            // Lista para almacenar TODAS las temperaturas de todas las regiones
            List<Tuple<string, string, double>> temperaturas = new List<Tuple<string, string, double>>();

            //  MOSTRAR SOLO LOS 12 MESES DE LA REGIÓN SELECCIONADA 
            for (int mes = 0; mes < matrizTemperaturas.GetLength(1); mes++)
            {
                double temperatura = matrizTemperaturas[regionSeleccionada, mes];
                double precipitacion = matrizPrecipitaciones[regionSeleccionada, mes];

                // Agregar la fila al DataGridView
                int indice = dgDatos.Rows.Add(
                    nombreRegion,
                    ObtenerNombreMes(mes),
                    temperatura,
                    precipitacion
                );

                // Resaltar temperaturas mayores a 30C°
                if (temperatura > 30)
                {
                    dgDatos.Rows[indice].Cells[2].Style.BackColor = Color.Red;
                    dgDatos.Rows[indice].Cells[2].Style.ForeColor = Color.White;
                }

                // Resaltar precipitaciones mayores a 50mm
                if (precipitacion > 50)
                {
                    dgDatos.Rows[indice].Cells[3].Style.BackColor = Color.Blue;
                    dgDatos.Rows[indice].Cells[3].Style.ForeColor = Color.White;
                }

                // Acumular para promedios
                if (temperatura != 0)
                {
                    sumaTemperatura += temperatura;
                    contadorTemperatura++;
                }
                if (precipitacion != 0)
                {
                    sumaPrecipitacion += precipitacion;
                    contadorPrecipitacion++;
                }
            }

            //  LISTBOX 1 Y 2: TODAS LAS REGIONES Y MESES 
            for (int region = 0; region < matrizTemperaturas.GetLength(0); region++)
            {
                for (int mes = 0; mes < matrizTemperaturas.GetLength(1); mes++)
                {
                    double temperatura = matrizTemperaturas[region, mes];
                    string nombreReg = ObtenerNombreRegion(region);
                    string nombreMes = ObtenerNombreMes(mes);

                    temperaturas.Add(new Tuple<string, string, double>(
                        nombreReg, nombreMes, temperatura
                    ));
                }
            }

            // ORDENAR TODAS LAS TEMPERATURAS (Bubble Sort)
            for (int i = 0; i < temperaturas.Count; i++)
            {
                for (int j = i + 1; j < temperaturas.Count; j++)
                {
                    if (temperaturas[i].Item3 > temperaturas[j].Item3)
                    {
                        var temp = temperaturas[i];
                        temperaturas[i] = temperaturas[j];
                        temperaturas[j] = temp;
                    }
                }
            }

            // Llenar listBox1 (menor a mayor)
            for (int i = 0; i < temperaturas.Count; i++)
            {
                listBox1.Items.Add($"{temperaturas[i].Item1} - {temperaturas[i].Item2}: {temperaturas[i].Item3}°C");
            }

            // Llenar listBox2 (mayor a menor)
            for (int i = temperaturas.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add($"{temperaturas[i].Item1} - {temperaturas[i].Item2}: {temperaturas[i].Item3}°C");
            }

            // Calcular promedios
            double promedioTemperatura = 0;
            double promedioPrecipitacion = 0;

            if (contadorTemperatura > 0)
            {
                promedioTemperatura = sumaTemperatura / contadorTemperatura;
            }

            if (contadorPrecipitacion > 0)
            {
                promedioPrecipitacion = sumaPrecipitacion / contadorPrecipitacion;
            }

            // Mostrar promedios en listBox3
            listBox3.Items.Add($"Promedios para la región {nombreRegion}:");
            listBox3.Items.Add($"Temperatura Promedio = {promedioTemperatura:F2}°C");
            listBox3.Items.Add($"Precipitación Promedio = {promedioPrecipitacion:F2}mm");

            // Decorar ListBox
            DecorarListBox(listBox1, Color.LightBlue);
            DecorarListBox(listBox2, Color.LightCoral);
            DecorarListBox(listBox3, Color.LightGreen);
        }


        private void DecorarListBox(ListBox listBox, Color color)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.Items[i] = listBox.Items[i].ToString();
            }
            listBox.BackColor = color;
        }

        // Método para obtener el nombre de la región por el índice
        private string ObtenerNombreRegion(int indice)
        {
            string[] regiones = { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" };
            return regiones[indice];
        }
        private string ObtenerNombreMes(int mes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[mes];
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}