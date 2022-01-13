using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public SomGenerator somgen;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    // Start is called before the first frame update
   public void answer1Pressed(){
        somgen = GameObject.FindObjectOfType(typeof(SomGenerator)) as SomGenerator;
        somgen.CheckAnswer(answer1.text);
    }

    void answer2Pressed(){
        
    }

    void answer3Pressed(){
        
    }

 
}
