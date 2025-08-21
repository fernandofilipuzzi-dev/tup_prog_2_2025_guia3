namespace Ejercicio2.Models.Motivos;

public class ZigZag: IMotivo
{

    public char[][] Bordar()
    {
        return new char[][]
        { 
            new char[]{'/' ,'\\' }
        };
    }
}
