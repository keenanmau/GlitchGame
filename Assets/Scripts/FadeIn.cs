using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
    
    public float fadeTime = 3f;
    Color panelColor = Color.black;
    Image myPanel;
    void Start () {
        myPanel = GetComponent<Image>();
        myPanel.color = panelColor;
        myPanel.CrossFadeAlpha(0f, fadeTime, true);
        Invoke("removePanel", fadeTime);
    }
	


    private void removePanel()
    {
        gameObject.SetActive(false);
    }
}
