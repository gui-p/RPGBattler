using System;

namespace RolePlayBattler.Domain
{

    //Inventario geral (to pensando ainda)
    public class Inventory
    {
        public int SlotsCount { get; set; }
        public String[]? Slots { get; private set; }
        
    }

    //Ideia atual é que os itens sejam tratados como objetos da classe itens, lista de Enum pra tipo de item (ajuda a definir quais itens podem ir em quais slots, consumiveis, etc)
    public class EquipmentSlots
    {

    }
}