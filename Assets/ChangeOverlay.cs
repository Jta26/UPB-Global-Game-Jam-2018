using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOverlay : MonoBehaviour {
    [Range(0, 1)]
    public float alpha;
    
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GameObject ov = gameObject;
            var col = ov.GetComponent<Renderer>().material.color;

            col.a = alpha;
            

            ov.GetComponent<Renderer>().material.color = col;
        
	}
}
