using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator animatorTransicion;

    public void PulsarArea()
    {
        animatorTransicion.Play("FadeOutTransicion");
    }

    public void Area1()
    {
        SceneManager.LoadScene("Area1");
    }

    public void Area2()
    {
        SceneManager.LoadScene("Area2");
    }

    public void Area3()
    {
        SceneManager.LoadScene("Area3");
    }

    public void Area4()
    {
        SceneManager.LoadScene("Area4");
    }

    public void Area5()
    {
        SceneManager.LoadScene("Area5");
    }

    public void Area6()
    {
        SceneManager.LoadScene("Area6");
    }

    public void Menu()
    {

    }
}
