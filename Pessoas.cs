using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pessoas : Personagem
{
    public static int InstanciasPessoas = 0;
    GameObject ppessoa;
    float velocidade;
  
    public Pessoas (Vector3 posicao, GameObject pessoa)
    {
        InstanciasPessoas += 1;
        this.Posicao = posicao;
        this.ppessoa = pessoa;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
