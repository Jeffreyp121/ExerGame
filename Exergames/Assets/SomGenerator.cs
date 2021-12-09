using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomGenerator : MonoBehaviour
{
    /*public Text somText;
    public Text answer1;
    public Text answer2;
    public Text answer3;*/
    public List<float> answers = new List<float>();
    public List<char> soms = new List<char>();

    // Start is called before the first frame update
    void Start()
    {
        GenerateSom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateSom()
    {
        SetUpCalculationMethods();

        float i = Random.Range(0, soms.Count - 1);
        char method = soms[(int)i];
        float x = 0;
        float y = 0;
        float correct = 0;
        switch (method)
        {
            case '+':
                x = Random.Range(100, 1000);
                y = Random.Range(100, 1000);
                correct = x + y;
                break;

            case '-':
                x = Random.Range(100, 1000);
                y = Random.Range(100, 1000);
                correct = x - y;
                break;
            case '*':
                x = Random.Range(1, 10);
                y = Random.Range(1, 10);
                correct = x * y;
                break;

            case ':':
                x = Random.Range(1, 10);
                y = Random.Range(1, 10);
                correct = x / y;
                break;

            default:
                break;
        }
        //somText.text = $"{x} {method} {y} =";

        float wrong1 = correct + Random.Range(1, 10);
        float wrong2 = correct - Random.Range(1, 10);

        answers.Add(correct);
        answers.Add(wrong1);
        answers.Add(wrong2);

        /*i = Random.Range(0, answers.Count - 1);
        answer1.text = $"{answers[(int)i]}";
        answers.RemoveAt((int)i);
        i = Random.Range(0, answers.Count - 1);
        answer2.text = $"{answers[(int)i] }";
        answers.RemoveAt((int)i);
        i = Random.Range(0, answers.Count - 1);
        answer3.text = $"{answers[(int)i] }";
        answers.RemoveAt((int)i);*/
    }

    void SetUpCalculationMethods()
    {
        soms.Add('+');
        soms.Add('-');
        soms.Add('*');
        soms.Add(':');
    }

}
