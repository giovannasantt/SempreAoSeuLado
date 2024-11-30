using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personagem
{

    public static int Instancias = 0;

    public float Velocidade {  get; set; }
    public Vector3 Posicao { get; set; }
    public static GameObject cachorro = new GameObject();
    public Personagem()
    {
        Instancias++;
    }
    public Personagem(float velocidade, Vector3 posicao, GameObject modelo)
    {
        Instancias++;
        this.Velocidade = velocidade;
        this.Posicao = posicao;
    
    }
   /* public void Ganhar(bool vida){
        if (vida == true)
        {
            SceneManager.LoadScene("Final");
        }

    }
    public void Perder(bool vida)
    {
       if( vida == false)
        {
            SceneManager.LoadScene("Inicio");
        }
       
    }*/
}
