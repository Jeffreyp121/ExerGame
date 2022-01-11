using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour, I_SmartwallInteractable
{
    Button start;
    public void PlayGame ()
    {
        SceneManager.LoadScene("LevelKeuze");
    }

    public void StopGame ()
    {
        Application.Quit();
    }

    public void Hit(Vector3 location)
    {
        start = gameObject.GetComponent<Button>();
        start.onClick.Invoke();
    }
}
