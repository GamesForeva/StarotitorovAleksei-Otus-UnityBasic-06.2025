using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
            var player1 = "isDead";
            bool TheNumder = num > numf;


            Debug.LogError(num);
            Debug.LogError(numf);
            Debug.LogError(TheNumder);
            Debug.LogError(player1);
        }
       
        

        
        

    }

}

