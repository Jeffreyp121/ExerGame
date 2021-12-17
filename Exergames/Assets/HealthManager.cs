using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance1;
    public TextMeshProUGUI text;
    int Health = 3;

    // Start is called before the first frame update
    void Start()
    {
        if (instance1 == null)
        {
            instance1 = this;
        }
    }

    // Update is called once per frame
    public void ChangeHealth(int healthValue)
    {
        Health = healthValue;
        text.text = Health.ToString();
    }
}
