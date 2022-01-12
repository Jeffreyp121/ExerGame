using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    public Scene scene;
    public GameObject heart1, heart2, heart3, gameOver;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 2;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }


    bool TimerElapsed()
    {
        if (time < 0) { return true; }
        time -= Time.deltaTime;

        return false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(time);
        if (characterVariables.instance.health > 3)
        {
            characterVariables.instance.health = 3;
        }
        switch (characterVariables.instance.health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;

            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                if (TimerElapsed())
                {
                    Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
                    //time = 2;
                    characterVariables.instance.health = 3;
                }

                break;

            default:
               
                break;
        }



    }
}
