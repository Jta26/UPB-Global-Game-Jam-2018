using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {
    public float speed;
    private float realSpeed;
    public float currentDam;
    public float recoverRate;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        realSpeed = speed+currentDam;
        Vector2 playerPos = transform.position;
        playerPos.x -= realSpeed;
        transform.position = playerPos;
        Recovery();

    }

    void Recovery()
    {
        if(currentDam>0)
        { currentDam -= recoverRate; }
    }

}
