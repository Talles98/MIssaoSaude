using UnityEngine;

public class Criador : MonoBehaviour
{


    public GameObject Agua;

    public GameObject Alface;

    public GameObject Cerveja;

    public GameObject Cookie;

    public GameObject Hamburguer;

    public GameObject Maca;

    public GameObject Melancia;

    public GameObject Moedas;

    public GameObject Pizza;

    public GameObject Refrigerante;

    public GameObject Refrigerante_zero;

    public GameObject Sanduiche;

    public float meutempo = 0f;

    private GerenciadorDoJogo GJ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDoJogo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GJ.EstadoDoJogo() == true)
        {
            Temporizador();
        }

        
    }

    void Temporizador()
    {
        meutempo += Time.deltaTime;
        if (meutempo > 1)
        {
            meutempo = 0;
            float chance = Random.Range(0, 10);
            if (chance <= 5)
            {
                CriarHamburguer();
            }
            else
            {
                CriarMoedas();
            }
        }

    }

    void CriarHamburguer()
    {


        float posX = Random.Range(-2.5f, 2.5f);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject MeuHamburguer = Instantiate(Hamburguer, posInicial, Quaternion.identity);
        Destroy(MeuHamburguer, 3f);
    }

    void CriarMoedas()
    {


        float posX = Random.Range(-2.5f, 2.5f);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject MinhaMoeda = Instantiate(Moedas, posInicial, Quaternion.identity);
        Destroy(MinhaMoeda, 3f);


    }
}
