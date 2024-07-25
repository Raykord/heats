namespace HeatsGame.Features.EquipmentSystem
{

    [System.Serializable]
    public class Buff
    {
        [UnityEngine.SerializeField] protected Stats stat = 0;
        [UnityEngine.SerializeField] protected float bonusValue = 0f;
    }
}