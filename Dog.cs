using System;

namespace Animals
{
    class Dog : Pet, Talkable
    {
        private bool friendly { get; set; }

        public Dog(bool friendly, string name) : base(name)
        {
            this.friendly = friendly;
        }

        public bool isFriendly()
        {
            return friendly;
        }


        public string Talk()
        {
            return "Bark";
        }

        override
        public string ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + friendly;
        }


    }

}
