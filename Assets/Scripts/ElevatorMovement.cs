using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour {
    bool origin;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    //Variable to control if the elevator is "up" or "down" 

    void Update()
    {
        
    }
    public void ActiveElevator()
    {
        if (origin)
        {
            animation["ElevatorMovement"].time = 0;
            animation["Elevator"].speed = 1;
            animation.Play("Elevator");
            isAtOriginalPosition = false;
        }
        else
        {
            animation["Elevator"].time = animation["Elevator"].length;
            animation["Elevator"].speed = -1;
            animation.Play("Elevator");
            isAtOriginalPosition = true;
        }
    }
}