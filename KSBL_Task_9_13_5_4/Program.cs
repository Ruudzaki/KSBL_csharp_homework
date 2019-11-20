using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_9_13_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            //set the store
            store[0] = new Article("Apple1", "ProdMag1", 21.5);
            store[1] = new Article("Apple2", "ProdMag2", 22.5);
            store[2] = new Article("Apple3", "ProdMag3", 23.5);
            store[3] = new Article("Apple4", "ProdMag4", 24.5);
            store[4] = new Article("Apple5", "ProdMag5", 25.5);

            //1
            int n = 2;
            Console.WriteLine("Index: {0}", n);
            store[n].PrintInfo();

            Console.WriteLine();

            //2
            store.FindArticle(Console.ReadLine());

            Console.ReadKey();
        }
    }

    class Article
    {
        private string name;
        private string nameStore;
        private double price;

        public string Name
        {
            get { return name; }
        }


        public Article(string name, string nameStore, double price)
        {
            this.name = name;
            this.nameStore = nameStore;
            this.price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Store: {0}", nameStore);
            Console.WriteLine("Price: {0}", price);
        }
    }

    class Store
    {
        private Article[] articles = new Article[5];

        public Article this[int index]
        {
            get { return articles[index]; }
            set { articles[index] = value; }
        }

        public void FindArticle(string line)
        {
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].Name == line)
                {
                    Console.WriteLine("Index: {0}", i);
                    articles[i].PrintInfo();
                    return;
                }
            }

            Console.WriteLine("There are no such article with the name \"{0}\". Please try again.", line);
        }
    }
}
