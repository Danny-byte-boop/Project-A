using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    float elasped = 0f;
    void Update()
    {
        elasped += Time.deltaTime;
        int min = Mathf.FloorToInt(elasped / 60);
        int sec = Mathf.FloorToInt(elasped % 60);
        timerText.text = string.Format("{0:00}:{1:00}" , min, sec);
    }
   
}
//I searched "Unity timer" on google and it helped me with formatting it. I understood how to do the math portion but needed help with the certain reference for the text "TextMeshProUGUI" and finally got it working.
//Time.deltaTime basically tracks the timer and then it gets updated when the scene starts; I don't need a start method because it just updates automatically.
//https://search.brave.com/ask?q=unity+timer&conversation=09a3d8bd9dd22721e262ea32dd72d4ba142b#2MKIu9SnhAdqfhzNhepgKqXCRe1y1Gf835bj18NxIqU
