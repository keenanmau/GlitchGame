using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public GameObject Defender;
    private Button[] buttonarray;
    private Text costText;

    public static GameObject selectedDefender;

	void Start () {
        buttonarray = GameObject.FindObjectsOfType<Button>();
        costText = GetComponentInChildren<Text>();
        if (!costText) {
            Debug.Log(name + " Cost Text not found");
        }
        costText.text = Defender.GetComponent<Defender>().starCost.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        foreach(Button thisbutton in buttonarray)
        {
            thisbutton.GetComponent<SpriteRenderer>().color = Color.black;
        }
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.white;

        selectedDefender = Defender;
    }


}

