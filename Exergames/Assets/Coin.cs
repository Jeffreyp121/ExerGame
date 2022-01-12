using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManager.instance2.ChangeScore(coinValue);
            characterVariables.instance.UpdateCoins(1);
            audioSource.Play();
        }
    }
}
