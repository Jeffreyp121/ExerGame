using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject key0, key1, key2, key3, key4, key5;
    int Keystate;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Keystate = SomGenerator.nrCorrect;
        switch (Keystate)
        {
            case 0:
                key0.gameObject.SetActive(true);
                key1.gameObject.SetActive(false);
                key2.gameObject.SetActive(false);
                key3.gameObject.SetActive(false);
                key4.gameObject.SetActive(false);
                key5.gameObject.SetActive(false);
                break;

            case 1:
                key0.gameObject.SetActive(false);
                key1.gameObject.SetActive(true);
                key2.gameObject.SetActive(false);
                key3.gameObject.SetActive(false);
                key4.gameObject.SetActive(false);
                key5.gameObject.SetActive(false);
                break;

            case 2:
                key0.gameObject.SetActive(false);
                key1.gameObject.SetActive(false);
                key2.gameObject.SetActive(true);
                key3.gameObject.SetActive(false);
                key4.gameObject.SetActive(false);
                key5.gameObject.SetActive(false);
                break;

            case 3:
                key0.gameObject.SetActive(false);
                key1.gameObject.SetActive(false);
                key2.gameObject.SetActive(false);
                key3.gameObject.SetActive(true);
                key4.gameObject.SetActive(false);
                key5.gameObject.SetActive(false);
                break;

            case 4:
                key0.gameObject.SetActive(false);
                key1.gameObject.SetActive(false);
                key2.gameObject.SetActive(false);
                key3.gameObject.SetActive(false);
                key4.gameObject.SetActive(true);
                key5.gameObject.SetActive(false);
                break;

            case 5:
                key0.gameObject.SetActive(false);
                key1.gameObject.SetActive(false);
                key2.gameObject.SetActive(false);
                key3.gameObject.SetActive(false);
                key4.gameObject.SetActive(false);
                key5.gameObject.SetActive(true);
                break;

            default:

                break;
        }
    }
}
