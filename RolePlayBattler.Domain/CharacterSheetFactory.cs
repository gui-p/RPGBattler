using RolePlayBattler.Domain.Enum;
using System;

namespace RolePlayBattler.Domain
{
    public static class CharacterSheetFactory
    {

        public static int Instances {get; private set;} = 0;

        public static CharacterSheet CreateRandomCharacterSheet()
        {
            Instances++;
            Random random = new();
            Attributes attr = new(random.Next(1, 4),random.Next(1, 4),random.Next(1, 4),random.Next(1, 4));
            string name = "Figther" + Instances; 
            int hp = random.Next(1,7) + attr.Strength;
            Race race = EnumHelper.GetRandomEnum<Race>();
            CharacterSheet charac = new(name, race, hp, attr);
            return charac;
        }
    }
}