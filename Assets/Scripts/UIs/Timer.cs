using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerTxt;      // Referência ao componente de texto para mostrar o timer
    public static float timeLeft = 300;   // Tempo total em segundos
    public bool timerOn = false;   // Controle de estado do timer
    private float startTime;

    void Start()
    {
        startTime = Time.time;
        timerOn = true;
    }

    void Update()
    {
        if (timerOn)
        {
            float timeElapsed = Time.time - startTime;
            timeLeft = 300 - timeElapsed;
            if (timeLeft > 0)
            {
                updateTimer(timeLeft);
            }
            else
            {
                timeLeft = 0;
                timerOn = false;
                MudarCena.TimeOut();
            }
        }
    }


    void updateTimer(float currentTime)
    {
        
        int minutos = Mathf.FloorToInt(currentTime / 60);
        int segundos = Mathf.FloorToInt(currentTime % 60);

        
        timerTxt.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    public void pause()
    {
        timerOn = false;  
        PlayerPrefs.SetFloat("timerTxt", timeLeft); 
    }
}
