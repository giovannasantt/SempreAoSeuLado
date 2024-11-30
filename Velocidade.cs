using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour
{

    Vector3 velocidade;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        velocidade.z = 0.5f;

        if (transform.position.z > -183f)
        {
            velocidade.x = 0f;
            velocidade.y = 0f;
            velocidade.z = 0.5f;
            transform.Translate(velocidade);
        }
        else if (Pessoas.InstanciasPessoas == 5)
        {
            Pessoas.InstanciasPessoas--;
            Destroy(this.gameObject);
        }
    }
}
