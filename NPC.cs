using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    Vector3 posicao;
    GameObject ppessoa;
    Pessoas personagem;
    int aleatorio;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Pessoas.InstanciasPessoas);
        Pessoas.InstanciasPessoas = 0;
    }
    // Update is called once per frame
    void Update()
    {
      
        if (Pessoas.InstanciasPessoas < 5 ) {
            aleatorio = Random.Range(1, 3);
            posicao = new Vector3(Random.Range(-10,-32f), -1f, Random.Range(16f, -50f));
            transform.position = posicao;

            ppessoa = Instantiate(Resources.Load($"Pessoa{aleatorio}"), posicao, Quaternion.Euler(0f,180f,0f)) as GameObject;
            Pessoas pessoa = new Pessoas(transform.position, ppessoa);
        

        }
        /*else if (Pessoas.InstanciasPessoas >= 4)
        {
            Destroy(this.gameObject.CompareTag("Pessoa"));
            Pessoas.InstanciasPessoas--;
            
        }*/


    }
        
    
}
