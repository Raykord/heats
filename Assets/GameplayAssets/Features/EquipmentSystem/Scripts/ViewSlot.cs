namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    public class ViewSlot : MonoBehaviour
    {
        [SerializeField] protected EqupmentType equpmentType = 0;


        public EqupmentType EqupmentType => equpmentType;
    }
}

