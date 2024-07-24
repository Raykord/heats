namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    public abstract class AbstractEquipmentObject : ScriptableObject
    {
        [SerializeField] protected GameObject prefab;
        [SerializeField] protected string name;
        [SerializeField] protected string description;


    }
}
