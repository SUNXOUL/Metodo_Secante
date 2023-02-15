using System.Text.RegularExpressions;
using System;

public class Iteracion
{
    public double X1 {get;set;}
    public double X0 { get; set; }
    
    public double Fx1 { get; set; }
    public double Fx0 { get; set; } 
    public double X { get; set; }
    public double Error { get; set; }

    // Habilitada para f(x) = x + 2x + 10x - 20



    public Iteracion(double x1, double x0)
        {
            this.X1 = x1;
            this.X0 = x0;
    }

    public Iteracion CalcularNueva()
    {
        
        //calculamos el valor de f(xi)
        this.Fx1 =Math.Round(( Math.Pow(this.X1,2) - Math.Pow((Math.E),-(this.X1))),6);
        
        //Calculamos el valor de f(xi-1)
        this.Fx0 = Math.Round(( Math.Pow(this.X0,2) - Math.Pow((Math.E),-(this.X0))),6);

        //calculamos el valor de la raiz para la nueva iteracion
        this.X = Math.Round( this.X1-(((this.Fx1)*(this.X0 - this.X1)) / (this.Fx0- this.Fx1)),7);
        
        //Calculamos el valor del error
        this.Error = Math.Round(((((this.X - this.X1)/this.X)*100)),4);

        return this;
    }
}