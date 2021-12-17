using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if (GameControlScript.health > 0)
            { GameControlScript.health -= 1; }
           // HealthManager.instance1.ChangeHealth(GameControlScript.health);
        }
    }

}
