namespace ActividadEvaluada
{
    partial class FormularioDeGraficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDeGraficos));
            label1 = new Label();
            cmbRegiones = new ComboBox();
            btnRegresar = new Button();
            chartTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            logo = new PictureBox();
            btnCalcular = new Button();
            chartPrecipitaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartTemperatura).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPrecipitaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 31);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 0;
            label1.Text = "Región geográfica";
            // 
            // cmbRegiones
            // 
            cmbRegiones.FormattingEnabled = true;
            cmbRegiones.Items.AddRange(new object[] { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" });
            cmbRegiones.Location = new Point(437, 31);
            cmbRegiones.Name = "cmbRegiones";
            cmbRegiones.Size = new Size(303, 29);
            cmbRegiones.TabIndex = 1;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(1001, 22);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(160, 39);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // chartTemperatura
            // 
            chartArea1.Name = "ChartArea1";
            chartTemperatura.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTemperatura.Legends.Add(legend1);
            chartTemperatura.Location = new Point(20, 83);
            chartTemperatura.Name = "chartTemperatura";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTemperatura.Series.Add(series1);
            chartTemperatura.Size = new Size(617, 379);
            chartTemperatura.TabIndex = 0;
            chartTemperatura.Text = "chart1";
            chartTemperatura.Click += chart1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(logo);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(chartPrecipitaciones);
            groupBox1.Controls.Add(chartTemperatura);
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(cmbRegiones);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1273, 486);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graficos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // logo
            // 
            logo.Location = new Point(20, 22);
            logo.Name = "logo";
            logo.Size = new Size(65, 55);
            logo.TabIndex = 9;
            logo.TabStop = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.Location = new Point(794, 25);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(160, 39);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // chartPrecipitaciones
            // 
            chartArea2.Name = "ChartArea1";
            chartPrecipitaciones.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPrecipitaciones.Legends.Add(legend2);
            chartPrecipitaciones.Location = new Point(643, 83);
            chartPrecipitaciones.Name = "chartPrecipitaciones";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPrecipitaciones.Series.Add(series2);
            chartPrecipitaciones.Size = new Size(617, 379);
            chartPrecipitaciones.TabIndex = 7;
            chartPrecipitaciones.Text = "chart1";
            // 
            // FormularioDeGraficos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 512);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormularioDeGraficos";
            Text = "Graficos";
            Load += FormularioDeGraficos_Load;
            ((System.ComponentModel.ISupportInitialize)chartTemperatura).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPrecipitaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cmbRegiones;
        private Button btnRegresar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatura;
        private GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrecipitaciones;
        private Button btnCalcular;
        private PictureBox logo;
    }
}