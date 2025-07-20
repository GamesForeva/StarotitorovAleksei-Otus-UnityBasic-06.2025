
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code

{
    public class StartDamage : MonoBehaviour

    {
        

        private void Start()
        {

            float StartHealth = 100;
            float DamageAfterStart = Random.Range(0, 15f);
            float result = StartHealth - DamageAfterStart;


            Debug.LogWarning($"Player {result} Health");
        }

        





    }
}