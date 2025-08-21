
namespace Ejercicio1.Models;

public class Esfera : IVolumetrica
{
    public double Radio { get; set; }

    public Esfera(double radio)
    {
        Radio = radio;
    }

    public double CalcularArea()
    {
        return 4*Math.PI*Math.Pow(Radio,2);
    }

    public double CalcularVolumen()
    {
        return 4/3*Math.PI*Math.Pow(Radio,3);
    }

    override public string ToString()
    {
        return $"Esfera: Radio={Radio:f2}, Area={CalcularArea():f2}, Volumen={CalcularVolumen():f2}";
    }
}
