using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personagem //criando a classe Personagem
{

    public static int Instancias = 0; //contador inicial 

    public float Velocidade {  get; set; } //instanciando a propriedade velocidade
    public Vector3 Posicao { get; set; } //instanciando a propriedade posicao
    public static GameObject cachorro = new GameObject(); //criando um novo gameobject para o cachorro
   
    public Personagem(float velocidade, Vector3 posicao, GameObject modelo) //constructor da classe personagem
    {
        Instancias++; //executando o contador
        this.Velocidade = velocidade; //validando a propriedade velocidade
        this.Posicao = posicao; //validando a propriedade posicao
    
    }
 
}
