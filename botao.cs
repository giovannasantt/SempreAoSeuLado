using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botao : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
    }
    public void Sair()
    {
        Application.Quit();
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene("Jogo");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("Inicio");
    }


}
