namespace HeatsGame.Features.EquipmentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;

    [CreateAssetMenu(fileName = "Inventory", menuName = "SO/Player/Inventory")]
    public class PlayerInventory : ScriptableObject
    {
        public event Action<AbstractEquipmentObject> IsItemEquiped = delegate { };
        public event Action<AbstractEquipmentObject> IsItemUnequiped = delegate { };

        [SerializeField] protected List<EquipmentSlot> slots = new List<EquipmentSlot>()
        {
            new EquipmentSlot(EqupmentType.Head),
            new EquipmentSlot(EqupmentType.Chest),
            new EquipmentSlot(EqupmentType.Hands),
            new EquipmentSlot(EqupmentType.Legs),
            new EquipmentSlot(EqupmentType.Foots)
        };

        [SerializeField] protected float cash = 0f;


        public List<EquipmentSlot> GetSlots() => slots;
        public float GetCash() => cash;
        public void ChangeCahs(float amount)
        {
            cash -= amount;
            if (cash < 0f)
            {
                cash = 0f;
            }
        }
       

        public void EquipItem(AbstractEquipmentObject item)
        {
            EquipmentSlot tempSlot = slots.Where(slot => slot.EqupmentType == item.GetEqupmentType).FirstOrDefault();
            if (tempSlot != null)
            {
                tempSlot.EquipmentObject = item;
                IsItemEquiped(item);
            }
        }

        public void UnequipItem(AbstractEquipmentObject item)
        {
            EquipmentSlot tempSlot = slots.Where(slot => slot.EquipmentObject == item).FirstOrDefault();
            if (tempSlot != null)
            {
                tempSlot.EquipmentObject = null;
                IsItemUnequiped(item);
            }
        }
    }
}

