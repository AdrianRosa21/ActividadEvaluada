namespace ActividadEvaluada
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnRedirigirGraficos = new Button();
            btnRedirigirEstadistica = new Button();
            btnRedirigirIngresar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(210, 15);
            label1.Name = "label1";
            label1.Size = new Size(433, 41);
            label1.TabIndex = 0;
            label1.Text = "Programa de Clima Multiregión";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnRedirigirGraficos);
            groupBox1.Controls.Add(btnRedirigirEstadistica);
            groupBox1.Controls.Add(btnRedirigirIngresar);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(46, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(434, 202);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(217, 48);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "button4";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRedirigirGraficos
            // 
            btnRedirigirGraficos.Enabled = false;
            btnRedirigirGraficos.Font = new Font("Segoe UI", 11F);
            btnRedirigirGraficos.Location = new Point(101, 202);
            btnRedirigirGraficos.Name = "btnRedirigirGraficos";
            btnRedirigirGraficos.Size = new Size(217, 48);
            btnRedirigirGraficos.TabIndex = 2;
            btnRedirigirGraficos.Text = "button3";
            btnRedirigirGraficos.UseVisualStyleBackColor = true;
            // 
            // btnRedirigirEstadistica
            // 
            btnRedirigirEstadistica.Enabled = false;
            btnRedirigirEstadistica.Font = new Font("Segoe UI", 11F);
            btnRedirigirEstadistica.Location = new Point(434, 73);
            btnRedirigirEstadistica.Name = "btnRedirigirEstadistica";
            btnRedirigirEstadistica.Size = new Size(217, 48);
            btnRedirigirEstadistica.TabIndex = 1;
            btnRedirigirEstadistica.Text = "button2";
            btnRedirigirEstadistica.UseVisualStyleBackColor = true;
            btnRedirigirEstadistica.Click += btnRedirigirEstadistica_Click;
            // 
            // btnRedirigirIngresar
            // 
            btnRedirigirIngresar.Font = new Font("Segoe UI", 11F);
            btnRedirigirIngresar.Location = new Point(101, 73);
            btnRedirigirIngresar.Name = "btnRedirigirIngresar";
            btnRedirigirIngresar.Size = new Size(217, 48);
            btnRedirigirIngresar.TabIndex = 0;
            btnRedirigirIngresar.Text = "button1";
            btnRedirigirIngresar.UseVisualStyleBackColor = true;
            btnRedirigirIngresar.Click += btnRedirigirIngresar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            Activated += Main_Activated;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnRedirigirIngresar;
        private Button btnRedirigirEstadistica;
        private Button btnRedirigirGraficos;
        private Button btnSalir;
    }
}
