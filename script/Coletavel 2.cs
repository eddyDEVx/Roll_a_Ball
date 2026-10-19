using UnityEngine;

public class Coletavel2 : MonoBehaviour
{
    public int valor = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GerenciadorDeJogo.instancia.AdicionarPontos(valor);
            Destroy(gameObject);
        }
    }
}
