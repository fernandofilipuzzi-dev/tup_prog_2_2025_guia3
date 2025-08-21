

using Ejercicio2.Models.Motivos;

namespace Ejercicio2.Models;

public class MaquinaCoser
{
    private IMotivo motivo;

    public MaquinaCoser(IMotivo bordado)
    {
        this.motivo = bordado;
    }

    public string[] Bordar()
    {
        char[][] patron = this.motivo.Bordar();


        string[] bordado = new string[patron.GetLength(0)];

        for (int n = 0; n < patron.GetLength(0); n++)
        {
            bordado[n] = new string(patron[n]);
        }
        return bordado;
    }

}
