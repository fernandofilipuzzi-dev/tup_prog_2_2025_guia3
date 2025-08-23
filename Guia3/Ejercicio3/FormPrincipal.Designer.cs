namespace Ejercicio3
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnAltaEnvio = new Button();
            btnListarEnvios = new Button();
            tbEnviosDetalles = new TextBox();
            SuspendLayout();
            // 
            // btnAltaEnvio
            // 
            btnAltaEnvio.Location = new Point(356, 14);
            btnAltaEnvio.Margin = new Padding(4, 5, 4, 5);
            btnAltaEnvio.Name = "btnAltaEnvio";
            btnAltaEnvio.Size = new Size(138, 49);
            btnAltaEnvio.TabIndex = 0;
            btnAltaEnvio.Text = "Alta Envio(1)";
            btnAltaEnvio.UseVisualStyleBackColor = true;
            btnAltaEnvio.Click += btnAltaEnvio_Click;
            // 
            // btnListarEnvios
            // 
            btnListarEnvios.Location = new Point(356, 73);
            btnListarEnvios.Margin = new Padding(4, 5, 4, 5);
            btnListarEnvios.Name = "btnListarEnvios";
            btnListarEnvios.Size = new Size(138, 49);
            btnListarEnvios.TabIndex = 1;
            btnListarEnvios.Text = "Listar Envíos (2)";
            btnListarEnvios.UseVisualStyleBackColor = true;
            btnListarEnvios.Click += btnListarEnvios_Click;
            // 
            // tbEnviosDetalles
            // 
            tbEnviosDetalles.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEnviosDetalles.Location = new Point(14, 14);
            tbEnviosDetalles.Multiline = true;
            tbEnviosDetalles.Name = "tbEnviosDetalles";
            tbEnviosDetalles.ScrollBars = ScrollBars.Vertical;
            tbEnviosDetalles.Size = new Size(335, 140);
            tbEnviosDetalles.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 163);
            Controls.Add(tbEnviosDetalles);
            Controls.Add(btnListarEnvios);
            Controls.Add(btnAltaEnvio);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEnvio;
        private System.Windows.Forms.Button btnListarEnvios;
        private System.Windows.Forms.TextBox tbEnviosDetalles;
    }
}

