using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_nota : MonoBehaviour
{

    Rigidbody rb;
    public float velocidade;

    public Score link;

    private void Awake()
    {
        link = GameObject.FindGameObjectWithTag("gerenciador").GetComponent<Score>();
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        rb.velocity = new Vector2(-velocidade, 0);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "destruidor")
        {
            link.errou();
            Destroy(gameObject, 0.5f);
        }
    }
}
