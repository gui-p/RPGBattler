namespace DnD
{

    public class CharacterSheet
    {

        public readonly string Name;
        public readonly Race Race;
        public int HealthPoints {get; set;}
        public Attributes Attributes {get; set;}
        public int DodgeValue {get; set;}

        public CharacterSheet(string name, Race race, int healthPoints, Attributes attributes)
        {
            Name = name;
            Race = race;
            HealthPoints = healthPoints;
            Attributes = attributes;
            DodgeValue = 6 - attributes.Dexterity;
            if(DodgeValue == 0)
            {
                DodgeValue = 1;
            }
        }

        public override string ToString()
        {
            
            string race = string.Empty;
            switch(Race)
            {
                case Race.Human:
                    race = "Human";
                    break;
                case Race.Elf:
                    race = "Elf";
                    break;
                case Race.Dwarf:
                    race = "Dwarf";
                    break;

            }

            return $"Name = {Name} - Race = {race} - HP = {HealthPoints}\n{Attributes} -";
        }

    }

    public enum Race
    {
        Human = 1, Elf = 2, Dwarf = 3

    }

    public class Attributes
    {
        public int Strength {get; private set;} 
        public int Dexterity {get; private set;}
        public int Intelligence {get; private set;}
        public int Wisdom {get; private set;} 

        public Attributes(int strength, int dexterity, int intelligence, int wisdom)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Wisdom = wisdom;
        }

        public override string ToString()
        {
            return $"Strength={Strength}| Dexterity={Dexterity}| Intelligence={Intelligence}| Wisdom={Wisdom}";
        }

    }

}