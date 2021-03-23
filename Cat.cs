using System;

namespace Animals
{

    class Cat : Pet, Talkable
    {
        private int mousesKilled { get; set; }



        public Cat(int mousesKilled, string name) : base(name)
        {
            this.mousesKilled = mousesKilled;

        }

        public void addMouse()
        {
            mousesKilled++;
        }


        public string Talk()
        {
            return "Meow";
        }

        override
        public string ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + mousesKilled;
        }
    }

}
