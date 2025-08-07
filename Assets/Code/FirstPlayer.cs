using UnityEngine;

namespace Code
{
    public class FirstPlayer : MonoBehaviour
    {
        
        public MeshRenderer ColorPlayer;
        public bool IsDead;
        public bool IsFriendly;
        public int HealthFirstPlayer;
        public int Attack;

        
            
        

        private void Awake()
        {
            ColorPlayer.material.color = Color.gray;
        }

        private void Start()
        {
            if (ColorPlayer.material.color == Color.gray)
            {
                IsFriendly = true;
                ColorPlayer.material.color = Color.blue;
            }
            else if(ColorPlayer.material.color != Color.gray)
            {
                IsFriendly = false;
                ColorPlayer.material.color = Color.red;
                
            }
        }

        private void OnValidate()
        {
            HealthFirstPlayer = 100;
            
            Damage(Attack);
            
            if (HealthFirstPlayer <= 0)
            {
                HealthFirstPlayer = 0;
            }
            else if (HealthFirstPlayer >= 100)
            {
                HealthFirstPlayer = 100;
            }
            if (HealthFirstPlayer == 0 )
            {
                IsDead = true;
                Debug.LogError("IsDead");
                gameObject.SetActive(false);
            }
        }

        private void Damage(int attackPower)
        {
            var multiplier = Random.Range(1f, 1.5f);
            HealthFirstPlayer -= (int)(attackPower * multiplier);
        }
    }
}