using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour, I_SmartwallInteractable
{ 
    private Button button;
 
    
    public void Terug ()
    {
        SceneManager.LoadScene("MenuNew");
    }

    public void Level0()
    {
        SceneManager.LoadScene("Level 0 Tutorial");
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

    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void Level6()
    {
        SceneManager.LoadScene("Level 6");
    }

    /*public void NextScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/

    public void Hit(Vector3 location)
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.Invoke();
    }
}
