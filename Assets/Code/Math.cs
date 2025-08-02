using UnityEngine;

namespace Code
{
    public class Math : MonoBehaviour
    {
        private void OnValidate()
        {
            First();
        }

        private void First()
        {
            byte num = 11;
            float numf = 10.5f;
            var player = "isDead";
            bool numder = num > numf;

            Debug.LogError(num);
            Debug.LogError(numf);
            Debug.LogError(numder);
            Debug.LogError(player);
        }
    }
}

