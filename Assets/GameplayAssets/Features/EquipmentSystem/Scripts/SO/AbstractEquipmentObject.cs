namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    public abstract class AbstractEquipmentObject : ScriptableObject
    {
        [SerializeField] protected GameObject prefab = null;
        [SerializeField] protected string itemName = string.Empty;
        [SerializeField, TextArea(1, 10)] protected string description = string.Empty;
        [SerializeField] protected EqupmentType equipmentType = 0;
        [SerializeField] protected ItemDuration duration = null;
        [SerializeField] protected Buff[] buffs = null;

        public EqupmentType GetEqupmentType => equipmentType;
        public ItemDuration GetDuration => duration;
        public GameObject Prefab => prefab;

        public Buff[] Buffs => buffs;

    }

    
}
