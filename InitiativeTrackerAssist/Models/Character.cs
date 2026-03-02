namespace InitiativeTrackerAssist.Models
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public int Initiative { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int TempHp { get; set; } = 0;

        public bool Standard { get; set; }
        public bool Bonus { get; set; }
        public bool Reaction { get; set; }
    }
}