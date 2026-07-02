namespace SistemaAlquilerAutos
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
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            btnGuardar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(519, 76);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(301, 195);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Cliente";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(246, 270);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(240, 150);
            dgvClientes.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(btnGuardar);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Button btnGuardar;
        private DataGridView dgvClientes;
    }
}
