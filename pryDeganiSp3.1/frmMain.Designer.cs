namespace pryDeganiSp3._1
{
    partial class frmMain
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNumTurno = new TextBox();
            txtDominio = new TextBox();
            txtTitular = new TextBox();
            numAnioFabricacion = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCantidadTurnos = new TextBox();
            txtAnioAntiguo = new TextBox();
            txtCantidadCaracter = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            btnConsultar = new Button();
            grpRegistro = new GroupBox();
            grpEstadisticas = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numAnioFabricacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de Turno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 69);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Dominio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 102);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Año Fabricacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 135);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Titulo";
            // 
            // txtNumTurno
            // 
            txtNumTurno.Location = new Point(178, 33);
            txtNumTurno.MaxLength = 5;
            txtNumTurno.Name = "txtNumTurno";
            txtNumTurno.Size = new Size(72, 27);
            txtNumTurno.TabIndex = 4;
            txtNumTurno.KeyPress += txtNumTurno_KeyPress;
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(178, 66);
            txtDominio.MaxLength = 7;
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(125, 27);
            txtDominio.TabIndex = 5;
            txtDominio.KeyPress += txtDominio_KeyPress;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(178, 132);
            txtTitular.MaxLength = 30;
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(301, 27);
            txtTitular.TabIndex = 6;
            // 
            // numAnioFabricacion
            // 
            numAnioFabricacion.Location = new Point(178, 99);
            numAnioFabricacion.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numAnioFabricacion.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numAnioFabricacion.Name = "numAnioFabricacion";
            numAnioFabricacion.Size = new Size(84, 27);
            numAnioFabricacion.TabIndex = 7;
            numAnioFabricacion.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 228);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 8;
            label5.Text = "Cantidad de Turnos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 263);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 9;
            label6.Text = "Año del mas antiguo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 298);
            label7.Name = "label7";
            label7.Size = new Size(188, 20);
            label7.TabIndex = 10;
            label7.Text = "Dominios con 6 caracteres ";
            // 
            // txtCantidadTurnos
            // 
            txtCantidadTurnos.Location = new Point(228, 225);
            txtCantidadTurnos.Name = "txtCantidadTurnos";
            txtCantidadTurnos.ReadOnly = true;
            txtCantidadTurnos.Size = new Size(106, 27);
            txtCantidadTurnos.TabIndex = 11;
            // 
            // txtAnioAntiguo
            // 
            txtAnioAntiguo.Location = new Point(228, 260);
            txtAnioAntiguo.Name = "txtAnioAntiguo";
            txtAnioAntiguo.ReadOnly = true;
            txtAnioAntiguo.Size = new Size(106, 27);
            txtAnioAntiguo.TabIndex = 12;
            // 
            // txtCantidadCaracter
            // 
            txtCantidadCaracter.Location = new Point(228, 295);
            txtCantidadCaracter.Name = "txtCantidadCaracter";
            txtCantidadCaracter.ReadOnly = true;
            txtCantidadCaracter.Size = new Size(106, 27);
            txtCantidadCaracter.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.IndianRed;
            btnRegistrar.Location = new Point(506, 33);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(115, 43);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.Location = new Point(506, 90);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 43);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.IndianRed;
            btnConsultar.Location = new Point(506, 217);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 43);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // grpRegistro
            // 
            grpRegistro.Location = new Point(12, 12);
            grpRegistro.Name = "grpRegistro";
            grpRegistro.Size = new Size(478, 174);
            grpRegistro.TabIndex = 17;
            grpRegistro.TabStop = false;
            grpRegistro.Text = "Registro";
            // 
            // grpEstadisticas
            // 
            grpEstadisticas.Location = new Point(12, 202);
            grpEstadisticas.Name = "grpEstadisticas";
            grpEstadisticas.Size = new Size(478, 146);
            grpEstadisticas.TabIndex = 18;
            grpEstadisticas.TabStop = false;
            grpEstadisticas.Text = "Estadisticas";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 368);
            Controls.Add(btnConsultar);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCantidadCaracter);
            Controls.Add(txtAnioAntiguo);
            Controls.Add(txtCantidadTurnos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numAnioFabricacion);
            Controls.Add(txtTitular);
            Controls.Add(txtDominio);
            Controls.Add(txtNumTurno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grpRegistro);
            Controls.Add(grpEstadisticas);
            Name = "frmMain";
            Text = "Auto Test";
            ((System.ComponentModel.ISupportInitialize)numAnioFabricacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumTurno;
        private TextBox txtDominio;
        private TextBox txtTitular;
        private NumericUpDown numAnioFabricacion;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCantidadTurnos;
        private TextBox txtAnioAntiguo;
        private TextBox txtCantidadCaracter;
        private Button btnRegistrar;
        private Button btnSalir;
        private Button btnConsultar;
        private GroupBox grpRegistro;
        private GroupBox grpEstadisticas;
    }
}
