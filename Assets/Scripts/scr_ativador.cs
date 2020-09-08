using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ativador : MonoBehaviour
{
    SpriteRenderer sp;
    public KeyCode key;
    Color corAntiga;
    public bool modoCriacao;
    public GameObject n;
    public GameObject destruidor;

    public int idBotao;

    public Score linkS;
    public scr_marcador marcaLink;
    public Transform posicaoMarca;

    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        linkS = GameObject.FindGameObjectWithTag("gerenciador").GetComponent<Score>();
        destruidor = GameObject.FindGameObjectWithTag("destruidor");
    }

    void Start()
    {
        corAntiga = sp.color;
    }

    void Update()
    {

        if (Input.GetKeyDown(key))
        {
            StartCoroutine(Pressionado());
            marcaLink.Pressionando();
        }

        if (modoCriacao)
        {
            destruidor.SetActive(false);
            if (Input.GetKeyDown(key))
            {
                Instantiate(n, posicaoMarca.transform.position, Quaternion.identity);
            }
        }
        else
        {
            destruidor.SetActive(true);
            if (Input.GetKeyDown(key) && marcaLink.ativo)
            {
                marcaLink.ativo = false;
                linkS.acertou();
                Destroy(marcaLink.nota);
            }
            else if (Input.GetKeyDown(key) && marcaLink.ativo == false)
            {
                // linkS.errou();
            }
        }

    }

    /*
    private void OnTriggerEnter(Collider collision)
    {
        marcaLink.ativo = true;
        if (collision.gameObject.tag == "nota")
        {
            marcaLink.nota = collision.gameObject;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "nota")
        {
            marcaLink.ativo = false;
            //linkS.errou();
        }
    }
    */
    IEnumerator Pressionado()
    {
        sp.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sp.color = corAntiga;
    }

    void OnTouchDown()
    {
        StartCoroutine(Pressionado());
        marcaLink.Pressionando();
        if (marcaLink.ativo)
        {
            marcaLink.ativo = false;
            linkS.acertou();
            Destroy(marcaLink.nota);
        }
    }

    void OnTouchStay()
    {

    }

    void OnTouchUp()
    {

    }

    void OnTouchExit()
    {

    }
}
