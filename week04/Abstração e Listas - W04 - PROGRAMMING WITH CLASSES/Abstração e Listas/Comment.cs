using System;

public class Comment
{
    // Variáveis de membro usando _underscoreCamelCase (conforme a rubrica)
    public string _name;
    public string _text;

    // Construtor para facilitar a criação
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
}