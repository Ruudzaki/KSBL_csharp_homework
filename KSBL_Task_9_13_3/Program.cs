using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_9_13_3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            Console.WriteLine(player.GetHashCode());

            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine();

            IRecordable recorder = player as IRecordable;
            Console.WriteLine(recorder.GetHashCode());

            recorder.Record();
            recorder.Pause();
            recorder.Stop();

            Console.ReadKey();
        }
    }
}
