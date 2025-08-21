using Ejercicio2.Models;
using Ejercicio2.Models.Motivos;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //MaquinaBordadora maquinaBordadora = new MaquinaBordadora(new ZigZag());
        MaquinaCoser maquinaBordadora = new MaquinaCoser(new Flor());

        private void btnDescribir_Click(object sender, EventArgs e)
        {

            foreach (string linea in maquinaBordadora.Bordar())
            { 
                tbDescripcion.AppendText(linea + Environment.NewLine);
            }
        }
     }
}
