using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    [SerializeField]
    private float speed =0;
    [SerializeField]
   private float fireIntervel=100;
    [SerializeField]
    private float shotExpansionMultiplier=1;
    [SerializeField]
    private float shotDirectionDegrees=30;
    [SerializeField]
    private Vector2 shotSpeed= new Vector2(0,0);
    [SerializeField]
    private float shotKillTime = 100; 

    private float counter=0;
    public GameObject shotPrefab;
    public Transform shotSpawn;
   
    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        Move();
        Emission();
    }

    private void Move()
    {
        Vector2 playerPos = transform.position;
        playerPos.x -= speed;
        transform.position = playerPos;
        
    }

    private void Emission()
    {
       if(counter<fireIntervel)
        { counter += 1;
        }else if (counter>=fireIntervel)
        {
            counter = 0;
            Fire();
        }

    }
    private void Fire()
    {
        float x = shotSpawn.transform.position.x;
        float y = shotSpawn.transform.position.y;
        float z = shotSpawn.transform.position.z; 
        GameObject Shot = Instantiate(shotPrefab, new Vector3(x,y,z), new Quaternion(0,0,shotDirectionDegrees,0)) as GameObject;
        ShotController shotContGetter = Shot.GetComponent<ShotController>();
        shotContGetter.GetShotStats(shotSpeed,shotKillTime,shotExpansionMultiplier);
        Vector3 rotA = Shot.transform.position;
        rotA.z = shotDirectionDegrees;
        Shot.transform.Rotate(rotA);
       
}
   
}
