namespace HeatsGame.Features.EquipmentSystem
{
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class AbstractPlayerStats : ScriptableObject
    {
        [SerializeField] protected Dictionary<Stats, float> stats = new Dictionary<Stats, float>();

        [SerializeField] protected float damage = 0f;
        [SerializeField] protected float speed = 0f;
        [SerializeField] protected float jumpForce = 0f;
        [SerializeField] protected float attackRange = 0f;

        protected void Awake()
        {
            stats[Stats.Damage] = damage;
            stats[Stats.Speed] = speed;
            stats[Stats.JumpForce] = jumpForce;
            stats[Stats.AttackRange] = attackRange;
        }

        public abstract float GetStats(Stats stat);

        public abstract void SetStats(Stats stat, float value);
 
    }
}

