
using System;
using UnityEngine;
using Random = UnityEngine.Random;

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
            float StartHealth = 100;
            float DamageAfterStart = Random.Range(0, 15f);
            float result = StartHealth - DamageAfterStart;


            Debug.LogWarning($"Player {result} Health");
        }

        private void SummaDamage(float basedamage)
        {
            float BaseHP = 100;
            
            float multiplier = Random.Range(1f, 2f);
            
            float Damage = (basedamage * multiplier);
            
            Debug.LogWarning($"Health {BaseHP - Damage}");


        }
         
    }
    
    
}