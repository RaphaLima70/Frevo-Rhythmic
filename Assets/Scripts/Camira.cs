using UnityEngine;
using System.Collections;

public class Camira : MonoBehaviour {

    public float targetRatio; //The aspect ratio you did for the game.

    void Start()
    {
        targetRatio = 16f / 9f;
        Camera cam = GetComponent<Camera>();
        cam.aspect = targetRatio;
    }

    // Update is called once per frame
    void Update () {
	
	}

}
