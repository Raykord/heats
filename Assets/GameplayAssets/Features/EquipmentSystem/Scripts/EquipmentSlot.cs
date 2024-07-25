namespace HeatsGame.Features.EquipmentSystem
{
    [System.Serializable]
    public class EquipmentSlot 
    {
        [UnityEngine.SerializeField] protected EqupmentType equipmentType = 0;
        [UnityEngine.SerializeField] protected AbstractEquipmentObject equipmentObject = null;

        public EqupmentType EqupmentType => equipmentType;
        public AbstractEquipmentObject EquipmentObject => equipmentObject;

        public EquipmentSlot(EqupmentType type) 
        {
            equipmentType = type;
        }
    }
}
