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
            chartTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cmbRegiones = new ComboBox();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)chartTemperatura).BeginInit();
            SuspendLayout();
            // 
            // chartTemperatura
            // 
            chartArea1.Name = "ChartArea1";
            chartTemperatura.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTemperatura.Legends.Add(legend1);
            chartTemperatura.Location = new Point(22, 73);
            chartTemperatura.Margin = new Padding(4, 5, 4, 5);
            chartTemperatura.Name = "chartTemperatura";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTemperatura.Series.Add(series1);
            chartTemperatura.Size = new Size(607, 539);
            chartTemperatura.TabIndex = 0;
            chartTemperatura.Text = "chart1";
            chartTemperatura.Click += chart1_Click;
            // 
            // cmbRegiones
            // 
            cmbRegiones.FormattingEnabled = true;
            cmbRegiones.Items.AddRange(new object[] { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" });
            cmbRegiones.Location = new Point(373, 21);
            cmbRegiones.Margin = new Padding(4, 5, 4, 5);
            cmbRegiones.Name = "cmbRegiones";
            cmbRegiones.Size = new Size(378, 33);
            cmbRegiones.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.Location = new Point(792, 13);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(229, 43);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormularioDeGraficos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 626);
            Controls.Add(btnCalcular);
            Controls.Add(cmbRegiones);
            Controls.Add(chartTemperatura);
            Name = "FormularioDeGraficos";
            Text = "FormularioDeGraficos";
            Load += FormularioDeGraficos_Load;
            ((System.ComponentModel.ISupportInitialize)chartTemperatura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatura;
        private ComboBox cmbRegiones;
        private Button btnCalcular;
    }
}