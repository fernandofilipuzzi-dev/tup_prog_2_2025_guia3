﻿
using System.Collections;

namespace Ejercicio3.Models;

public class Envio
{
    private ArrayList costos = new ArrayList();

    public void AgregarCosto(Costo nuevo)
    {
        costos.Add(nuevo);
    }

    public double ValorTotal
    {
        get
        {
            double total = 0;
            foreach (Costo c in costos)
            {
                total += c.ValorFinal;
            }
            return total;
        }
    }
    public string VerDetalle() 
    {
        string detalle = "";
        foreach (Costo c in costos)
        {
            detalle += c.VerDetalle();
        }
        return detalle;
    }
}
