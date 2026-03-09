namespace InitiativeTrackerAssist.Models
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public int Initiative { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int TempHp { get; set; } = 0;
        public int ArmorClass { get; set; }

        public bool Standard { get; set; }
        public bool Bonus { get; set; }
        public bool Reaction { get; set; }

        //this is going to be jank, but conditions
        public bool IsBlinded { get; set; }
        public bool IsCharmed { get; set; }
        public bool IsDeafened { get; set; }
        public bool IsFrightened { get; set; }
        public bool IsGrappled { get; set; }
        public bool IsIncapacitated { get; set; }
        public bool IsInvisible { get; set; }
        public bool IsParalyzed { get; set; }
        public bool IsPetrified { get; set; }
        public bool IsPoisoned { get; set; }
        public bool IsProne { get; set; }
        public bool IsRestrained { get; set; }
        public bool IsStunned { get; set; }
        public bool IsUnconscious { get; set; }

        //exhaustion
        private int _exhaustionLevel;
        public int ExhaustionLevel
        {
            get => _exhaustionLevel;
            set
            {
                if (value >= 0 && value < 6)
                {
                    _exhaustionLevel = value;
                }
            }
        }

        // computed list of enabled statuses for display
        public IEnumerable<string> ActiveStatuses
        {
            get
            {
                if (IsBlinded) yield return "Blinded";
                if (IsCharmed) yield return "Charmed";
                if (IsDeafened) yield return "Deafened";
                if (IsFrightened) yield return "Frightened";
                if (IsGrappled) yield return "Grappled";
                if (IsIncapacitated) yield return "Incapacitated";
                if (IsInvisible) yield return "Invisible";
                if (IsParalyzed) yield return "Paralyzed";
                if (IsPetrified) yield return "Petrified";
                if (IsPoisoned) yield return "Poisoned";
                if (IsProne) yield return "Prone";
                if (IsRestrained) yield return "Restrained";
                if (IsStunned) yield return "Stunned";
                if (IsUnconscious) yield return "Unconscious";
            }
        }
    }
}