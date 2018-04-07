using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject Defender;
    private Button[] buttonarray;

    public static GameObject selectedDefender;

	void Start () {
        buttonarray = GameObject.FindObjectsOfType<Button>();
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

