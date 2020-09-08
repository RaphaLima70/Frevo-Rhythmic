using UnityEngine;
using System.Collections;

public class Musica : MonoBehaviour {

    public AudioSource som;


	// Use this for initialization
	void Start () {

        som.Play(33075 * 3);

	}
	
	// Update is called once per frame
	void Update () {

	}
}
