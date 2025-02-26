using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDoJogo : MonoBehaviour
{

    public bool JogoOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarJogo()
    {
        JogoOn = true;
    }

    public bool EstadoDoJogo()
    {
        return JogoOn;
    }
    public void Morreu()
    {
        Reiniciar();
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
