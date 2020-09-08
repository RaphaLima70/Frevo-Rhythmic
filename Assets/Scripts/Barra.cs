using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    public Score link;

    public Image barraDeVida;

    public Text pontuacaoText;
    public Text multiplicadorText;
    public Text comboText;

    private void Awake()
    {
        link = GameObject.FindGameObjectWithTag("gerenciador").GetComponent<Score>();
    }

    void Update()
    {
        barraDeVida.fillAmount = link.energia/100;
        pontuacaoText.text = ("" + link.pontos);
        multiplicadorText.text = ("x" + link.multiplicador);
        comboText.text = (""+link.combo);

    }
}
