using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour //criando o script velocidade, que herda do monobehaviour (executável do unity)
{

    Vector3 velocidade; //chamando a propriedade velocidade
    // Start is called before the first frame update
    void Start()
    {
        velocidade = new Vector3(0, 0, 0); //definindo a posicao inicial 
    }

    // Update is called once per frame
    void Update()
    {
        velocidade.z = 0.5f; //definindo a velocidade do objeto

        if (transform.position.z > -183f) //código para movimentação básica do objeto
        {
            velocidade.x = 0f;
            velocidade.y = 0f;
            velocidade.z = 0.5f;
            transform.Translate(velocidade);
        }
        else if (Pessoas.InstanciasPessoas == 5) //limitador de pessoas geradas
        {
            Pessoas.InstanciasPessoas--;
            Destroy(this.gameObject);
        }
    }
}
