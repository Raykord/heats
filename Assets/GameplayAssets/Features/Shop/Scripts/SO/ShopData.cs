namespace HeatsGame.Features.Shop
{
    using UnityEngine;
    using HeatsGame.Features.EquipmentSystem;
    using System.Collections.Generic;

    [CreateAssetMenu(fileName = "ShopData", menuName = "SO/Shop/Shop Data")]
    public class ShopData : ScriptableObject
    {
        [SerializeField] protected List<AbstractEquipmentObject> equipment = new List<AbstractEquipmentObject>();

        public List<AbstractEquipmentObject> Equipment => equipment;
    }
}

