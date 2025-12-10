using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Criando as atividades (Data, Minutos, [Parâmetro Específico])
        // Running: 3 de Novembro, 30 min, 4.8 km
        Running run = new Running("03 Nov 2022", 30, 4.8);
        activities.Add(run);

        // Cycling: 3 de Novembro, 30 min, velocidade de 20 kph
        Cycling bike = new Cycling("03 Nov 2022", 30, 20.0);
        activities.Add(bike);

        // Swimming: 3 de Novembro, 30 min, 20 voltas (laps)
        Swimming swim = new Swimming("03 Nov 2022", 30, 20);
        activities.Add(swim);

        // Iterando pela lista e exibindo o resumo
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}