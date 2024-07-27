namespace HeatsGame.Features.EquipmentSystem
{
    using System.Collections.Generic;
    using UnityEngine;
    
    public class PlayerInventoryView : MonoBehaviour
    {
        [SerializeField] protected PlayerInventory inventory = null;
        [SerializeField] protected Transform equpment = null;
        protected List<GameObject> instances = new List<GameObject>();


        protected void OnEnable()
        {
            inventory.IsItemEquiped += EquipItem;
            inventory.IsItemUnequiped += UnequipItem;
        }

        protected void OnDisable() => inventory.IsItemEquiped -= EquipItem;

        protected void Start()
        {
            foreach (EquipmentSlot slot in inventory.GetSlots())
            {
                if (slot.EquipmentObject != null)
                {
                    EquipItem(slot.EquipmentObject);
                }
            }
        }

        protected void EquipItem(AbstractEquipmentObject item)
        {
            for (int i = 0; i < equpment.childCount; i++)
            {
                if (equpment.GetChild(i).gameObject.TryGetComponent<ViewSlot>(out var slot))
                {
                    if (slot.EqupmentType == item.GetEqupmentType)
                    {
                        GameObject instanceItem = Instantiate(item.Prefab, slot.gameObject.transform.position, slot.gameObject.transform.rotation);
                        instances.Add(instanceItem);
                        instanceItem.transform.parent = slot.gameObject.transform;
                        return;
                    }
                }
            }
        }

        protected void UnequipItem(AbstractEquipmentObject item)
        {
            for (int i = 0; i < equpment.childCount; i++)
            {
                if (equpment.GetChild(i).gameObject.TryGetComponent<ViewSlot>(out var slot))
                {
                    if (slot.EqupmentType == item.GetEqupmentType)
                    {
                        Destroy(slot.transform.GetChild(0).gameObject);
                    }
                }
            }
        }
    }
}

