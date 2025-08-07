using UnityEngine;
using static UnityEngine.Random;

namespace Code
{
    public class StartDamage : MonoBehaviour
    {
        private void Start()
        {
            First();
        }
        
        public float Attack;
        
        private void OnValidate()
        {
            SummaDamage(Attack);
        }

        private void First()
        {
            float starthealth = 100;
            float damageafterstart = Range(0, 15f);
            float result = starthealth - damageafterstart;

            Debug.LogWarning($"Player {result} Health");
        }

        private void SummaDamage(float basedamage)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                float baseHP = 100;
                float multiplier = Range(1f, 2f);
                float damage = (basedamage * multiplier);
                float health = baseHP - damage;
                Debug.LogWarning($"Health {health}");;
                
            }
        }
    }
}