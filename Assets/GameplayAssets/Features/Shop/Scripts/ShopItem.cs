namespace HeatsGame.Features.Shop
{
    using DG.Tweening;
    using HeatsGame.Features.EquipmentSystem;
    using UnityEngine;
    using UnityEngine.EventSystems;

    public class ShopItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
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
            transform.DOMove(new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), 0.2f).SetEase(Ease.InBounce).SetLoops(2, LoopType.Yoyo);
            controller.IsItemClicked(this);

        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            transform.DOScale(1.2f, 0.5f);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            transform.DOScale(1f, 0.5f);
        }

        protected void Start()
        {
            controller = FindObjectOfType<ShopController>();
        }

        
        
    }
}

