using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimentacao : MonoBehaviour
{ Vector3 posicao;
     GameObject cachorro ;
    Cachorro personagem;

    // Start is called before the first frame update
    void Start()
    {
        posicao = new Vector3(-12f, 0f, -185f);
        transform.position = posicao;
       
        cachorro = Instantiate(Resources.Load("Cachorro"),transform) as GameObject; 
        Cachorro ccachorro = new Cachorro(transform.position, true, cachorro);
        Cachorro.InstanciasCachorro++;
        Debug.Log(Cachorro.InstanciasCachorro);
    }
    // Update is called once per frame
    void Update()
    {
        posicao.z = 0.2f;
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


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colidiu");
        if (collision.gameObject.CompareTag("dono"))
        {
            Debug.Log(collision.gameObject.tag);
        }
        switch (collision.gameObject.tag)
        {
            case "pessoa":
                // personagem.Perder(false);
                SceneManager.LoadScene("GameOver");
                Debug.Log("colidiu");
                Destroy(this.gameObject);
                break;

            case "dono":

                // personagem.Ganhar(true);
                SceneManager.LoadScene("Final");
                Destroy(this.gameObject);
                Debug.Log("colidiu2");
                break;
        }
        }
   



}
