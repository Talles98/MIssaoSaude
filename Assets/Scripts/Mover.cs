using UnityEngine;

public class Mover : MonoBehaviour
{

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
            Movimentar();
        }
    }

    void Movimentar()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 posPersonagem = new Vector3(posMouse.x, posMouse.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, posPersonagem, 0.3f);
        }
    }
}
