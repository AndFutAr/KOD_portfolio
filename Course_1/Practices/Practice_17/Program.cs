using System;

namespace Practice_17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercise #1");
            IPlayable[] instruments =
            {
                new Guitar(),
                new Piano(),
                new Drum()
            };
            foreach (var i in instruments)
                i.Play();
            
            Console.WriteLine("Exercise #2");
            TextDocument doc = new TextDocument();
            doc.Read("data.txt");
            doc.Write("data.txt", "Привет, мир!");
            doc.Save();
            
            Console.WriteLine("Exercise #3");
            IDocumentExporter[] exporters =
            {
                new TxtExporter(),
                new PdfExporter()
            };
            foreach (var e in exporters)
            {
                e.ShowInfo("Hello World!");
                e.Export("Hello World!");
            }
        }
    }

    public interface IPlayable
    {
        void Play();
    }
    public class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Гитара играет аккорд");
        }
    }
    public class Piano : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Пианино играет мелодию");
        }
    }
    public class Drum : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Барабан отбивает ритм");
        }
    }
    
    public interface IReadable
    {
        void Read(string filename);
    }
    public interface IWritable
    {
        void Write(string filename, string content);
    }
    public interface ISavable
    {
        void Save();
    }
    public class TextDocument : IReadable, IWritable, ISavable
    {
        private string content;
        
        public void Read(string filename)
        {
            Console.WriteLine($"Чтение из файла {filename}");
            content = "Текст из файла";
        }
        public void Write(string filename, string content)
        {
            Console.WriteLine($"Запись в файл {filename}: {content}");
            this.content = content;
        }
        public void Save()
        {
            Console.WriteLine($"Файл сохранён. Содержимое: {content}");
        }
    }
    
    public interface IDocumentExporter
    {
        string FormatName { get; }
        void Export(string content);

        void ShowInfo(string content);

    }
    public class TxtExporter : IDocumentExporter
    {
        public string FormatName => "TXT";
        public void ShowInfo(string content)
        {
            Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
        }
        public void Export(string content)
        {
            Console.WriteLine("Сохраняем текстовый файл...");
        }
    }
    public class PdfExporter : IDocumentExporter
    {
        public string FormatName => "PDF";
        public void ShowInfo(string content)
        {
            Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
        }
        public void Export(string content)
        {
            Console.WriteLine("Создаём PDF-документ...");
        }
    }
}