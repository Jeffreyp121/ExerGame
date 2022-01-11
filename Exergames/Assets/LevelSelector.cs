using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour, I_SmartwallInteractable
{
    Button buton;
    public void Terug ()
    {
        SceneManager.LoadScene("MenuNew");
    }

    public void Level1 ()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2 ()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3 ()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void NextScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Hit(Vector3 location)
    {
        buton = gameObject.GetComponent<Button>();
        buton.onClick.Invoke();
    }
}
