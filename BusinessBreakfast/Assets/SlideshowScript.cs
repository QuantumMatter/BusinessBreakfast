using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SlideshowScript : MonoBehaviour {

    public float speed = 10;
    public Sprite[] sprites;

	// Use this for initialization
	void Start () {
        float xPos = 0;
        float space = 0;
	    for(int i = 0; i < sprites.Length; i++)
        {
            //Create new gameobject and add image to it
            GameObject child = new GameObject();
            child.transform.parent = this.transform;
            Image childImage = child.AddComponent<Image>();
            childImage.sprite = sprites[i];

            //Scale Image
            RectTransform frame = child.GetComponent<RectTransform>();
            float height = Screen.height / 2;
            float width = frame.rect.height;
            float scale = height / frame.rect.height;
            frame.localScale = new Vector3(scale, scale, 1);

            //Position gameobject
            child.transform.localPosition = new Vector3(xPos + space + (frame.rect.width / 2), 0, 0);
            xPos += space + frame.rect.width * 3;
        }
	}
	
	// Update is called once per frame
	void Update () {
	    for(int i = 0; i < this.transform.childCount; i++)
        {
            GameObject child = this.transform.GetChild(i).gameObject;
            child.transform.position = child.transform.position + new Vector3(-speed, 0, 0);
        }
	}
}
