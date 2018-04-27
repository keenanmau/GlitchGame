using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

    public  int starTotal = 200;
    private Text textBox;
    public enum Status { SUCCESS , FAILURE};

	void Start () {
        textBox = GetComponent<Text>();
        UpdateText();        
	}

    public void AddStars(int num) {
        starTotal += num;
        UpdateText();
    }

    public Status UseStars(int num) {
        if(num <= starTotal) {
            starTotal -= num;
            UpdateText();
            return Status.SUCCESS;
        } else {
            Debug.Log("Star Total insufficient");
            return Status.FAILURE;
        }
        
    }
    
    private void UpdateText() {
        textBox.text = starTotal.ToString();
    }
}
