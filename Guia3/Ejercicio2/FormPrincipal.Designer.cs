namespace Ejercicio2
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
            tbDescripcion = new TextBox();
            btnDescribir = new Button();
            lsbTiposMotivoBordado = new ListBox();
            lsbSeleccionados = new ListBox();
            groupBox1 = new GroupBox();
            btnReiniciar = new Button();
            btnIniciarMaquina = new Button();
            label2 = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tbDescripcion
            // 
            tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescripcion.Location = new Point(6, 86);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.ScrollBars = ScrollBars.Vertical;
            tbDescripcion.Size = new Size(112, 193);
            tbDescripcion.TabIndex = 5;
            // 
            // btnDescribir
            // 
            btnDescribir.Location = new Point(7, 48);
            btnDescribir.Margin = new Padding(4);
            btnDescribir.Name = "btnDescribir";
            btnDescribir.Size = new Size(111, 29);
            btnDescribir.TabIndex = 4;
            btnDescribir.Text = "Dar puntada";
            btnDescribir.UseVisualStyleBackColor = true;
            btnDescribir.Click += btnDescribir_Click;
            // 
            // lsbTiposMotivoBordado
            // 
            lsbTiposMotivoBordado.FormattingEnabled = true;
            lsbTiposMotivoBordado.ItemHeight = 21;
            lsbTiposMotivoBordado.Location = new Point(17, 85);
            lsbTiposMotivoBordado.Name = "lsbTiposMotivoBordado";
            lsbTiposMotivoBordado.Size = new Size(154, 193);
            lsbTiposMotivoBordado.TabIndex = 6;
            // 
            // lsbSeleccionados
            // 
            lsbSeleccionados.FormattingEnabled = true;
            lsbSeleccionados.ItemHeight = 21;
            lsbSeleccionados.Location = new Point(300, 85);
            lsbSeleccionados.Name = "lsbSeleccionados";
            lsbSeleccionados.Size = new Size(160, 193);
            lsbSeleccionados.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReiniciar);
            groupBox1.Controls.Add(btnIniciarMaquina);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(lsbSeleccionados);
            groupBox1.Controls.Add(lsbTiposMotivoBordado);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 290);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elegir Motivo de Bordado";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(177, 205);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(112, 61);
            btnReiniciar.TabIndex = 12;
            btnReiniciar.Text = "Reiniciar Máquina";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnIniciarMaquina
            // 
            btnIniciarMaquina.Location = new Point(177, 54);
            btnIniciarMaquina.Name = "btnIniciarMaquina";
            btnIniciarMaquina.Size = new Size(112, 61);
            btnIniciarMaquina.TabIndex = 11;
            btnIniciarMaquina.Text = "Iniciar Máquina";
            btnIniciarMaquina.UseVisualStyleBackColor = true;
            btnIniciarMaquina.Click += btnIniciarMaquina_Click;
            // 
            // label2
            // 
            label2.Location = new Point(298, 35);
            label2.Name = "label2";
            label2.Size = new Size(157, 47);
            label2.TabIndex = 10;
            label2.Text = "Motivos agregados a la máquina";
            // 
            // label1
            // 
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(165, 47);
            label1.TabIndex = 9;
            label1.Text = "Tipos Motivos disponibles";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(177, 121);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 78);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar Motivo a la máquina";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbDescripcion);
            groupBox2.Controls.Add(btnDescribir);
            groupBox2.Location = new Point(480, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(131, 290);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operación máquina";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 293);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbDescripcion;
        private Button btnDescribir;
        private ListBox lsbTiposMotivoBordado;
        private ListBox lsbSeleccionados;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Label label2;
        private Label label1;
        private Button btnIniciarMaquina;
        private Button btnReiniciar;
        private GroupBox groupBox2;
    }
}
