namespace Lab03
{
    partial class Form1
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
            txtServidor = new TextBox();
            label2 = new Label();
            txtBaseDatos = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            chkAutenticacion = new CheckBox();
            btnEstado = new Button();
            btnDesconectar = new Button();
            txtPassword = new TextBox();
            btnConectar = new Button();
            btnPersonas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            label1.Click += label1_Click;
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(24, 40);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(153, 23);
            txtServidor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 100);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Base de Datos";
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(24, 118);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(153, 23);
            txtBaseDatos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 22);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(260, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(140, 23);
            txtUsuario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 100);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // chkAutenticacion
            // 
            chkAutenticacion.AutoSize = true;
            chkAutenticacion.Checked = true;
            chkAutenticacion.CheckState = CheckState.Checked;
            chkAutenticacion.Location = new Point(24, 165);
            chkAutenticacion.Name = "chkAutenticacion";
            chkAutenticacion.Size = new Size(153, 19);
            chkAutenticacion.TabIndex = 8;
            chkAutenticacion.Text = "Autenticación Integrada";
            chkAutenticacion.UseVisualStyleBackColor = true;
            chkAutenticacion.CheckedChanged += chkAutenticacion_CheckedChanged;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(175, 204);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(75, 23);
            btnEstado.TabIndex = 10;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Enabled = false;
            btnDesconectar.Location = new Point(285, 204);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(75, 23);
            btnDesconectar.TabIndex = 11;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(260, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(140, 23);
            txtPassword.TabIndex = 12;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(63, 204);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 13;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(175, 247);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(75, 23);
            btnPersonas.TabIndex = 14;
            btnPersonas.Text = "Personas";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.TextChanged += Personas;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 302);
            Controls.Add(btnPersonas);
            Controls.Add(btnConectar);
            Controls.Add(txtPassword);
            Controls.Add(btnDesconectar);
            Controls.Add(btnEstado);
            Controls.Add(chkAutenticacion);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(txtBaseDatos);
            Controls.Add(label2);
            Controls.Add(txtServidor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServidor;
        private Label label2;
        private TextBox txtBaseDatos;
        private Label label3;
        private TextBox txtUsuario;
        private Label label4;
        private CheckBox chkAutenticacion;
        private Button btnEstado;
        private Button btnDesconectar;
        private TextBox txtPassword;
        private Button btnConectar;
        private Button btnPersonas;
    }
}