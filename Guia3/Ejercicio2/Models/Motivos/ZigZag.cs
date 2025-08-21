namespace Ejercicio2.Models.Motivos;

public class ZigZag: IMotivo
{

    public char[][] GetPatron()
    {
        return new char[][]
        { 
            new char[]{'/' ,'\\' }
        };
    }

    public override string ToString()
    {
        return "ZigZag";

    }
}
