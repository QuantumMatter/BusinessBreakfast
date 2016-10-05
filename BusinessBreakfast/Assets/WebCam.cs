using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour {

    WebCamTexture webCamTexture;
    Quaternion baseRotation;
	// Use this for initialization
	void Start () {
        webCamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webCamTexture;
        baseRotation = transform.rotation;
        webCamTexture.Play();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.rotation = baseRotation * Quaternion.AngleAxis(webCamTexture.videoRotationAngle, Vector3.up);
	}
}
