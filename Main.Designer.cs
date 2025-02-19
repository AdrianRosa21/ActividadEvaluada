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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            label1.Location = new Point(199, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 28);
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
            groupBox1.Location = new Point(32, 42);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(605, 311);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(365, 195);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(164, 37);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "button4";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRedirigirGraficos
            // 
            btnRedirigirGraficos.Enabled = false;
            btnRedirigirGraficos.Font = new Font("Segoe UI", 11F);
            btnRedirigirGraficos.Location = new Point(83, 195);
            btnRedirigirGraficos.Margin = new Padding(2);
            btnRedirigirGraficos.Name = "btnRedirigirGraficos";
            btnRedirigirGraficos.Size = new Size(164, 37);
            btnRedirigirGraficos.TabIndex = 2;
            btnRedirigirGraficos.Text = "button3";
            btnRedirigirGraficos.UseVisualStyleBackColor = true;
            btnRedirigirGraficos.Click += btnRedirigirGraficos_Click;
            // 
            // btnRedirigirEstadistica
            // 
            btnRedirigirEstadistica.Enabled = false;
            btnRedirigirEstadistica.Font = new Font("Segoe UI", 11F);
            btnRedirigirEstadistica.Location = new Point(365, 55);
            btnRedirigirEstadistica.Margin = new Padding(2);
            btnRedirigirEstadistica.Name = "btnRedirigirEstadistica";
            btnRedirigirEstadistica.Size = new Size(164, 37);
            btnRedirigirEstadistica.TabIndex = 1;
            btnRedirigirEstadistica.Text = "button2";
            btnRedirigirEstadistica.UseVisualStyleBackColor = true;
            btnRedirigirEstadistica.Click += btnRedirigirEstadistica_Click;
            // 
            // btnRedirigirIngresar
            // 
            btnRedirigirIngresar.Font = new Font("Segoe UI", 11F);
            btnRedirigirIngresar.Location = new Point(83, 55);
            btnRedirigirIngresar.Margin = new Padding(2);
            btnRedirigirIngresar.Name = "btnRedirigirIngresar";
            btnRedirigirIngresar.Size = new Size(164, 37);
            btnRedirigirIngresar.TabIndex = 0;
            btnRedirigirIngresar.Text = "button1";
            btnRedirigirIngresar.UseVisualStyleBackColor = true;
            btnRedirigirIngresar.Click += btnRedirigirIngresar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 364);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Main";
            Text = "Programa de Clima Multiregión";
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
