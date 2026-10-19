using TMPro;
using UnityEngine;

public class GerenciadorDeJogo : MonoBehaviour
{
    public static GerenciadorDeJogo instancia;
    public TextMeshProUGUI textoPontuacao;

    private int pontuacao = 0;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        AtualizarTexto();
    }

    public void AdicionarPontos(int quantidade)
    {
        pontuacao += quantidade;
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
       textoPontuacao.text = "Pontuação: " + pontuacao;
    }

  }


