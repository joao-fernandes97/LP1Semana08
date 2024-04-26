using System;
using System.Collections.Generic;

namespace SortLoot
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        /// <summary>
        /// Implements comparison criteria for Loot
        /// First tries to order by Loot Value
        /// If value is the same, orders by Kind of loot alphabetically
        /// If Kind of loot  is the same, orders by description, alphabetically
        /// </summary>
        /// <param name="other">Loot object we're comparing to</param>
        /// <returns>
        /// Negative int if instance comes before other
        /// Positive int if instance comes after other
        /// 0 if there's no diference
        /// </returns>
        public int CompareTo(Loot other)
        {
            if(other.Value - Value != 0f)
                return other.Value - Value > 0 ? 1 : -1;
            else if (Kind.ToString().CompareTo(other.Kind.ToString()) != 0)
                return Kind.ToString().CompareTo(other.Kind.ToString());
            else
                return Description.CompareTo(other.Description);
        }
    }
}
