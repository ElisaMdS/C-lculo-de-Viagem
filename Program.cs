using System;

public class CalculodeViagem {

    public static double litros = 0;

    public static double Calculo(double horas, double velocidadeMedia) {

        double kilometrosPorLitro = 12;

        double distancia = velocidadeMedia * horas;
        litros = distancia/kilometrosPorLitro;

        return litros;

    }

    static void Main (string[] args) {
        var horaVelocidade = Console.ReadLine().Split();
        double horas = Double.Parse(horaVelocidade[0]);
        double velocidadeMedia = Double.Parse(horaVelocidade[1]);
        
        Calculo(horas, velocidadeMedia);
        Console.WriteLine(string.Format("{0:0.000}", litros));
    }

}