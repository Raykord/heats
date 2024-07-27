namespace HeatsGame.Features.Shop
{
    using HeatsGame.Features.EquipmentSystem;
    using UnityEngine;
    using UnityEngine.EventSystems;

    public class ShopItem : MonoBehaviour, IPointerClickHandler
    {
        protected ShopController controller = null;
        protected AbstractEquipmentObject equipmentObject = null;

        public AbstractEquipmentObject EquipmentObject
        {
            get { return equipmentObject; }
            set 
            {
                if (value != null)
                {
                    equipmentObject = value;
                }
                
            }
        }


        public void OnPointerClick(PointerEventData eventData)
        {
            controller.IsItemClicked(this);
        }

        protected void Start()
        {
            controller = FindObjectOfType<ShopController>();
        }

        
        
    }
}

