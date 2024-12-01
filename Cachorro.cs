using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Cachorro : Personagem //criando classe "cachorro" herdando da classe personagem 
{
    public static int InstanciasCachorro = 0; //contando o número inicial de cachorros

    GameObject ccachorro; //chamando o gameobject cachorro
    float velocidade; //chamando o script "velocidade"
 

    public bool Vida { get; set; } //instanciando a propriedade "vida"
   

  
    public Cachorro(Vector3 posicao, bool vida, GameObject ccachorro) //constructor da classe "cachorro"
    {
        this.Posicao = posicao; //validando a propriedade "posicao"
        this.Vida = vida; //validando a propriedade "vida"
    }

  
   
}
    

 
