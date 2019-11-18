using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_8_12_4
{
    class Program
    {
        static string keyPro = "qwerty1";
        static string keyExp = "qwerty2";
        static void Main(string[] args)
        {
            Console.Write("Please, write a Key: ");
            string key = Console.ReadLine();
            DocumentWorker documentWorker;

            if (key.Equals(keyPro))
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key.Equals(keyExp))
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();

            Console.ReadKey();
        }
    }

    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
