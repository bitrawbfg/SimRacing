using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] Animator animatorLogo;
    [SerializeField] Animator animatorBotonPlay;
    [SerializeField] Animator textoSeleccionar;
    [SerializeField] Animator[] listaAreas = new Animator[6];

    public void Prueba()
    {
        Debug.Log("Prueba");
        animatorLogo.Play("MovimientoLogo");
        animatorBotonPlay.Play("FadeOutButtonPlay");
        textoSeleccionar.enabled = true;

        for (int i = 0; i < listaAreas.Length; i++)
        {
            listaAreas[i].enabled = true;
        }

        animatorBotonPlay.Play("MoveDownButtonPlay");
    }

    public void Prueba2()
    {
        Debug.Log("Prueba2");
    }
}
