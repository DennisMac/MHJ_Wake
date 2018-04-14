using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCon : MonoBehaviour {

    public GameObject spawnThis;
    public Vector2 randome2dMax = new Vector2(1.0f,1.0f);
    public Vector2 randome2dMin = new Vector2(-1.0f,-1.0f);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject clone;
        clone = Instantiate(spawnThis,transform.position,transform.rotation);
        //clone.transform.localPosition = new Vector3(Random.Range(randome2dMax, randome2dMin), Random.Range(randome2dMax, randome2dMin), transform.position.z);
        Destroy(clone.gameObject,10);
	}
}
