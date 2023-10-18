using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0;
    public Text textoTimer;
    private bool derrotaProcesada = false;

    public GameObject fuego;
    public GameObject humo;
    public GameObject fondo;
    public AudioSource error;


    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            textoTimer.text = "" + timer.ToString("f1");
        }
        else
        {
            if (!derrotaProcesada) 
            {
                timer = 0;
                Derrota();
                derrotaProcesada = true; 
            }
        }
    }

    void Derrota()
    {
        Debug.Log("Lose Menu");
        textoDerrota("Error");
        fuego.SetActive(true);
        humo.SetActive(false);
        fondo.SetActive(false);
        Debug.Log("l");
        error.Play();
    }

    private void textoDerrota(string mensaje)
    {
        if (textoTimer != null)
        {
            textoTimer.text = mensaje;
        }
    }
}