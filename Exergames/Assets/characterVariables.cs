using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterVariables : MonoBehaviour
{
    public static characterVariables instance { get; private set; }

    public int coins =0;
    public int health =3;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void UpdateHealth(int value)
    {
        health -= value;
    }

    public void UpdateCoins(int value)
    {
        coins += value;
        Debug.Log(coins);
    }

}
