using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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

    //Sommen
    float[] xplus = { 98, 168, 170, 60, 205, 303, 224, 456, 444, 599, 672 }; //Eerste getal in de som
    float[] yplus = { 7, 90, 6, 80, 25, 45, 22, 89, 66, 32, 56 }; //Tweede getal in de som

    float[] xplus_ = { 666, 90, 111, 254, 398, 66, 654, 297, 888, 453, 32 };
    float[] yplus_ = { 689, 236, 291, 303, 452, 177, 747, 332, 999, 765, 123 };

    float[] xmin = { 105, 232, 444, 756, 378, 32, 849, 654 };
    float[] ymin = { 33, 45, 87, 132, 54, 11, 47, 91 };

    float[] xmin_ = { 475, 332, 946, 654, 276, 532, 487, 799, 518, 328 };
    float[] ymin_ = { 402, 287, 728, 589, 177, 501, 432, 688, 466, 267 };

    float[] xkeer = { 5, 4, 7, 6, 3, 8, 3, 9, 5, 6 };
    float[] ykeer = { 9, 50, 4, 40, 9, 60, 80, 30, 9, 7 };

    public static int nrCorrect = 0;
    float correct = 0;
    bool answerCorrect = false;

    float time = 0;
    float startTime = 12; //Tijd voor een som

    public Image healthBar;
    public AudioSource timer;
    public AudioSource boem;
    public AudioSource fout;
    public AudioSource goed;

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = btnAnswer1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

        Button btn2 = btnAnswer2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);

        Button btn3 = btnAnswer3.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);
        time = startTime;
        text.text = characterVariables.instance.coins.ToString();
        nrCorrect = 0;
        GenerateSom();

    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthBar();

        if (nrCorrect == 5)
        {
            characterVariables.instance.health= 3;
            nrCorrect = 0;
            SceneManager.LoadScene("LevelKeuze");
        }
        if (answerCorrect || TimerElapsed()) 
        {
            if (!answerCorrect)
            {
                boem.Play();
            }
            time = startTime;
            answerCorrect = false;
            GenerateSom();
            timer.Play();
        }
        Debug.Log(time);
    }

    void GenerateSom()
    {
        int j = Random.Range(0, 5); //Type som kiezen

        if (j == 0) //Plussom
        {
            int i = Random.Range(0, xplus.Length); //Random som kiezen
            correct = xplus[i] + yplus[i];
            somText.text = $"{xplus[i]} + {yplus[i]} =";
        } else if (j == 1) //Minsom
        {
            int i = Random.Range(0, xmin.Length); //Random som kiezen
            correct = xmin[i] - ymin[i];
            somText.text = $"{xmin[i]} - {ymin[i]} =";
        } else if (j == 2) //keersom
        {
            int i = Random.Range(0, xkeer.Length); //Random som kiezen
            correct = xkeer[i] * ykeer[i];
            somText.text = $"{xkeer[i]} x {ykeer[i]} =";
        } else if (j == 3) //plussom 2
        {
            int i = Random.Range(0, xplus_.Length); //Random som kiezen
            correct =  yplus_[i] - xplus_[i];
            somText.text = $"{xplus_[i]} + ..... = {yplus_[i]}";
        } else if (j == 4) //minsom 2
        {
            int i = Random.Range(0, xmin_.Length); //Random som kiezen
            correct = xmin_[i] - ymin_[i];
            somText.text = $"{xmin_[i]} - ..... = {ymin_[i]}";
        }

        float wrong1 = correct + Random.Range(1, 10);
        float wrong2 = correct - Random.Range(1, 10);

        answers.Add(correct);
        answers.Add(wrong1);
        answers.Add(wrong2);

        int A = 0;

        A = Random.Range(0, answers.Count);
        answer1.text = $"{answers[(int)A]}";
        answers.RemoveAt((int)A);
        A = Random.Range(0, answers.Count);
        answer2.text = $"{answers[(int)A]}";
        answers.RemoveAt((int)A);
        A = Random.Range(0, answers.Count);
        answer3.text = $"{answers[(int)A]}";
        answers.RemoveAt((int)A);
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
            goed.Play();
        }
        else {
            Debug.Log("Wrong");
            characterVariables.instance.UpdateHealth(1);
            fout.Play();
        }
    }

    bool TimerElapsed()
    {
        if (time < 0) { return true; }
        time -= Time.deltaTime;
        return false;
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = Mathf.Clamp(time / startTime, 0, 1f);
    }
}