using System;

namespace RPG
{
    public static class CharacterSheetFactory
    {

        public static int Instances {get; private set;} = 0;

        public static CharacterSheet CreateRandomCharacter()
        {
            Instances++;
            Random random = new();
            Attributes attr = new(random.Next(1, 4),random.Next(1, 4),random.Next(1, 4),random.Next(1, 4));
            string name = "Figther" + Instances; 
            int hp = random.Next(1,7) + attr.Strength;
            CharacterSheet charac = new(name, Race.Human, hp, attr);
            return charac;
        }
    }
}