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

        public Statuses Statuses { get; set; } = 0;

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
                if ((Statuses & Statuses.Blinded) != 0) yield return "Blinded";
                if ((Statuses & Statuses.Charmed) != 0) yield return "Charmed";
                if ((Statuses & Statuses.Deafened) != 0) yield return "Deafened";
                if ((Statuses & Statuses.Frightened) != 0) yield return "Frightened";
                if ((Statuses & Statuses.Grappled) != 0) yield return "Grappled";
                if ((Statuses & Statuses.Incapacitated) != 0) yield return "Incapacitated";
                if ((Statuses & Statuses.Invisible) != 0) yield return "Invisible";
                if ((Statuses & Statuses.Paralyzed) != 0) yield return "Paralyzed";
                if ((Statuses & Statuses.Petrified) != 0) yield return "Petrified";
                if ((Statuses & Statuses.Poisoned) != 0) yield return "Poisoned";
                if ((Statuses & Statuses.Prone) != 0) yield return "Prone";
                if ((Statuses & Statuses.Restrained) != 0) yield return "Restrained";
                if ((Statuses & Statuses.Stunned) != 0) yield return "Stunned";
                if ((Statuses & Statuses.Unconscious) != 0) yield return "Unconscious";
            }
        }
    }
}