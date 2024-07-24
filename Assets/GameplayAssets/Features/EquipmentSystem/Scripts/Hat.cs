namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Hat", menuName = "SO/Equipment/Hats")]
    public class Hat : AbstractEquipmentObject
    {
        [SerializeField] protected string bonusStatName = string.Empty;
        [SerializeField] protected int bonusStatValue = 0;

        public string BonusStatName => bonusStatName;
        public int BonusStatValue => bonusStatValue;
    }
}

