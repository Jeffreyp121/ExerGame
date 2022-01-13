using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour, I_SmartwallInteractable
{
    Button button;
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
        button = gameObject.GetComponent<Button>();
        button.onClick.Invoke();
    }
}
