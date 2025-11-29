using System;
using System.Collections.Generic; // Necessário para usar List

public class Video
{
    // Variáveis de membro usando _underscoreCamelCase
    public string _title;
    public string _author;
    public int _length; // Duração em segundos
    public List<Comment> _comments = new List<Comment>();

    // Construtor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Método para adicionar um comentário à lista
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    // Método exigido na rubrica: Retorna o número de comentários
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}