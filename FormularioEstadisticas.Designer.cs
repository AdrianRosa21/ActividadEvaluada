namespace ActividadEvaluada
{
    partial class FormularioEstadisticas
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
            groupBox1 = new GroupBox();
            dgDatos = new DataGridView();
            btnCalcular = new Button();
            btnRegresar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(dgDatos);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 553);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadisticas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(19, 102);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 62;
            dgDatos.Size = new Size(923, 392);
            dgDatos.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.Location = new Point(181, 30);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(228, 44);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 12F);
            btnRegresar.Location = new Point(566, 30);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(228, 44);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FormularioEstadisticas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 588);
            Controls.Add(groupBox1);
            Name = "FormularioEstadisticas";
            Text = "FormularioEstadisticas";
            Load += FormularioEstadisticas_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgDatos;
        private Button btnCalcular;
        private Button btnRegresar;
    }
}