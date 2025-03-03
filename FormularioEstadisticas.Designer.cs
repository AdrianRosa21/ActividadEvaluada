﻿namespace ActividadEvaluada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEstadisticas));
            dgDatos = new DataGridView();
            btnCalcular = new Button();
            btnRegresar = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            cmbRegion = new ComboBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            listBox3 = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(19, 55);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 62;
            dgDatos.Size = new Size(706, 392);
            dgDatos.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.Location = new Point(957, 465);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(229, 65);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 12F);
            btnRegresar.Location = new Point(1244, 464);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(229, 65);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(743, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 388);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(1014, 58);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(253, 388);
            listBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(1014, 28);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 5;
            label1.Text = "Regiones más calurosas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(743, 28);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 6;
            label2.Text = "Regiones más frías";
            // 
            // cmbRegion
            // 
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Items.AddRange(new object[] { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" });
            cmbRegion.Location = new Point(484, 475);
            cmbRegion.Margin = new Padding(4, 5, 4, 5);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(431, 40);
            cmbRegion.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(cmbRegion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(dgDatos);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1794, 553);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadisticas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 480);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 9;
            label3.Text = "Región geográfica";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(1277, 182);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(515, 132);
            listBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(1273, 151);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 10;
            label4.Text = "Promedios";
            // 
            // FormularioEstadisticas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1826, 588);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioEstadisticas";
            Text = "Estadisticas";
            Load += FormularioEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgDatos;
        private Button btnCalcular;
        private Button btnRegresar;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private ComboBox cmbRegion;
        private GroupBox groupBox1;
        private ListBox listBox3;
        private Label label3;
        private Label label4;
    }
}