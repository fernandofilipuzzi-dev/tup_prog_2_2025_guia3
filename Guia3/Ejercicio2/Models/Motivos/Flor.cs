namespace Ejercicio2.Models.Motivos;

public class Flor:IMotivo
{
    public char[][] Bordar()
    {
        return new char[][]
        {
            new char[]{' ' ,' ', ' ', ' ' },
            new char[]{' ' ,'\\', '|', '/' },
            new char[]{' ' ,' ','*',' ' },
            new char[]{' ' ,' ','|',' ' },
        };
    }
}
