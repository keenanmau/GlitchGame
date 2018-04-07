using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    public Camera viewCamera ;

    private GameObject DefendersParent;

    private void Start()
    {
        DefendersParent = GameObject.Find("Defenders");
        if (!DefendersParent)
        {
            DefendersParent = new GameObject("Defenders");
        }
    }

    private void OnMouseDown()
    {
        if (Button.selectedDefender)
        {
            Vector2 snappedPoint = Snap2Grid(CalculateWorldPointOfMouseClick());
            GameObject def = Instantiate(Button.selectedDefender, snappedPoint, Quaternion.identity);
            def.transform.parent = DefendersParent.transform;
        }
    }

    Vector2 CalculateWorldPointOfMouseClick()
    {
        
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distancefromcamera = 10f;
        Vector3 triplet = new Vector3(mouseX, mouseY, distancefromcamera);
        Vector2 worldpoint = viewCamera.ScreenToWorldPoint(triplet);


        return worldpoint;
    }

    Vector2 Snap2Grid(Vector2 rawWorldPos)
    {
        return new Vector2(Mathf.RoundToInt(rawWorldPos.x), Mathf.RoundToInt(rawWorldPos.y));
    }
}
