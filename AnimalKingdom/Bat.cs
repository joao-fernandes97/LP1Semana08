using System;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal
    {
        public int NumberOfNipples { get => 4}

        public override string Sound()
        {
            return base.Sound() + "kii kii";
        }
    }
}