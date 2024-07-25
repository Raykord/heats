namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Hat", menuName = "SO/Equipment/Hats")]
    public class Hat : AbstractEquipmentObject
    {
        [SerializeField] protected Buff[] buffs;
    }
}

