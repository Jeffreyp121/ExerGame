using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameControlScript : MonoBehaviour
{
    public Scene scene;
    public GameObject heart1, heart2, heart3, gameOver;
    public float time;
    public TextMeshProUGUI text;

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
        text.text = characterVariables.instance.coins.ToString();
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
                    characterVariables.instance.coins = 0;
                    characterVariables.instance.health = 3;
                    Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
                    if(scene.name == "RekenScene")
                    {
                        SceneManager.LoadScene("LevelKeuze");
                    }
                    //time = 2;
                    
                }

                break;

            default:
               
                break;
        }



    }
}
