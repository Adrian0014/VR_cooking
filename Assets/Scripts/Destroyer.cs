using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{
    //public Text textoHud; 
    public AudioSource sonido;
    public GameObject ratatouille;
    public GameObject olladeagua;
    public ParticleSystem particulas;
    public GameObject humoagua;
    public AudioSource agua;

    public enum TipoAlimento
    {
        Alimento1,
        Alimento2,
        Alimento3,
        Alimento4
    }

    private TipoAlimento tipoAlimentoActual = TipoAlimento.Alimento1;

    private void Start()
    {
        // Asegúrate de tener un AudioSource adjunto al objeto
        if (sonido == null)
        {
            sonido = GetComponent<AudioSource>();
        }

        // Desactivar el sonido al inicio
        sonido.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (tipoAlimentoActual == TipoAlimento.Alimento1 && other.CompareTag("Alimento1"))
        {
            
            Destroy(other.gameObject);
            tipoAlimentoActual = TipoAlimento.Alimento2;
            //TextoHud("Introduce alimento 2");
            particulas.Play();
            sonido.Play();

        }
        else if (tipoAlimentoActual == TipoAlimento.Alimento2 && other.CompareTag("Alimento2"))
        {
            Destroy(other.gameObject);
            tipoAlimentoActual = TipoAlimento.Alimento3;
            particulas.Play();
            sonido.Play();
        }
        else if (tipoAlimentoActual == TipoAlimento.Alimento3 && other.CompareTag("Alimento3"))
        {
            Destroy(other.gameObject);
            tipoAlimentoActual = TipoAlimento.Alimento4;
            particulas.Play();
            sonido.Play();
        }
        else if (tipoAlimentoActual == TipoAlimento.Alimento4 && other.CompareTag("Alimento4"))
        {
            ratatouille.SetActive(true);
            olladeagua.SetActive(false);
            Destroy(other.gameObject);
            //TextoHud("Bien hecho");
            Debug.Log("Prueba1");
            olladeagua.SetActive(false);
            humoagua.SetActive(false);
            particulas.Play();
            sonido.Play();
            agua.Stop();
            
        }

    }

    /*private void TextoHud(string mensaje)
    {
        if (textoHud != null)
        {
            textoHud.text = mensaje;
        }
    }*/
}