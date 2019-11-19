using System;
using System.Collections.Generic;

namespace KSBL_Task_9_13_2
{
    abstract class AbstractHandler
    {
        public abstract void Open();

        public abstract void Create();

        public abstract void Change();

        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");
        }

        public override void Change()
        {
            Console.WriteLine("Change XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Change()
        {
            Console.WriteLine("Change TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void Change()
        {
            Console.WriteLine("Change DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler> handlers = new List<AbstractHandler>();

            AbstractHandler xml = new XMLHandler();
            AbstractHandler txt = new TXTHandler();
            AbstractHandler doc = new DOCHandler();

            handlers.Add(xml);
            handlers.Add(txt);
            handlers.Add(doc);

            foreach (var handler in handlers)
            {
                handler.Open();
                handler.Create();
                handler.Change();
                handler.Save();

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
