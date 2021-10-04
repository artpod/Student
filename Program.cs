using System;
using System.Collections.Generic;

namespace Task2
{
    abstract class Student
    {
        public string name;
        public string state;
        public Student (string name1) { name = name1; state = ""; }

 

        public void Relax() { state += " relax"; }
        public void Read() { state += " read"; }
        public void Write() { state += " write"; }

        public abstract void Study();

    }

    class GoodStudent : Student
    {
        public GoodStudent(string name1) : base(name1)
        {
            state = "good";
        }

        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    class BadStudent : Student
    {
        public BadStudent(string name1) : base(name1)
        {
            state = "bad";
        }

        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }

    class Group
    {
        string groupName;
        List<Student> list = new List<Student>();
        public Group(string name)
        {
            groupName = name;
        }
        public void AddStudent(Student st)
        {
            list.Add(st);
        }
        public void GetInfo()
        {
            Console.WriteLine(groupName);
            foreach (Student st in list)
            {
                Console.Write(st.name+' ');
                Console.WriteLine();
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine(groupName);
            foreach (Student st in list)
            {
                Console.Write(st.name+' ');
                Console.Write(st.state+' ');
                Console.WriteLine();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Group KN = new Group("K-27");
            GoodStudent st1 = new GoodStudent("Artem");
            st1.Study();
            BadStudent st2 = new BadStudent("Grisha");
            st2.Study();
            GoodStudent st3 = new GoodStudent("Petya");
            st3.Study();
            KN.AddStudent(st1);
            KN.AddStudent(st2);
            KN.AddStudent(st3);
            KN.GetInfo();

        }
    }
}
