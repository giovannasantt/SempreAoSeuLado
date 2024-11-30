using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Cachorro : Personagem
{
    public static int InstanciasCachorro = 0;

    GameObject ccachorro;
    float velocidade;
 

    public bool Vida { get; set; }
   

  
    public Cachorro(Vector3 posicao, bool vida, GameObject ccachorro)
    {
        this.Posicao = posicao;
        this.Vida = vida;
    }

  
   
}
    

 
