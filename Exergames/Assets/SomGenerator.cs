using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SomGenerator : MonoBehaviour
{
    public List<float> answers = new List<float>();
    public List<char> soms = new List<char>();

    public Text somText;
    public Text answer1;
    public Text answer2;
    public Text answer3;
 
    public Button btnAnswer1;
    public Button btnAnswer2;
    public Button btnAnswer3;

    int nrCorrect = 0;
    float correct = 0;
    bool answerCorrect = false;
    float time = 6;
    // Start is called before the first frame update
    void Start()
    {
        
        Button btn1 = btnAnswer1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

        Button btn2 = btnAnswer2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);

        Button btn3 = btnAnswer3.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);
        GenerateSom();
    }

    // Update is called once per frame
    void Update()
    {
        if(nrCorrect == 5)
        {
            SceneManager.LoadScene("Menu");
        }
        if (answerCorrect || TimerElapsed()) 
        {
            time = 6;
            answerCorrect = false;
            GenerateSom(); 
        }
        Debug.Log(time);
        
        
    }

    void GenerateSom()
    {
        SetUpCalculationMethods();

        float i = Random.Range(0, soms.Count - 1);
        char method = soms[(int)i];
        float x = 0;
        float y = 0;
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
                if(x< y)
                {
                    float t = y;
                    x = y;
                    y = t;
                }
                correct = x - y;
                break;
            case '*':
                x = Random.Range(1, 10);
                y = Random.Range(1, 10);
                correct = x * y;
                break;

            /*case ':':
                x = Random.Range(1, 10);
                y = Random.Range(1, 10);
                correct = x / y;
                break;*/

            default:
                break;
        }
        somText.text = $"{x} {method} {y} =";

        float wrong1 = correct + Random.Range(1, 10);
        float wrong2 = correct - Random.Range(1, 10);

        answers.Add(correct);
        answers.Add(wrong1);
        answers.Add(wrong2);

        i = Random.Range(0, answers.Count);
        answer1.text = $"{answers[(int)i]}";
        answers.RemoveAt((int)i);
        i = Random.Range(0, answers.Count);
        answer2.text = $"{answers[(int)i] }";
        answers.RemoveAt((int)i);
        i = Random.Range(0, answers.Count);
        answer3.text = $"{answers[(int)i] }";
        answers.RemoveAt((int)i);
    }

    void SetUpCalculationMethods()
    {
        soms.Add('+');
        soms.Add('-');
        soms.Add('*');
        //soms.Add(':');
    }


    void TaskOnClick1()
    {
        CheckAnswer(answer1.text);
        Debug.Log("You have clicked 1 button!");
    }

    void TaskOnClick2()
    {
        CheckAnswer(answer2.text);
        Debug.Log("You have clicked 2 button!");
    }

    void TaskOnClick3()
    {
        CheckAnswer(answer3.text);
        Debug.Log("You have clicked 3 button!");
    }

    void CheckAnswer(string text)
    {
        Debug.Log($" correct:{correct}  Guessed:{text}");
        if (correct == float.Parse(text))
        {
            Debug.Log("Good Job!");
            answerCorrect = true;
            nrCorrect++;
        }
        else {
            Debug.Log("Wrong");
        }
    }

    bool TimerElapsed()
    {
        if (time < 0) { return true; }
        time -= Time.deltaTime;
        return false;
    }
}
