﻿using System;
using System.Globalization;

namespace Program {
class URI {
    static void Main() {
        double X, Y;

        string[] Parametros = Console.ReadLine().Split(' ');

        X = double.Parse(Parametros[0], CultureInfo.InvariantCulture);
        Y = double.Parse(Parametros[1], CultureInfo.InvariantCulture);
        if(X + Y == 0)
            Console.WriteLine("Origem");
        else if(X == 0) 
            Console.WriteLine("Eixo Y");
        else if(Y == 0) 
            Console.WriteLine("Eixo X");
        else if(X > 0 && Y > 0 ) 
            Console.WriteLine("Q1");
        else if(X < 0 && Y > 0) 
            Console.WriteLine("Q2");
        else if(X < 0 && Y < 0) 
            Console.WriteLine("Q3");
        else if(X > 0 && Y < 0) 
            Console.WriteLine("Q4");
    }
}
}