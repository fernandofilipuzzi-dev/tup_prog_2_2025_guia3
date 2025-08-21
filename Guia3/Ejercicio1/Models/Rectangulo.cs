
namespace Ejercicio1.Models;

public class Rectangulo : ISuperficie
{
    public double Ancho { get; set; }
    public double Largo { get; set; }

    public Rectangulo(double ancho, double largo)
    { 
        this.Ancho = ancho;
        this.Largo = largo;
    }

    public double CalcularArea()
    {
        return Ancho * Largo;
    }

    public double CalcularPerimetro()
    {
        return 2*Ancho+2*Largo;
    }

    override public string ToString()
    {
        return $"Rectangulo: Ancho={Ancho:f2}, Largo={Largo:f2}, Area={CalcularArea():f2}, Perimetro={CalcularPerimetro():f2}";
    }
}
