namespace HeatsGame.Features.EquipmentSystem
{
    using System.Collections.Generic;
    using UnityEngine;

    [CreateAssetMenu(fileName = "Inventory", menuName = "SO/Player/Inventory")]
    public class PlayerInventory : ScriptableObject
    {
        [SerializeField] protected List<EquipmentSlot> slots = new List<EquipmentSlot>()
        {
            new EquipmentSlot(EqupmentType.Head),
            new EquipmentSlot(EqupmentType.Chest),
            new EquipmentSlot(EqupmentType.Hands),
            new EquipmentSlot(EqupmentType.Legs),
            new EquipmentSlot(EqupmentType.Foots)
        };

        public List<EquipmentSlot> GetSlots() => slots;
    }
}

