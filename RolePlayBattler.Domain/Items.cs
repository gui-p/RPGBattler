using System;

namespace RolePlayBattler.Domain
{ 

    //definir caracteristicas gerais pra todos os itens, precisam ser caracteristicas que de pra encaixar qualquer coisa dentro
    public class Items
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemCount { get; set; }
        public enum ItemType
        {
            Weapon, Helmet, ChestPlate, Gloves, Pants, Boots, Consumable, Misc
        }

        // a ideia do item effect é por exemplo: 8 em espada é 8 de dano, mas se for uma armadura se torna 8 de defesa,
        // em consumivel se torna 8 de cura, etc. (talvez seja necessario especificar mais depois para itens muito
        // especificos, se for o caso só utilizar herança dessa classe)
        public int ItemEffect {  get; set; }
    }

}