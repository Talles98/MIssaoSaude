using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int vida = 10;
    public int moedas_loja = 0;
    private GerenciadorDoJogo GJ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDoJogo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "comidas_ruins")
        {
            Destroy(colisao.gameObject);
            vida--;
            if (vida <= 0)
            {
                GJ.Morreu();
            }
        }

        if (colisao.gameObject.tag == "moedas_loja")
        {
            Destroy(colisao.gameObject);
            moedas_loja++;
        }


        if (colisao.gameObject.tag == "bebidas_ruins")
        {
            Destroy(colisao.gameObject);
            vida--;
            if (vida <= 0)
            {
                Debug.Log("Morreu");

            }


            if (colisao.gameObject.tag == "comidas_saudaveis")
            {
                Destroy(colisao.gameObject);
                vida++;
                if (vida >= 1)
                {
                    Debug.Log("Vida adicionada");
                }
            }



            if (colisao.gameObject.tag == "bebidas_saudaveis")
            {
                Destroy(colisao.gameObject);
                vida++;
                if (vida >= 1)
                {
                    Debug.Log("Dinheiro Adicionado");
                }
            }
        }
    }
}
