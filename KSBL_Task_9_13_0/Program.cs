using System;

// Передача экземпляра класса в качестве аргумента метода

namespace Classes
{

    abstract class WordDocument
    {
        public abstract void Create();
    }

    class WordDocumentCreateor : WordDocument
    {
        public override void Create()
        {
            Console.WriteLine("Создан документ");
        }
    }

    class NewFileProcess
    {
        // На 18 строке создаем метод с именем CallMethod, который принимает один аргумент типа MyClass и ничего не возвращает
        public void UIButtonHandler(WordDocument my)
        {
            // В теле метода CallMethod, на 21 строке вызываем метод с именем Method аргумента my 
            my.Create();
        }
    }



    class Program
    {
        static void Main()
        {
            WordDocument my = new WordDocumentCreateor();

            NewFileProcess my2 = new NewFileProcess();

            my2.UIButtonHandler(my);

            // Задержка
            Console.ReadKey();
        }
    }
}
