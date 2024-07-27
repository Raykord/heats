namespace HeatsGame.Features.Shop
{
    using HeatsGame.Features.EquipmentSystem;
    using System;
    using UnityEngine;
    using UnityEngine.UI;

    public class ShopController : MonoBehaviour
    {
        [SerializeField] protected ShopData shopItems;
        [SerializeField] protected PlayerInventory inventory;
        public Action<ShopItem> IsItemClicked = delegate { };
        public event Action IsItemSold = delegate { };

        public ShopData GetShopItems() => shopItems;
        public PlayerInventory Inventory => inventory;

        protected void OnEnable()
        {
            IsItemClicked += OnItemClicked;
        }

        protected void Disable()
        {
            IsItemClicked -= OnItemClicked;
        }

        private void OnItemClicked(ShopItem item)
        {
            if (inventory.GetCash() >= item.EquipmentObject.Price)
            {
                inventory.ChangeCahs(item.EquipmentObject.Price);
                inventory.EquipItem(item.EquipmentObject);
                IsItemSold();
            }
            
        }
    }
}

