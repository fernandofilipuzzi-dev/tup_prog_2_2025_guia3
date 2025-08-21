using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Servicio servicio = new Servicio();

        private void btnAgregarFigura_Click(object sender, EventArgs e)
        {

            int tipoFigura = lsbTipoFigura.SelectedIndex;

            IFigura figura = null;
            switch (tipoFigura)
            {
                case 0:
                    {
                        double radio = Convert.ToDouble(tbRadio.Text);
                        figura = new Circulo(radio);
                        break;
                    }
                case 1:
                    {
                        double ancho = Convert.ToDouble(tbAncho.Text);
                        double largo = Convert.ToDouble(tbLargo.Text);
                        figura = new Rectangulo(ancho, largo);
                        break;
                    }
                case 2:
                    {
                        double radio = Convert.ToDouble(tbRadio.Text);
                        figura = new Esfera(radio);
                        break;
                    }
                case 3:
                    {
                        double radio = Convert.ToDouble(tbRadio.Text);
                        double alto = Convert.ToDouble(tbAlto.Text);
                        figura = new Cilindro(radio, alto);
                        break;
                    }
            }

            if (figura != null)
            {
                servicio.AgregarFigura(figura);
                lsbListadoCreado.Items.Add(figura);
            }
            else
                MessageBox.Show("Debe seleccionar un tipo de figura");

        }

        private void lbxTipoFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoFigura = lsbTipoFigura.SelectedIndex;

            tbRadio.Clear();
            tbAncho.Clear();
            tbLargo.Clear();
            tbRadio.Clear();
            tbAlto.Clear();

            IFigura figura = null;
            switch (tipoFigura)
            {
                case 0:
                    {
                        tbRadio.Enabled = true;
                        tbAncho.Enabled = false;
                        tbLargo.Enabled = false;
                        tbAlto.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        tbRadio.Enabled = false;
                        tbAncho.Enabled = true;
                        tbLargo.Enabled = true;
                        tbAlto.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        tbRadio.Enabled = true;
                        tbAncho.Enabled = false;
                        tbLargo.Enabled = false;
                        tbAlto.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        tbRadio.Enabled = true;
                        tbAncho.Enabled = false;
                        tbLargo.Enabled = false;
                        tbAlto.Enabled = true;
                        break;
                    }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            IFigura figura = lsbListadoCreado.SelectedItem as IFigura;

            if (figura != null)
            {
                int idx = lsbListadoCreado.SelectedIndex;

                if (idx > -1)
                    servicio.EliminarFigura(idx);

                lsbListadoCreado.Items.Remove(figura);
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un tipo de figura");
            }
        }
    }
}
