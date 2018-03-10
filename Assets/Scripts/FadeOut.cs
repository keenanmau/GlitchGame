using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

    public float fadeStart;
    public float fadeTime;
    Color panelColor = Color.black;
    Image myPanel;

    void Start () {
        myPanel = GetComponent<Image>();
        myPanel.color = panelColor;
        myPanel.CrossFadeAlpha(0f, 0f, true); //applies 0 alpha to image. CrossfadeAlpha cant fade in otherwise. 
        Invoke("fadeAlphaIn", fadeStart);
    }
	
    void fadeAlphaIn()
    {
        myPanel.CrossFadeAlpha(1f, fadeTime, true);
    }
}
