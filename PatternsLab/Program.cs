using System;

// Базовий інтерфейс для електронної книги
public interface IEbook
{
    void Display();
}

// Конкретна реалізація електронної книги
public class BasicEbook : IEbook
{
    private string _title;

    public BasicEbook(string title)
    {
        _title = title;
    }

    public void Display()
    {
        Console.WriteLine($"Displaying basic ebook: {_title}");
    }
}

// Декоратор для додавання відео до електронної книги
public class VideoDecorator : IEbook
{
    private IEbook _ebook;
    private string _video;

    public VideoDecorator(IEbook ebook, string video)
    {
        _ebook = ebook;
        _video = video;
    }

    public void Display()
    {
        _ebook.Display();
        Console.WriteLine($"Displaying video: {_video}");
    }
}

// Декоратор для додавання аудіо до електронної книги
public class AudioDecorator : IEbook
{
    private IEbook _ebook;
    private string _audio;

    public AudioDecorator(IEbook ebook, string audio)
    {
        _ebook = ebook;
        _audio = audio;
    }

    public void Display()
    {
        _ebook.Display();
        Console.WriteLine($"Playing audio: {_audio}");
    }
}

// Приклад використання
class Program
{
    static void Main(string[] args)
    {
        // Створюємо базову електронну книгу
        IEbook basicEbook = new BasicEbook("Introduction to C#");

        // Додаємо до неї відео та аудіо
        IEbook ebookWithVideo = new VideoDecorator(basicEbook, "C# Video Tutorial");
        IEbook ebookWithVideoAndAudio = new AudioDecorator(ebookWithVideo, "C# Audio Lesson");

        // Відображаємо електронну книгу з усіма елементами
        ebookWithVideoAndAudio.Display();
    }
}