using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] Animator animatorLogo;
    [SerializeField] Animator animatorBotonPlay;
    [SerializeField] Button botonIniciar;
    [SerializeField] Animator textoSeleccionar;

    public void Prueba()
    {
        Debug.Log("Prueba");
        animatorLogo.Play("MovimientoLogo");
        animatorBotonPlay.Play("FadeOutButtonPlay");
        textoSeleccionar.enabled = true;
        botonIniciar.enabled = false;
    }
}
