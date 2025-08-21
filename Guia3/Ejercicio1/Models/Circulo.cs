
namespace Ejercicio1.Models;

public class Circulo : ISuperficie
{
    public double Radio { get; set; }
    public Circulo(double radio)
    {
        this.Radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI*Math.Pow(this.Radio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2*Math.PI * Radio;
    }

    public override string ToString()
    {
        return $"Circulo: Radio={Radio:f2}, Area={CalcularArea():f2}, Perimetro={CalcularPerimetro():f2}";
    }
}
