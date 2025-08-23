namespace Ejercicio1
{
    partial class FormPrincipal
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
            btnAgregarFigura = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            tbAlto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbLargo = new TextBox();
            tbAncho = new TextBox();
            tbRadio = new TextBox();
            lsbTipoFigura = new ListBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            btnQuitar = new Button();
            lsbListadoCreado = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarFigura
            // 
            btnAgregarFigura.Location = new Point(562, 71);
            btnAgregarFigura.Margin = new Padding(4);
            btnAgregarFigura.Name = "btnAgregarFigura";
            btnAgregarFigura.Size = new Size(120, 66);
            btnAgregarFigura.TabIndex = 4;
            btnAgregarFigura.Text = "Agregar Figura";
            btnAgregarFigura.UseVisualStyleBackColor = true;
            btnAgregarFigura.Click += btnAgregarFigura_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbLargo);
            groupBox1.Controls.Add(btnAgregarFigura);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(lsbTipoFigura);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 165);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Creación de la figura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 36);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 9;
            label5.Text = "Elija el tipo de Figura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 111);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 8;
            label4.Text = "Alto";
            // 
            // tbAlto
            // 
            tbAlto.Enabled = false;
            tbAlto.Location = new Point(257, 108);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(100, 29);
            tbAlto.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 111);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 6;
            label3.Text = "Largo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 69);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 5;
            label2.Text = "Ancho";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 69);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 4;
            label1.Text = "Radio";
            // 
            // tbLargo
            // 
            tbLargo.Enabled = false;
            tbLargo.Location = new Point(450, 108);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(100, 29);
            tbLargo.TabIndex = 3;
            // 
            // tbAncho
            // 
            tbAncho.Enabled = false;
            tbAncho.Location = new Point(450, 66);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 29);
            tbAncho.TabIndex = 2;
            // 
            // tbRadio
            // 
            tbRadio.Enabled = false;
            tbRadio.Location = new Point(257, 66);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 29);
            tbRadio.TabIndex = 1;
            // 
            // lsbTipoFigura
            // 
            lsbTipoFigura.FormattingEnabled = true;
            lsbTipoFigura.ItemHeight = 21;
            lsbTipoFigura.Items.AddRange(new object[] { "Circulo", "Rectangulo", "Esfera", "Cilindro" });
            lsbTipoFigura.Location = new Point(35, 66);
            lsbTipoFigura.Name = "lsbTipoFigura";
            lsbTipoFigura.Size = new Size(146, 88);
            lsbTipoFigura.TabIndex = 0;
            lsbTipoFigura.SelectedIndexChanged += lbxTipoFigura_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnQuitar);
            groupBox2.Controls.Add(lsbListadoCreado);
            groupBox2.Location = new Point(7, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(698, 171);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Figuras Creadas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 32);
            label6.Name = "label6";
            label6.Size = new Size(210, 21);
            label6.TabIndex = 12;
            label6.Text = "Elija la Figura para eliminarla";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(562, 81);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(120, 67);
            btnQuitar.TabIndex = 11;
            btnQuitar.Text = "Quitar Figura";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // lsbListadoCreado
            // 
            lsbListadoCreado.FormattingEnabled = true;
            lsbListadoCreado.ItemHeight = 21;
            lsbListadoCreado.Location = new Point(35, 56);
            lsbListadoCreado.Name = "lsbListadoCreado";
            lsbListadoCreado.Size = new Size(515, 109);
            lsbListadoCreado.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 359);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregarFigura;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbLargo;
        private TextBox tbAncho;
        private TextBox tbRadio;
        private ListBox lsbTipoFigura;
        private GroupBox groupBox2;
        private Button btnQuitar;
        private ListBox lsbListadoCreado;
        private Label label4;
        private TextBox tbAlto;
        private Label label5;
        private Label label6;
    }
}
