using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 100;

        public void TakeDamege(float damage)
        {
            health = Mathf.Max(health - damage, 0);
            print(health);
        }    
    }

}
