using Ejercicio2.Models;
using Ejercicio2.Models.Motivos;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //MaquinaBordadora maquinaCoser = new MaquinaBordadora(new ZigZag());
        MaquinaCoser maquinaCoser = new MaquinaCoser(new Flor());

        private void btnDescribir_Click(object sender, EventArgs e)
        {

            foreach (string linea in maquinaCoser.DarPuntada())
            {
                tbDescripcion.AppendText(linea + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inicio lista
            lsbTiposMotivoBordado.Items.AddRange(
                new IMotivo[]{
                    new Flor(),
                    new ZigZag()
                });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IMotivo motivo = lsbTiposMotivoBordado.SelectedItem as IMotivo;

            if (motivo != null)
            {
                maquinaCoser.AgregarPatron(motivo);
                lsbSeleccionados.Items.Add(motivo);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un motivo de bordado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarMaquina_Click(object sender, EventArgs e)
        {
            IMotivo motivo = lsbTiposMotivoBordado.SelectedItem as IMotivo;

            if (motivo != null)
            {
                maquinaCoser = new MaquinaCoser(motivo);
                lsbSeleccionados.Items.Add(motivo);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un motivo de bordado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.lsbSeleccionados.Items.Clear();
            this.btnIniciarMaquina.PerformClick();
        }
    }
}
