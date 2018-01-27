using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        
        Vector2 playerPos = transform.position;
        playerPos.x -= speed;
        transform.position = playerPos;
	}

}
