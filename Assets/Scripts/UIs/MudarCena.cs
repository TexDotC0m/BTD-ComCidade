using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using static UnityEditor.PlayerSettings;

public class MudarCena : MonoBehaviour
{

    public TMP_Text score;
    public static int lixoColetado = 0;
    public static bool funcaoChamada = false;
    public static bool miniGameIniciado = false; // tem que colocar isso toda vez que for iniciar uma cena de minigame
    private IEnumerator coroutine;



    private void Start()
    {
      StartCoroutine(PausaPonto());
    }


    private void Update()
    {
        
    }

    private IEnumerator PausaPonto()
    {
           score.SetText(lixoColetado.ToString());
           yield return new WaitUntil(() => funcaoChamada == true);
    }


    public void MiniGameFlappyBird()
    {
        miniGameIniciado = true;
        SceneManager.LoadScene("Flappy");
    }
    
    public void MiniGameFlappyBirdRules()
    {
        SceneManager.LoadScene("FlappyBirdRules");
        //Deixa o cursor visível
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public static void MainGameCidade()
    {
        miniGameIniciado = false;
        funcaoChamada = false;
        SceneManager.LoadScene("Cidade");
        PlayerPrefs.GetFloat("Timer.timeLeft");
        PlayerPrefs.GetFloat("score");

    }

    public void VoltaProMenu()
    {
        miniGameIniciado = false;
        SceneManager.LoadScene("Menu");
    }

    public static void ObjetivoConcluido()
    {
        miniGameIniciado = false;
        funcaoChamada = true;
        lixoColetado++;
        PlayerPrefs.SetInt("score", lixoColetado);
        MainGameCidade();
    }

    public static void ObjetivoNaoConcluido()
    {
        miniGameIniciado = false;
        SceneManager.LoadScene("Derrota");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void SalvarVariaveis()
    {
        PlayerPrefs.SetInt("score", lixoColetado);
    }

    public static void TimeOut()
    {
        miniGameIniciado = false;
        SceneManager.LoadScene("TimeOut");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

   


}
