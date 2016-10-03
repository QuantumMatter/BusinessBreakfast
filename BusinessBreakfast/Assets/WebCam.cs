using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
        WebCamTexture webCamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webCamTexture;
        webCamTexture.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
