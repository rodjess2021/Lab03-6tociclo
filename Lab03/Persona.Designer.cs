namespace Lab03
{
    partial class Persona
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
            btnListar = new Button();
            btnBuscar = new Button();
            txtNombre = new TextBox();
            dgvListado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 24);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(327, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 23);
            txtNombre.TabIndex = 2;
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(12, 72);
            dgvListado.Name = "dgvListado";
            dgvListado.RowTemplate.Height = 25;
            dgvListado.Size = new Size(390, 308);
            dgvListado.TabIndex = 3;
            // 
            // Persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 392);
            Controls.Add(dgvListado);
            Controls.Add(txtNombre);
            Controls.Add(btnBuscar);
            Controls.Add(btnListar);
            Name = "Persona";
            Text = "Persona";
            Load += Persona_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private Button btnBuscar;
        private TextBox txtNombre;
        private DataGridView dgvListado;
    }
}