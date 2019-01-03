using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hache: MonoBehaviour {
    public float min = 2f;
    public float max = 3f;
    public float speed = 9999999999999999999999999999999f;

    // Use this for initialization
    void Start () {
        min = transform.position.x;
        max = transform.position.x + 3;

    }
	
	// Update is called once per frame
	void Update () {
        
        float rotate = speed * Time.deltaTime;
        float currentRotation = gameObject.transform.rotation.z;
        Quaternion rotation = Quaternion.Euler(0, 0, currentRotation + rotate);
        gameObject.transform.rotation = rotation;
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);

    }
}
