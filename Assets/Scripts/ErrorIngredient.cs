using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorIngredient : MonoBehaviour
{
    public GameObject fuego;
    public GameObject humo;
    public GameObject fondo;
    public AudioSource error;
    public GameObject timer;
    public GameObject derrota;
        
    private void Start()
    {
        if (error == null)
        {
            error = GetComponent<AudioSource>();
        }
        error.Stop();
        Debug.Log("fuego");
    }

    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        fuego.SetActive(true);
        humo.SetActive(false);
        fondo.SetActive(false);
        Debug.Log("l");
        error.Play();
        Destroy(timer);
        derrota.SetActive(true);
    }

}