namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Hat", menuName = "SO/Equipment/Hat")]
    public class Hat : AbstractEquipmentObject
    {
        [SerializeField] protected Buff[] buffs;
    }
}

