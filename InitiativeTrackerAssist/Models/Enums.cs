public enum CharacterType
{
    Player = 0,
    NPC = 1
}
[Flags]
public enum Statuses
{
    Blinded = 0x1,
    Charmed = 0x2,
    Deafened = 0x4,
    Frightened = 0x8,
    Grappled = 0x10,
    Incapacitated = 0x20,
    Invisible = 0x40,
    Paralyzed = 0x80,
    Petrified = 0x100,
    Poisoned = 0x200,
    Prone = 0x400,
    Restrained = 0x800,
    Stunned = 0x1000,
    Unconscious = 0x2000
}