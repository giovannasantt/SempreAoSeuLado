using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimentacao : MonoBehaviour //criando o script de movimentação, que herda do monobehaviour (executável do unity)
{ Vector3 posicao; //chamando a propriedade posicao
     GameObject cachorro ; //chamando o gameobject cachorro
    Cachorro personagem; //chamando a classe cachorro

    // Start is called before the first frame update
    void Start()
    {
        posicao = new Vector3(-12f, 0f, -185f); //definindo a posicao que o objeto será gerado
        transform.position = posicao;
       
        cachorro = Instantiate(Resources.Load("Cachorro"),transform) as GameObject; //instânciando o objeto cachorro
        Cachorro ccachorro = new Cachorro(transform.position, true, cachorro); //criando o cachorro
        Cachorro.InstanciasCachorro++; //contador de quantos cachorros serão gerados (no caso, apenas 1)
        Debug.Log(Cachorro.InstanciasCachorro);
    }
    // Update is called once per frame
    void Update() //código para a movimentação básica do objeto
    {
        posicao.z = 0.2f; //definindo a velocidade de movimento do objeto
        transform.Translate(posicao);
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -32f)
            {
                posicao.x = -0.2f;
                posicao.y = 0f;
                posicao.z = 0f;
                transform.Translate(posicao);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 32f)
            {
                posicao.x = 0.2f;
                posicao.y = 0f;
                posicao.z = 0f;
                transform.Translate(posicao);
            }
        } 
            if (Input.GetKey(KeyCode.Space))
            {
                if (transform.position.y < 10f)
                {
                    posicao.x = 0f;
                    posicao.y = 0.2f;
                    posicao.z = 0f;
                    transform.Translate(posicao);
                }}
        posicao.y = 0;
        posicao.z = 0;
        posicao.x = 0;    }


    private void OnCollisionEnter(Collision collision) //fazendo a colisão entre o cachorro e os outros objetos presentes no jogo 
    {
        Debug.Log("Colidiu"); //verificador para confirmar que o código está funcionando
        if (collision.gameObject.CompareTag("dono")) //verificando se a tag escolhida para que o evento aconteça
        {
            Debug.Log(collision.gameObject.tag); 
        }
        switch (collision.gameObject.tag) //switch que define que o evento irá acontecer
        {
            case "pessoa": //definindo a tag escolhida
                // personagem.Perder(false);
                SceneManager.LoadScene("GameOver"); //definindo a cena que será iniciada após a colisão acontecer
                Debug.Log("colidiu");
                Destroy(this.gameObject); //mandando o objeto ser destruido após colisão
                break;

            case "dono": //definindo a tag escolhida

                // personagem.Ganhar(true);
                SceneManager.LoadScene("Final"); //definindo a cena que será iniciada após a colisão acontecer
                Destroy(this.gameObject); //mandando o objeto ser destruido após colisão
                Debug.Log("colidiu2");
                break;
        }
        }
   



}
