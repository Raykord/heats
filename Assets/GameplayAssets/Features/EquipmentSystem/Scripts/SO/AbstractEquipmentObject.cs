namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    public abstract class AbstractEquipmentObject : ScriptableObject
    {
        [SerializeField] protected GameObject prefab = null;
        [SerializeField] protected Sprite icon = null;
        [SerializeField] protected string itemName = string.Empty;
        [SerializeField] protected float price = 0f;
        [SerializeField, TextArea(1, 10)] protected string description = string.Empty;
        [SerializeField] protected EqupmentType equipmentType = 0;
        [SerializeField] protected ItemDuration duration = null;
        [SerializeField] protected Buff[] buffs = null;
        

        public EqupmentType GetEqupmentType => equipmentType;
        public ItemDuration GetDuration => duration;
        public GameObject Prefab => prefab;

        public Sprite Icon => icon;
        public float Price => price;
        public string ItemName => itemName;
        public Buff[] Buffs => buffs;

    }

    
}
