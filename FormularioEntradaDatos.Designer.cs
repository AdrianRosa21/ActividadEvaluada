namespace ActividadEvaluada
{
    partial class FormularioEntradaDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEntradaDatos));
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtPrecipitacion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnGuardar = new Button();
            btnRegresar = new Button();
            label4 = new Label();
            txtTemperatura = new TextBox();
            cmbMeses = new ComboBox();
            label2 = new Label();
            cmbRegion = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPrecipitacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTemperatura);
            groupBox1.Controls.Add(cmbMeses);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbRegion);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(40, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de datos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(380, 250);
            label7.Name = "label7";
            label7.Size = new Size(146, 13);
            label7.TabIndex = 11;
            label7.Text = "(Ingrese un dato numerico)";
            // 
            // txtPrecipitacion
            // 
            txtPrecipitacion.Location = new Point(301, 218);
            txtPrecipitacion.Name = "txtPrecipitacion";
            txtPrecipitacion.Size = new Size(303, 29);
            txtPrecipitacion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 222);
            label6.Name = "label6";
            label6.Size = new Size(199, 21);
            label6.TabIndex = 9;
            label6.Text = "Posibilidad de precipitación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(313, 177);
            label5.Name = "label5";
            label5.Size = new Size(280, 13);
            label5.TabIndex = 8;
            label5.Text = "(La temperatura ingresada es requerida en grados C°)";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(204, 298);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 35);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(469, 298);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 35);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 149);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 5;
            label4.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(301, 145);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(303, 29);
            txtTemperatura.TabIndex = 4;
            txtTemperatura.TextChanged += txtTemperatura_TextChanged;
            // 
            // cmbMeses
            // 
            cmbMeses.FormattingEnabled = true;
            cmbMeses.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cmbMeses.Location = new Point(301, 86);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(303, 29);
            cmbMeses.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 2;
            label2.Text = "Meses";
            // 
            // cmbRegion
            // 
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Items.AddRange(new object[] { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" });
            cmbRegion.Location = new Point(301, 36);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(303, 29);
            cmbRegion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 41);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 0;
            label1.Text = "Región geográfica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(191, 26);
            label3.Name = "label3";
            label3.Size = new Size(421, 21);
            label3.TabIndex = 1;
            label3.Text = "Porfavor rellene la información con los datos que se le pide.";
            // 
            // FormularioEntradaDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioEntradaDatos";
            Text = "Ingreso de datos";
            Load += FormularioEntradaDatos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbRegion;
        private ComboBox cmbMeses;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTemperatura;
        private Button btnGuardar;
        private Button btnRegresar;
        private Label label5;
        private Label label6;
        private TextBox txtPrecipitacion;
        private Label label7;
    }
}