using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour //criando o script NPC, que herda de monobehaviour (executável do unity) 
{
    Vector3 posicao; //chamando a propriedade posicao 
    GameObject ppessoa; //chamando o gameobjectppessoa
    Pessoas personagem; //chamando a classe pessoas
    int aleatorio; //criando a propriedade aleatorio
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Pessoas.InstanciasPessoas); 
        Pessoas.InstanciasPessoas = 0; //definindo contador inicial para a quantidade de pessoas geradas
    }
    // Update is called once per frame
    void Update()
    {
      
        if (Pessoas.InstanciasPessoas < 5 ) { //limitador de pessoas geradas
            aleatorio = Random.Range(1, 3); //definindo um número aleatóio de 1 a 3 para a geração de gameobject
            posicao = new Vector3(Random.Range(-10,-32f), -1f, Random.Range(16f, -50f)); //definindo a posição que os gameobjects serão gerados
            transform.position = posicao;

            ppessoa = Instantiate(Resources.Load($"Pessoa{aleatorio}"), posicao, Quaternion.Euler(0f,180f,0f)) as GameObject; //instânciando o objeto ppessoa
            Pessoas pessoa = new Pessoas(transform.position, ppessoa); //gerando o objeto
        

        }
       

    }
        
    
}
