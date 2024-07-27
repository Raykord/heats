using System.Linq;
using UnityEngine;

namespace HeatsGame.Features.EquipmentSystem
{
    [CreateAssetMenu(fileName = "Player stats", menuName = "SO/Player/Player stats")]
    public class PlayerStats : AbstractPlayerStats
    {
        public override float GetStats(Stats stat)
        {
            return stats.Where(x => x.Key == stat).Select(x => x.Value).FirstOrDefault();
        }

        public override void SetStats(Stats stat, float value)
        {
            stats[stat] = value;
        }

        
    }
}

