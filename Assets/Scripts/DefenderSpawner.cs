﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {


    public Camera myCamera;


    private StarDisplay starDisplay; 
	// Use this for initialization
	void Start () {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        GameObject defender = Button.selectedDefender;
        int defenderCost = defender.GetComponent<Defenders>().starCost;
        if (starDisplay.UseStars(defenderCost) == StarDisplay.Status.SUCCESS)
        {
            Vector2 rawPos = CalculateWorldPointOfMouseClick();
            Vector2 roundedPos = SnapToGrid(rawPos);
            Instantiate(Button.selectedDefender, roundedPos, Quaternion.identity);
            starDisplay.UseStars(defenderCost);
        }
        else
        {
            Debug.Log("Insufficient stars");

        }
    }

    Vector2 SnapToGrid (Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos[0]);
        float newY = Mathf.RoundToInt(rawWorldPos[1]);
        return new Vector2 (newX, newY);
    }

    private Vector2 CalculateWorldPointOfMouseClick()
    {

        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPos;
    }
}
