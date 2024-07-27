namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    public class InventoryController : MonoBehaviour
    {
        [SerializeField] PlayerInventory inventory;
        [SerializeField] AbstractEquipmentObject equipmentObject;

        private void OnEnable()
        {
            inventory.IsItemEquiped += Message;
            inventory.IsItemUnequiped += Message2;
        }

        private void OnDisable()
        {
            inventory.IsItemEquiped -= Message;
            inventory.IsItemUnequiped -= Message2;
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                inventory.EquipItem(equipmentObject);
            }
            if (Input.GetKeyUp(KeyCode.T))
            {
                inventory.UnequipItem(equipmentObject);
            }
        }

        void Message(AbstractEquipmentObject item)
        {
            Debug.Log($"Work! {item.name} is equped");
        }

        void Message2(AbstractEquipmentObject item)
        {
            Debug.Log($"Work! {item.name} is unequped");
        }
    }
}

