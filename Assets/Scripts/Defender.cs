using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

    public int starCost = 100;
    private StarDisplay stardisplay;
    
    private void Start()
    {
        stardisplay = GameObject.FindObjectOfType<StarDisplay>();
    }

    private void AddStars(int num)
    {
        stardisplay.AddStars(num);
    }
}
