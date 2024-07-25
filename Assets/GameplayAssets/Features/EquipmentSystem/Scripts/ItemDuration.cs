namespace HeatsGame.Features.EquipmentSystem
{

    [System.Serializable]
    public class ItemDuration
    {
        [UnityEngine.SerializeField] private float days = 0;
        [UnityEngine.SerializeField] private float hours = 0;
        [UnityEngine.SerializeField] private float minutes = 0;

        public float Days => days;
        public float Hours => hours;
        public float Minutes => minutes;
    }
}

