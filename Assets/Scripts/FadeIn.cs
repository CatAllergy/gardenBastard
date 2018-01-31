using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public float fadeSpeed = 2f;
    private Image image;

	// Use this for initialization
	void Start () {
        image = gameObject.GetComponentInChildren<Image>();
        image.canvasRenderer.SetAlpha(0f);
        fadeInImage();
        Invoke("fadeOutImage",4f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void fadeInImage()
    {
        //float imageAlpha = image.color.a;
        
        image.CrossFadeAlpha(1f,1.5f, false);
    }
    void fadeOutImage()
    {
        image.CrossFadeAlpha(0f, 1.5f, false);
    }
}
