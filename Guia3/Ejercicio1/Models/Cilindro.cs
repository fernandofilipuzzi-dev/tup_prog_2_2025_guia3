
namespace Ejercicio1.Models;

public class Cilindro : IVolumetrica
{
    public double Radio { get; set; }
    public double Altura { get; set; }

    public Cilindro(double radio, double altura)
    {
        Radio = radio;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Math.PI*Math.Pow(Radio,2);
    }

    public double CalcularVolumen()
    {
        return CalcularArea() * Altura;
    }

    public override string ToString()
    {
        return $"Cilindro: Radio={Radio:f2}, Altura={Altura:f2}, Area={CalcularArea():f2}, Volumen={CalcularVolumen():f2}";
    }
}
