using RolePlayBattler.Domain;
using System;

namespace RolePlayBattler.ConsoleApp
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            CharacterSheet sheet = CharacterSheetFactory.CreateRandomCharacterSheet();
            Console.WriteLine(sheet);
            Character c = new(sheet);

            

        }
    }
}