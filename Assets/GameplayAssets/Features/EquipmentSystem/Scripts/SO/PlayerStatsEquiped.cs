


namespace HeatsGame.Features.EquipmentSystem
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Player stats", menuName = "SO/Player/Player stats equiped")]
    public class PlayerStatsEquiped : AbstractPlayerStats
    {
        [SerializeField] protected AbstractPlayerStats defaultStats = null;
        [SerializeField] protected PlayerInventory items = null;

        public override float GetStats(Stats stat)
        {
            float bonus = 0f;
            
            if (items != null)
            {
                foreach (var item in items.GetSlots())
                {
                    if (item.EquipmentObject != null)
                    {
                        foreach (var buff in item.EquipmentObject.Buffs)
                        {
                            if (buff.Stat == stat)
                            {
                                bonus += buff.BonusValue;
                            }
                        }
                    }

                }
            }
            

            return defaultStats.GetStats(stat) + bonus;
        }

        public override void SetStats(Stats stat, float value)
        {
            stats[stat] = value;
        }


    }
}