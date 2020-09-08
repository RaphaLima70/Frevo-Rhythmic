using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public int pontos;
    public int combo;
    public int multiplicador;

    public int energiaMax;
    public float energia;

    public GameObject Hud;
    public GameObject derrota;


    public AudioSource musica;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;

        pontos = 0;
        combo = 0;
        multiplicador = 1;

        energiaMax = 100;
        energia = energiaMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (energia >= energiaMax)
        {
            energia = energiaMax;
        }
        else if (energia <= 0)
        {
            energia = 0;

            Time.timeScale = 0f;
            //Hud.SetActive(false);
            //derrota.SetActive(true);
            Application.LoadLevel(Application.loadedLevelName);
        }

        if (combo < 10)
        {
            multiplicador = 1;
        }

        else if (combo < 20 && combo > 10)
        {
            multiplicador = 2;
        }

        else if (combo < 50 && combo > 25)
        {
            multiplicador = 3;
        }

        else if (combo > 50)
        {
            multiplicador = 4;
        }
    }

    public void acertou()
    {
        energia += 5;
        pontos = pontos + (10 * multiplicador);
        combo++;
        musica.volume = 1;
    }

    public void errou()
    {
        energia -= 5;
        musica.volume = 0.3f;
        combo = 0;
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }
}
