using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_marcador : MonoBehaviour
{

    SpriteRenderer sp;
    Color corAntiga;

    public bool ativo = false;
    public GameObject nota;

    public Score linkS;

    public scr_ativador ativadorLink;

    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        linkS = GameObject.FindGameObjectWithTag("gerenciador").GetComponent<Score>();
    }

    void Start()
    {
        corAntiga = sp.color;
    }

    void Update()
    {

    }

    public void Pressionando()
    {
        StartCoroutine(Pressionado2());
    }

    IEnumerator Pressionado2()
    {
        sp.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sp.color = corAntiga;
    }

    private void OnTriggerEnter(Collider collision)
    {
        ativo = true;
        if (collision.gameObject.tag == "nota")
        {
            nota = collision.gameObject;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "nota")
        {
            ativo = false;
            //linkS.errou();
        }
    }
}
