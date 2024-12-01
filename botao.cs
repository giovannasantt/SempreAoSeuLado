using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botao : MonoBehaviour //criando o script botao, que herda do monobehaviour (executável do unity)
{
    public void Jogar() //criando o método jogar
    {
        SceneManager.LoadScene("Jogo"); //definindo a cena que será iniciada quando o método for executado
    }
    public void Sair() //criando o método sair
    {
        Application.Quit(); //definindo que o jogo será fechado quando o método for executado
    }
    public void Reiniciar() //criando o método reiniciar
    {
        SceneManager.LoadScene("Jogo"); //definindo a cena que será iniciada quando o método for executado
    }
    public void Voltar() //criando o método voltar
    {
        SceneManager.LoadScene("Inicio"); //definindo a cena que será iniciada quando o método for executado
    }


}
