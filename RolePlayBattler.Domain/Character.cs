using System;

namespace RolePlayBattler.Domain
{
    public class Character
    {
        public CharacterSheet CharSheet {get; set;}

        public Character(CharacterSheet sheet)
        {
            CharSheet = sheet;
        }
        public void DoDamage(Character character)
        {
            int Dmg;
            Random Rand = new Random();
            Dmg = CharSheet.Attributes.Strength + Rand.Next(1,7);
            character.TakeDamage(Dmg);
        }
        private void TakeDamage(int Dmg)
        {
            Random Rand = new Random();
            int HitTrigger = Rand.Next(1,7);
            if(HitTrigger > CharSheet.DodgeValue)
            {
                Console.WriteLine("DODGE");
            }
            else
            {
                CharSheet.HealthPoints = CharSheet.HealthPoints - Dmg;
                Console.WriteLine($"{CharSheet.Name} GOT HIT");
                if (CharSheet.HealthPoints <= 0)
                {
                Console.WriteLine($"{CharSheet.Name}DEAD");
                }
            }
        }

        public void Heal()
        {
            Random Rand = new Random();
            int Healed = (Rand.Next(1,7) + (CharSheet.Attributes.Intelligence/2))/2;
            CharSheet.HealthPoints = CharSheet.HealthPoints + Healed;
            Console.WriteLine($"{CharSheet.Name} HEALED {Healed} HP");
        }
    }
}