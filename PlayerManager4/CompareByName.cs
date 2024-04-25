using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool asc;
        
        public CompareByName(bool asc)
        {
            this.asc = asc;
        }

        public int Compare(Player x, Player y)
        {
            if(asc)
            {
                return x.Name.CompareTo(y.Name);
            } else
            {
                return y.Name.CompareTo(x.Name);
            }
        }
    }
}