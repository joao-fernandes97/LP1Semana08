using System;

namespace AnimalKingdom
{
    public class Bat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "kii kii";
        }
    }
}