using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleButtons : MonoBehaviour, I_SmartwallInteractable
{
    // Start is called before the first frame update
    private Button button;
    bool guess = false;

    public void Btn1Clicked()
    {
        
        SomGenerator.id = 1;   
    }

    public void Btn2Clicked()
    {
        SomGenerator.id = 2;
    }

    public void Btn3Clicked()
    { 
        SomGenerator.id = 3;
    }

    IEnumerator delay(float time = 1f)
    {
        yield return new WaitForSeconds(time);
        guess = false;
    }
    // Update is called once per frame
    void Update()
    {
    }

  
    public void Hit(Vector3 location)
    {
        if(guess) { return; }
        button = gameObject.GetComponent<Button>();
        guess = true;
        button.onClick.Invoke();
        StartCoroutine(delay(1));
    }


  
}
