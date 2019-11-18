using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_8_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new BadPupil());

            Console.WriteLine(classRoom.Pupils.Count);

            foreach (var pupil in classRoom.Pupils)
            {
                Console.WriteLine();

                Console.WriteLine("Pupil {0}", pupil.GetHashCode());
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }

            Console.ReadKey();
        }
    }

    class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

        public List<Pupil> Pupils
        {
            get { return pupils; }
        }

        public ClassRoom(Pupil A, Pupil B, Pupil C, Pupil D) : this(A, B, C)
        {
            pupils.Add(D);
        }

        public ClassRoom(Pupil A, Pupil B, Pupil C) : this(A, B)
        {
            pupils.Add(C);
        }

        public ClassRoom(Pupil A, Pupil B)
        {
            pupils.Add(A);
            pupils.Add(B);
        }
    }

    class Pupil
    {
        public virtual void Study()
        {

        }

        public virtual void Read()
        {

        }

        public virtual void Write()
        {

        }

        public virtual void Relax()
        {

        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent study");
        }

        public override void Read()
        {
            Console.WriteLine("Excelent read");
        }

        public override void Write()
        {
            Console.WriteLine("Excelent write");
        }

        public override void Relax()
        {
            Console.WriteLine("Excelent relax");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good study");
        }

        public override void Read()
        {
            Console.WriteLine("Good read");
        }

        public override void Write()
        {
            Console.WriteLine("Good write");
        }

        public override void Relax()
        {
            Console.WriteLine("Good relax");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad study");
        }

        public override void Read()
        {
            Console.WriteLine("Bad read");
        }

        public override void Write()
        {
            Console.WriteLine("Bad write");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad relax");
        }
    }
}
