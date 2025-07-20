using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code
{
    public class PlayDamage : MonoBehaviour

    {
        private void OnValidate()
        {
            SummaDamage(Attack);
        }

        public float Attack;
        
        private void SummaDamage(float basedamage)
        {
            float BaseHP = 100;
            
            float multiplier = Random.Range(1f, 2f);
            
            float Damage = (basedamage * multiplier);
            
            Debug.LogWarning($"Health {BaseHP - Damage}");


        }
    }
}