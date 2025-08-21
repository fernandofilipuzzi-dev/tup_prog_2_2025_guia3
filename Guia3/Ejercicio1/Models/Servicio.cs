namespace Ejercicio1.Models;

public class Servicio
{
    List<IFigura> figuras=new List<IFigura>();


    public IFigura VerFigura(int idx)
    {
        if(idx>=0 && idx<figuras.Count)
        {
            return figuras[idx];
        }
        return null;
    }

    public int VerCantidad()
    {
        return figuras.Count;
    }

    public void AgregarFigura(IFigura figura)
    {
        figuras.Add(figura);
    }

    public void EliminarFigura(int idx)
    {
        if (idx >= 0 && idx < figuras.Count)
        {
            figuras.RemoveAt(idx);
        }
    }
}
