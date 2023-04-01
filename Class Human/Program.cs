using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace Class_Human
{
    abstract class Human
    {
        protected string name;
        protected int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract override string ToString();
    }

    class Professor : Human
    {
        private string subject;

        public Professor(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public override string ToString()
        {
            return $"Professor {name}, {age} years old, teaching {subject}";
        }

        public void GradeStudent(Student student, int grade)
        {
            // some code to grade a student
        }
    }

    class Student : Human
    {
        private string major;

        public Student(string name, int age, string major) : base(name, age)
        {
            this.major = major;
        }

        public override string ToString()
        {
            return $"Student {name}, {age} years old, majoring in {major}";
        }

        public void RegisterCourse(Course course)
        {
            // some code to register a course
        }
    }

    class Wizard : Human
    {
        private string wand;

        public Wizard(string name, int age, string wand) : base(name, age)
        {
            this.wand = wand;
        }

        public override string ToString()
        {
            return $"Wizard {name}, {age} years old, wielding {wand}";
        }

        public void CastSpell(Spell spell)
        {
            // some code to cast a spell
        }
    }

    class Goblin : Human
    {
        private string tribe;

        public Goblin(string name, int age, string tribe) : base(name, age)
        {
            this.tribe = tribe;
        }

        public override string ToString()
        {
            return $"Goblin {name}, {age} years old, belonging to {tribe} tribe";
        }

        public void StealItem(Item item)
        {
            // some code to steal an item
        }
    }

    class Muggle : Human
    {
        public Muggle(string name, int age) : base(name, age)
        {
        }

        public override string ToString()
        {
            return $"Muggle {name}, {age} years old";
        }

        public void DriveCar(Car car)
        {
            // some code to drive a car
        }
    }

}
