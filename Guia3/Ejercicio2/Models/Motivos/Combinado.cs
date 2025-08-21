namespace Ejercicio2.Models.Motivos;

public class Combinado: IMotivo
{
    int n = 0;

    public List<IMotivo> motivos=new List<IMotivo>();

    public Combinado(IMotivo motivo)
    {
        motivos.Add(motivo);
    }

    public void agregarMotivo(IMotivo motivo)
    {
        motivos.Add(motivo);
    }   

    public char[][] GetPatron()
    {
        IMotivo m= motivos[n];
        n=++n%motivos.Count;
        return m.GetPatron();
    }
}
