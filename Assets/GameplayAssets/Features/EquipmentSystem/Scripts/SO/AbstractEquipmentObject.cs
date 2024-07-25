namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    public abstract class AbstractEquipmentObject : ScriptableObject
    {
        [SerializeField] protected GameObject prefab;
        [SerializeField] protected string itemName;
        [SerializeField, TextArea(1, 10)] protected string description;
        [SerializeField] protected EqupmentType equipmentType;
        [SerializeField] protected ItemDuration duration;

        public EqupmentType GetEqupmentType => equipmentType;
        public ItemDuration GetDuration => duration;

    }

    
}
