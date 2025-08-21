namespace Ejercicio2.Models.Motivos;

public class Flor:IMotivo
{
    public char[][] GetPatron()
    {
        return new char[][]
        {
            new char[]{' ' ,' ', ' ', ' ' },
            new char[]{' ' ,'\\', '|', '/' },
            new char[]{' ' ,' ','*',' ' },
            new char[]{' ' ,' ','|',' ' },
        };
    }

    public override string ToString()
    {
        return "Flor";

    }
}
