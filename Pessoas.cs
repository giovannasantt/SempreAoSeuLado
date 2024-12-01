using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pessoas : Personagem //criando a classe pessoas, herdando da classe personagem
{
    public static int InstanciasPessoas = 0; //contador inicial 
    GameObject ppessoa; //chamando o gameobject ppessoa
    float velocidade; //chamando a propriedade velocidade
  
    public Pessoas (Vector3 posicao, GameObject pessoa) //constructor da classe pessoas
    {
        InstanciasPessoas += 1; //definindo o valor do contador de pessoas
        this.Posicao = posicao; //validando a propriedade posicao
        this.ppessoa = pessoa; //validando o gameobject ppessoa

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
