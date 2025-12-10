using System;

public abstract class Activity
{
    // Encapsulamento: variáveis privadas
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Métodos para as classes filhas acessarem a duração (se precisarem)
    protected int GetMinutes()
    {
        return _minutes;
    }

    // Métodos Abstratos (Polimorfismo):
    // A classe base não sabe calcular isso, mas obriga as filhas a saberem.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Método Summary definido na Base
    // Ele chama os métodos abstratos acima. Quando rodar, o C# vai buscar
    // a versão correta do método dependendo se é Corrida, Bike ou Natação.
    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min)- Distance {GetDistance().ToString("F1")} km, Speed {GetSpeed().ToString("F1")} kph, Pace: {GetPace().ToString("F1")} min per km";
    }
}