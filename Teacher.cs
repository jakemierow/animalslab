using System;

namespace Animals
{
    class Teacher : Person, Talkable
    {
        private int Age { get; set; }

        public Teacher(int age, string name) : base(name)
        {
            Age = age;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        override
        public string ToString()
        {
            return "teacher: " + "name=" + Name + " age=" + Age;
        }

    }
}